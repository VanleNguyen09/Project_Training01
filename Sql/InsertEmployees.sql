SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
USE EmployeeManagement
GO	
CREATE OR ALTER PROCEDURE InsertEmployees
	-- Add the parameters for the stored procedure here
	--@department_id INT,
    @name NVARCHAR(255),
    @phone VARCHAR(20),
    @address NVARCHAR(255),
	@gender BIT,
    @birthday DATETIME,
    @email VARCHAR(255),
	@image VARBINARY(MAX),
	@status INT
AS
BEGIN
	DECLARE @exist INT
	SET @exist = 0

	IF EXISTS (SELECT 1 FROM dbo.Employees WHERE phone = @phone AND status = 1)
	BEGIN
		SET @exist = 1
	END
	ELSE	
	BEGIN
		DECLARE @emp_id INT 
		UPDATE dbo.Employees
		SET status = 0
		WHERE id = @emp_id

		UPDATE dbo.Employees
		SET status = 1
		WHERE id = @emp_id AND status = 0
		UPDATE dbo.Dept_manager SET status = 1 WHERE emp_id = @emp_id AND status = 0
		UPDATE dbo.Dept_emp SET status = 1 WHERE emp_id = @emp_id AND status = 0

		IF @@ROWCOUNT = 0
		BEGIN	
			INSERT INTO dbo.Employees
			(	name,
			    phone,
			    address,
			    gender,
			    birthday,
			    email,
			    image,
			    status
			)
			VALUES(@name, @phone, @address, @gender, @birthday, @email, 
			@image, @status)
		END 
	END
	SELECT @exist AS IsDuplicate
END
GO
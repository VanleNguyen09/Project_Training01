SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
USE EmployeeManagement
GO	
CREATE OR ALTER PROCEDURE UpdateEmployees
	-- Add the parameters for the stored procedure here
	@id INT,
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

	IF EXISTS (SELECT 1 FROM dbo.Employees WHERE phone = @phone AND id <> @id AND status = 1)
	BEGIN
		SET @exist = 1
	END
	ELSE	
	BEGIN
		
		UPDATE dbo.Employees
		SET status = 0
		WHERE id = @id

		UPDATE dbo.Employees
		SET status = 1, name = @name, phone = @phone, address = @address, 
		gender = @gender, birthday = @birthday, email = @email, image = @image
		WHERE id = @id AND status = 0

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

    SELECT @exist AS IsDuplicate;
END
GO
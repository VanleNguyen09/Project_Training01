SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
USE EmployeeManagement
GO	
CREATE OR ALTER PROCEDURE UpdateEmployees
	-- Add the parameters for the stored procedure here
	@id INT,
	@department_id INT,
    @name NVARCHAR(255),
    @phone VARCHAR(20),
    @address NVARCHAR(255),
	@gender BIT,
    @birthday DATETIME,
    @email VARCHAR(255),
	@image VARBINARY(MAX)
	@status INT
AS
BEGIN
	UPDATE Employees
	SET name = @name,
		phone = @phone,
		address = @address,
		gender = @gender,
		birthday = @birthday,
		email = @email,
		image = @image,
	WHERE id = @id
	UPDATE dbo.Dept_emp
	SET dept_id = @department_id
	WHERE emp_id = @id
END
GO
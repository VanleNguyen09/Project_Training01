USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[InsertEmployees]
	-- Add the parameters for the stored procedure here
    @name NVARCHAR(255),
	@department_id INT,
    @phone VARCHAR(20),
    @address NVARCHAR(255),
	@gender BIT,
    @birthday DATETIME,
    @email VARCHAR(255),
	@image VARBINARY(MAX), 
	@status INT
AS
BEGIN
	INSERT INTO Employees
	(
	    name,
	    phone,
	    address,
	    gender,
	    birthday,
	    email,
		image,
		status
	)
	VALUES(@name, @phone, @address, @gender, @birthday, @email, @image, @status)
	DECLARE @generated_id INT
	SET @generated_id = SCOPE_IDENTITY()
	INSERT INTO dbo.Dept_emp(emp_id, dept_id)
	VALUES(@generated_id, @department_id)
END
GO
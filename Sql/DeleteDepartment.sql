SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

USE EmployeeManagement
GO	

ALTER PROCEDURE DeleteDepartment
	-- Add the parameters for the stored procedure here
	@id INT
AS
BEGIN	
	DELETE FROM	dbo.Dept_emp
	WHERE dept_id = @id
	DELETE FROM dbo.Department
	WHERE id = @id
END
GO

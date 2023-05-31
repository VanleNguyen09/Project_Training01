SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
USE EmployeeManagement
GO	
CREATE OR ALTER PROCEDURE DeleteDepartment
	-- Add the parameters for the stored procedure here
	@id INT
AS
BEGIN	
	UPDATE dbo.Dept_emp
	SET status = 0
	WHERE dept_id = @id
	UPDATE dbo.Dept_manager
	SET status = 0
	WHERE dept_id = @id
	UPDATE dbo.Department
	SET status = 0
	WHERE id = @id
END
GO


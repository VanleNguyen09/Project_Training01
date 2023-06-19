SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
USE EmployeeManagement
GO	
CREATE OR ALTER PROCEDURE DeleteManagerInDepartment
	@emp_id INT,
	@dept_id INT
AS
BEGIN
	UPDATE dbo.Dept_manager
	SET status = 0
	WHERE emp_id = @emp_id AND dept_id = @dept_id
	 
	DECLARE @managerCount INT, @employeeCount INT
	SELECT @managerCount = COUNT(*) 
	FROM dbo.Dept_manager
	WHERE dept_id = @dept_id

	SELECT @employeeCount = COUNT(*)
	FROM dbo.Dept_emp
	WHERE dept_id = @dept_id

	IF @managerCount = 0 AND @employeeCount = 0
		UPDATE dbo.Department
		SET status = 0
		WHERE id = @dept_id
END
GO
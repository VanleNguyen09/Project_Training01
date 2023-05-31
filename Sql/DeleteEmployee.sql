USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[DeleteEmployee] 	
	@id INT
AS
BEGIN
	UPDATE 	dbo.Dept_emp
	SET status = 0
	WHERE emp_id = @id
	UPDATE Salaries
	SET status = 0
	WHERE emp_id = @id
	UPDATE dbo.Dept_manager
	SET status = 0
	WHERE emp_id = @id
	UPDATE dbo.Employees
	SET	status = 0
	WHERE id = @id
END
GO
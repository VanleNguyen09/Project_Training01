USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[DeleteEmployee] 	
	@id INT
AS
BEGIN
	DELETE FROM	dbo.Dept_emp
	WHERE emp_id = @id
	DELETE FROM dbo.Employees
	WHERE id = @id
END
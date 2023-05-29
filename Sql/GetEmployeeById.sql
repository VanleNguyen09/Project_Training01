USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[GetEmployeeByID] 	
	@id INT
AS
BEGIN
	SELECT b.dept_id, a.* FROM dbo.Employees AS a
	JOIN dbo.Dept_emp AS b
	ON a.id = b.emp_id
	WHERE b.emp_id = @id
END
GO
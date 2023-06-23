USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[MaxDeptEmp]
AS
BEGIN
	SELECT TOP 1 a.name AS department_name, COUNT(b.emp_id) AS employee_count
	FROM dbo.Department a
	JOIN dbo.Dept_emp b 
	ON a.id = b.dept_id
	JOIN dbo.Employees c
	ON c.id = b.emp_id
	WHERE b.status = 1
	GROUP BY a.id, a.name
	ORDER BY COUNT(b.emp_id) DESC
	
END
GO
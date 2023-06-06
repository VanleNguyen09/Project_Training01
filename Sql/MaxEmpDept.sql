USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[MaxEmpDept]
AS
BEGIN
	SELECT TOP 1 a.name AS employee_name, COUNT(b.dept_id) AS department_count
	FROM dbo.Employees a
	JOIN dbo.Dept_emp b 
	ON a.id = b.emp_id
	JOIN dbo.Department c
	ON c.id = b.dept_id
	WHERE b.status = 1
	GROUP BY a.id, a.name
	ORDER BY COUNT(b.dept_id) DESC
END
GO	

--EXEC dbo.MaxEmpDept
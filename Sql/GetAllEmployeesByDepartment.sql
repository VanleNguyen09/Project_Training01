USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[GetAllEmployeesByDepartment]
AS
BEGIN
	SELECT a.*, c.name AS department_name, b.id AS deptemp_id, b.dept_id AS dept_id,
	b.from_date AS from_date, b.to_date AS to_date FROM dbo.Employees a
	JOIN dbo.Dept_emp b
	ON a.id = b.emp_id
	JOIN dbo.Department c
	ON c.id = b.dept_id
	WHERE b.status = 1 AND b.from_date IS NOT NULL AND b.to_date IS NOT NULL
	ORDER BY b.id ASC
END
GO

EXEC dbo.GetAllEmployeesByDepartment

--SELECT a.*,  b.name AS Dept_name, c.name AS Emp_name   
--FROM dbo.Dept_emp a
--JOIN dbo.Department b
--ON a.dept_id = b.id
--JOIN dbo.Employees c
--ON a.emp_id = c.id
--WHERE a.emp_id = 78 AND a.dept_id = 61	


--SELECT a.*,  b.name AS Dept_name, c.name AS Emp_name   
--FROM dbo.Dept_manager a
--JOIN dbo.Department b
--ON a.dept_id = b.id
--JOIN dbo.Employees c
--ON a.emp_id = c.id
--WHERE a.emp_id = 78 AND a.dept_id = 61
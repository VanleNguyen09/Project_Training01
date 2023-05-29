USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[GetAllEmployeesByDepartment]
AS
BEGIN
	SELECT a.*, c.name AS department_name FROM dbo.Employees a
	JOIN dbo.Dept_emp b
	ON a.id = b.emp_id
	JOIN dbo.Department c
	ON c.id = b.dept_id
	WHERE a.status = 1
	ORDER BY c.name, a.name
END
GO

EXEC dbo.GetAllEmployeesByDepartment
SELECT * FROM dbo.Employees
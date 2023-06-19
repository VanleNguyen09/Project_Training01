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
	ORDER BY b.id DESC
END
GO

EXEC dbo.GetAllEmployeesByDepartment
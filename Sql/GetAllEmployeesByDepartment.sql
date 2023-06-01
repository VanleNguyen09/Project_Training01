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
	ORDER BY c.name, a.name
END
GO

EXEC dbo.GetAllEmployeesByDepartment

SELECT * FROM dbo.Dept_manager 
WHERE STATUS = 0
ORDER BY emp_id ASC, dept_id ASC



--UPDATE dbo.Dept_emp
--SET from_date = GETDATE(), to_date = GETDATE()
--WHERE from_date IS NULL AND to_date IS NULL
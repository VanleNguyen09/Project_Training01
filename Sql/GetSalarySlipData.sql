USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[GetSalarySlipData]
AS
BEGIN
	SELECT a.id, a.name, a.phone, a.address, b.salary_name, b.salary, 
	d.name AS department_name, c.from_date AS fromDate_dept,
	f.name AS position_name, e.from_date AS fromDate_pos
	FROM dbo.Employees a
	INNER JOIN dbo.SalaryEmp b  
	ON a.salary_emp_id = b.id AND b.status = 1
	INNER JOIN dbo.Dept_emp c
	ON c.emp_id = a.id AND c.status = 1
	INNER JOIN dbo.Department d
	ON c.dept_id = d.id AND d.status = 1
	INNER JOIN dbo.Emp_Pos e
	ON e.emp_id = a.id AND e.status = 1
	INNER JOIN dbo.Position f
	ON f.id = e.pos_id
	WHERE a.status = 1 
END
GO

EXEC dbo.GetSalarySlipData
GO	
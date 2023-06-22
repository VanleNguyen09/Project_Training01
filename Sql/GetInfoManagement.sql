USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[GetInfoManagement]
AS
BEGIN
	DECLARE @Department INT = (	SELECT COUNT(*) FROM dbo.Department WHERE status = 1)

	DECLARE @Employee INT = (SELECT COUNT(*) FROM dbo.Employees WHERE status = 1)

	DECLARE @Manager INT = 	(SELECT COUNT(*) FROM dbo.Dept_manager WHERE STATUS = 1)

	DECLARE @Position INT = (SELECT COUNT(*) FROM dbo.Position WHERE status = 1)

	DECLARE @Salaries INT = (SELECT SUM(salary) FROM dbo.SalaryEmp WHERE status = 1)

	DECLARE @Leaves INT = (SELECT COUNT(*) AS SL_Leaves FROM dbo.leave WHERE status = 1)

	DECLARE @Emp_Name_Dept NVARCHAR(255) = (SELECT TOP 1 CONCAT(a.name, ' - ',
	COUNT(b.dept_id)) FROM dbo.Employees a
	JOIN dbo.Dept_emp b 
	ON a.id = b.emp_id
	JOIN dbo.Department c
	ON c.id = b.dept_id
	WHERE b.status = 1
	GROUP BY a.id, a.name
	ORDER BY COUNT(b.dept_id) DESC)
	
	DECLARE @Dept_Name_Emp NVARCHAR(255) = (SELECT TOP 1 CONCAT(a.name, ' - ', 
	COUNT(b.emp_id)) FROM dbo.Department a
	JOIN dbo.Dept_emp b 
	ON a.id = b.dept_id
	JOIN dbo.Employees c
	ON c.id = b.emp_id
	WHERE b.status = 1
	GROUP BY a.id, a.name
	ORDER BY COUNT(b.emp_id) DESC)

	DECLARE @Dept_Manager_Name NVARCHAR(255) = (SELECT TOP 1 CONCAT(a.name, ' - ', 
	COUNT(b.dept_id)) FROM dbo.Employees a
	JOIN dbo.Dept_manager b 
	ON a.id = b.emp_id
	JOIN dbo.Department c
	ON c.id = b.dept_id
	WHERE b.status = 1
	GROUP BY a.id, a.name
	ORDER BY COUNT(b.dept_id) DESC)

	DECLARE @Pos_Name_Emp NVARCHAR(255) = (SELECT TOP 1 CONCAT(a.name, ' - ', 
	COUNT(b.emp_id)) FROM dbo.Position a
	JOIN dbo.Emp_Pos b 
	ON a.id = b.pos_id
	JOIN dbo.Employees c
	ON c.id = b.emp_id
	WHERE b.status = 1
	GROUP BY a.id, a.name
	ORDER BY COUNT(b.emp_id) DESC)

	SELECT @Department AS SL_DP , @Employee AS SL_NV, @Manager AS SL_MG,
	@Position AS SL_PS, @Salaries AS TOTAL_SALARIES, @Leaves AS SL_Leaves,
	@Emp_Name_Dept AS EmpDeptMax, @Dept_Name_Emp AS DeptEmpMax, 
	@Dept_Manager_Name AS DeptManagerMax, @Pos_Name_Emp AS PosEmpMax
END
GO
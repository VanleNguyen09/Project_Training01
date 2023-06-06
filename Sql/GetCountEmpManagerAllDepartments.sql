SET ANSI_NULLS ON
GO
USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[GetCountEmpManagerAllDepartments]
AS
BEGIN
	SELECT a.id, a.name, a.status, ISNULL(COUNT(DISTINCT b.emp_id), 0) AS Number_Emp, ISNULL(COUNT(DISTINCT d.emp_id), 0) 
	AS Number_Manager FROM dbo.Department a
	LEFT JOIN dbo.Dept_emp b
	ON a.id = b.dept_id AND b.status = 1
	LEFT JOIN dbo.Employees c
	ON c.id = b.emp_id
	LEFT JOIN dbo.Dept_manager d
	ON d.dept_id = a.id AND d.status = 1
	WHERE a.status = 1
	GROUP BY a.id, a.name, a.status
	ORDER BY a.id
END
GO

EXEC dbo.GetCountEmpManagerAllDepartments
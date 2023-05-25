USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[GetAllEmployeesManager]
AS
BEGIN
	SELECT a.*, c.name AS department_name, 
	b.from_date AS from_date, b.to_date AS to_date 
	FROM dbo.Employees a
	JOIN dbo.Dept_manager b
	ON a.id = b.emp_id
	JOIN dbo.Department c
	ON c.id = b.dept_id
	ORDER BY c.name, a.name
END
GO	
USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[GetAllEmployeesManager]
AS
BEGIN
	SELECT a.*,c.name AS department_name, b.id AS deptmanager_id, b.dept_id AS dept_id,
	b.from_date AS from_date, b.to_date AS to_date 
	FROM dbo.Employees a
	JOIN dbo.Dept_manager b
	ON a.id = b.emp_id
	JOIN dbo.Department c
	ON c.id = b.dept_id
	WHERE b.status = 1
	ORDER BY b.id ASC
END
GO

EXEC dbo.GetAllEmployeesManager
GO	

--SELECT * FROM dbo.Dept_manager 
--WHERE STATUS = 0
--ORDER BY emp_id ASC, dept_id ASC

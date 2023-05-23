
USE [EmployeeManagement]
GO
/****** Object:  StoredProcedure [dbo].[GetAllEmployees]    Script Date: 17/05/2023 17:19:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllEmployeesByDepartment]
AS
BEGIN
	SELECT a.*, c.name AS department_name FROM dbo.Employees a
	JOIN dbo.Dept_emp b
	ON a.id = b.emp_id
	JOIN dbo.Department c
	ON c.id = b.dept_id
	ORDER BY c.name, a.name
END

EXEC dbo.GetAllEmployeesByDepartment
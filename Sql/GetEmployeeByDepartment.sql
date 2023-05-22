USE [EmployeeManagement]
GO
/****** Object:  StoredProcedure [dbo].[GetEmployeeByDepartment]    Script Date: 19/05/23 04:04:46 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[GetEmployeeByDepartment]
	@department_id INT
as

BEGIN
	SELECT e.*, c.name AS department_name FROM dbo.Employees AS e
	JOIN dbo.Dept_emp AS b 
	ON e.id = b.emp_id 
	JOIN dbo.Department AS c
	ON c.id = b.dept_id
	WHERE b.dept_id = @department_id
	ORDER BY e.name
END

EXEC dbo.GetEmployeeByDepartment @department_id = 1


--SELECT b.dept_id, a.* FROM dbo.Employees AS a
--JOIN dbo.Dept_emp AS b
--ON a.id = b.emp_id
--WHERE b.emp_id = '1'


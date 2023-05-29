
USE [EmployeeManagement]
GO
/****** Object:  StoredProcedure [dbo].[GetEmployeesByName]    Script Date: 17/05/2023 17:19:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[GetEmployeesByKeyWord]
	@keyword NVARCHAR(255),
	@department_id INT
AS
BEGIN
	IF @department_id != -1 
	BEGIN
	SELECT a.*, c.name AS department_name FROM dbo.Employees a
	JOIN dbo.Dept_emp b
	ON a.id = b.emp_id
	JOIN dbo.Department c
	ON c.id = b.dept_id
	WHERE (a.id LIKE @keyword OR 
	a.name LIKE '%' + @keyword  + '%' OR 
	phone LIKE '%' + @keyword + '%' OR
	a.address  LIKE '%' + @keyword + '%'
	OR a.email LIKE '%' + @keyword + '%'
	OR c.name  LIKE '%' + @keyword + '%') AND (a.status = 1) AND (b.dept_id = @department_id) 
	ORDER BY c.name, a.name
	END
	ELSE 
	BEGIN 
	SELECT a.*, c.name AS department_name FROM dbo.Employees a
	JOIN dbo.Dept_emp b
	ON a.id = b.emp_id
	JOIN dbo.Department c
	ON c.id = b.dept_id
	WHERE (a.id LIKE @keyword OR 
	a.name LIKE '%' + @keyword  + '%' OR 
	phone LIKE '%' + @keyword + '%' OR
	a.address  LIKE '%' + @keyword + '%'
	OR a.email LIKE '%' + @keyword + '%'
	OR c.name  LIKE '%' + @keyword + '%') AND (a.status = 1)
	ORDER BY c.name, a.name  
	END
END
GO

USE [EmployeeManagement]
GO
/****** Object:  StoredProcedure [dbo].[GetEmployeesByName]    Script Date: 17/05/2023 17:19:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[GetEmployeesByKeyWord]
	@keyword NVARCHAR(255)
AS
BEGIN
	SELECT a.*, c.name AS department_name FROM dbo.Employees a
	JOIN dbo.Dept_emp b
	ON a.id = b.emp_id
	JOIN dbo.Department c
	ON c.id = b.dept_id
	WHERE a.name  LIKE '%' + @keyword  + '%' OR 
	phone LIKE '%' + @keyword + '%' OR
	a.address  LIKE '%' + @keyword + '%'
	OR a.email LIKE '%' + @keyword + '%'
	OR c.name  LIKE '%' + @keyword + '%'
	ORDER BY c.name, a.name
	
END


EXEC dbo.GetEmployeesByKeyWord @keyword = N'%Thoảng%' 

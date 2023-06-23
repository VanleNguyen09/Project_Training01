
USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[GetEmpDeptByKeyWord]
	@keyword NVARCHAR(255),
	@department_id INT,
	@currentPage INT,
	@pageSize INT
AS
BEGIN
	DECLARE @starIndex INT, @rowsToFetch INT;
	SET @starIndex = (@currentPage - 1) * @pageSize
	SET @rowsToFetch = @pageSize;
	IF @department_id != -1 
	BEGIN
	SELECT a.*, c.name AS department_name, b.id AS deptemp_id, 
	b.dept_id AS dept_id, b.from_date AS from_date, b.to_date AS to_date 
	FROM dbo.Employees a
	JOIN dbo.Dept_emp b
	ON a.id = b.emp_id
	JOIN dbo.Department c
	ON c.id = b.dept_id
	WHERE (a.id LIKE @keyword OR 
	a.name LIKE '%' + @keyword  + '%' OR 
	phone LIKE '%' + @keyword + '%' OR
	a.address  LIKE '%' + @keyword + '%'
	OR a.email LIKE '%' + @keyword + '%'
	OR c.name  LIKE '%' + @keyword + '%'
	OR from_date LIKE '%' + @keyword + '%' OR to_date 
	LIKE '%' + @keyword + '%') AND (b.status = 1 AND a.status = 1)
	AND (b.dept_id = @department_id)
	ORDER BY b.id DESC
	OFFSET @starIndex ROWS
	FETCH NEXT @rowsToFetch ROWS ONLY
	END
	ELSE 
		BEGIN 
	SELECT a.*, c.name AS department_name, b.id AS deptemp_id,
	b.dept_id AS dept_id, b.from_date AS from_date, b.to_date AS to_date 
	FROM dbo.Employees a
	JOIN dbo.Dept_emp b
	ON a.id = b.emp_id
	JOIN dbo.Department c
	ON c.id = b.dept_id
	WHERE (a.id LIKE @keyword OR 
	a.name LIKE '%' + @keyword  + '%' OR 
	phone LIKE '%' + @keyword + '%' OR
	a.address  LIKE '%' + @keyword + '%'
	OR a.email LIKE '%' + @keyword + '%'
	OR c.name  LIKE '%' + @keyword + '%'
	OR from_date LIKE '%' + @keyword + '%' OR to_date 
	LIKE '%' + @keyword + '%') AND (b.status = 1 AND a.status = 1)
	ORDER BY b.id DESC
	OFFSET @starIndex ROWS
	FETCH NEXT @rowsToFetch ROWS ONLY
END
END
GO

EXEC dbo.GetEmpDeptByKeyWord @keyword = N'Phong',    -- nvarchar(255)
                             @department_id = 2, -- int
							 @currentPage = 1,
							 @pageSize = 10

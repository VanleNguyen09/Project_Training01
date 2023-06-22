﻿USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[GetManagersByKeyWord]
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
	SELECT b.*, c.name AS department_name, a.dept_id AS dept_id,
	b.id AS deptmanager_id, a.from_date AS from_date, a.to_date AS to_date 
	FROM dbo.Dept_manager a
	JOIN dbo.Employees b
	ON b.id = a.emp_id
	JOIN dbo.Department c
	ON c.id = a.dept_id
	WHERE (b.id LIKE @keyword OR 
	b.name LIKE '%' + @keyword  + '%' OR 
	b.phone LIKE '%' + @keyword + '%' OR
	b.address  LIKE '%' + @keyword + '%'
	OR b.email LIKE '%' + @keyword + '%'
	OR c.name  LIKE '%' + @keyword + '%'
	OR a.from_date LIKE '%' + @keyword + '%' OR a.to_date 
	LIKE '%' + @keyword + '%')  AND (a.status = 1  AND b.status = 1) 
	AND (a.dept_id = @department_id)
	ORDER BY a.id DESC
	OFFSET @starIndex ROWS
	FETCH NEXT @rowsToFetch ROWS ONLY
	END
	ELSE 
		BEGIN 
	SELECT b.*, c.name AS department_name, a.dept_id AS dept_id,
	b.id AS deptmanager_id, a.from_date AS from_date, a.to_date AS to_date 
	FROM dbo.Dept_manager a
	JOIN dbo.Employees b
	ON b.id = a.emp_id
	JOIN dbo.Department c
	ON c.id = a.dept_id
	WHERE (b.id LIKE @keyword OR 
	b.name LIKE '%' + @keyword  + '%' OR 
	b.phone LIKE '%' + @keyword + '%' OR
	b.address  LIKE '%' + @keyword + '%'
	OR b.email LIKE '%' + @keyword + '%'
	OR c.name  LIKE '%' + @keyword + '%'
	OR a.from_date LIKE '%' + @keyword + '%' OR a.to_date 
	LIKE '%' + @keyword + '%') AND (a.status = 1 AND b.status = 1)
	ORDER BY a.id DESC
	OFFSET @starIndex ROWS
	FETCH NEXT @rowsToFetch ROWS ONLY
	END
END
GO
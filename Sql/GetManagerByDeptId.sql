USE [EmployeeManagement]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE GetManagerByDeptId
	@dept_id INT,
	@currentPage INT,
	@pageSize INT
AS
BEGIN
	DECLARE @starIndex INT, @rowsToFetch INT;
	SET @starIndex = (@currentPage - 1) * @pageSize
	SET @rowsToFetch = @pageSize;

    -- Insert statements for procedure here
	SELECT a.*, c.name AS department_name, b.id AS deptmanager_id, b.dept_id AS dept_id,
	b.from_date AS from_date, b.to_date AS to_date  
	FROM Employees a
	INNER JOIN dbo.Dept_manager b
	ON a.id = b.emp_id
	INNER JOIN dbo.Department c
	ON c.id = b.dept_id
	WHERE b.dept_id = @dept_id AND b.status = 1
	ORDER BY b.id
	OFFSET @starIndex ROWS
	FETCH NEXT @rowsToFetch ROWS ONLY
END
GO

USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[GetEmployeesByKeyWord]
	@keyword NVARCHAR(255),
	@currentPage INT,
	@pageSize INT
AS
BEGIN
	DECLARE @starIndex INT, @rowsToFetch INT;
	SET @starIndex = (@currentPage - 1) * @pageSize
	SET @rowsToFetch = @pageSize;
	SELECT * FROM dbo.Employees a
	WHERE (id LIKE @keyword OR 
	name LIKE '%' + @keyword  + '%' OR 
	phone LIKE '%' + @keyword + '%' OR
	address  LIKE '%' + @keyword + '%'
	OR email LIKE '%' + @keyword + '%') AND (status = 1)
	ORDER BY id DESC
	OFFSET @starIndex ROWS
	FETCH NEXT @rowsToFetch ROWS ONLY
END
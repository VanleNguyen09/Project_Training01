USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[GetAllEmployeesPaging]
	@currentPage INT,
	@pageSize INT
AS
BEGIN	
	DECLARE @starIndex INT, @rowsToFetch INT;
	SET @starIndex = (@currentPage - 1) * @pageSize
	SET @rowsToFetch = @pageSize;
	SELECT * FROM dbo.Employees
	WHERE status = 1
	ORDER BY id DESC
	OFFSET @starIndex * @rowsToFetch ROWS
	FETCH NEXT @rowsToFetch ROWS ONLY
END
GO

EXEC dbo.GetAllEmployeesPaging @currentPage = 1, @pageSize = 10
EXEC dbo.GetAllEmployeesPaging @currentPage = 2, @pageSize = 10
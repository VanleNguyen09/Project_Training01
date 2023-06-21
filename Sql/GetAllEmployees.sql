USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[GetAllEmployees]
	@curentPage INT,
	@pageSize INT
AS
BEGIN	
	DECLARE @starIndex INT, @rowsToFetch INT;
	SET @starIndex = (@curentPage - 1) * @pageSize 
	SET @rowsToFetch = @pageSize;
	SELECT * FROM dbo.Employees
	WHERE status = 1
	ORDER BY id	DESC
	OFFSET @starIndex ROWS
	FETCH NEXT @rowsToFetch ROWS ONLY
END
GO

EXEC dbo.GetAllEmployees @curentPage = 2, @pageSize = 10
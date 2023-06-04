USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[CountTotalEmployees]
AS
BEGIN
	SELECT COUNT(*) AS SL_NV FROM dbo.Employees
	WHERE status = 1
END
GO

EXEC dbo.CountTotalEmployees
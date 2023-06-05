USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[CountTotalManagers]
AS
BEGIN
	SELECT COUNT(*) AS SL_MG FROM dbo.Dept_manager
	WHERE status = 1
END
GO

EXEC dbo.CountTotalManagers
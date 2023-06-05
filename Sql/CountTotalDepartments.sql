USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[CountTotalDepartments]
AS
BEGIN
	SELECT COUNT(*) AS SL_DP FROM dbo.Department
	WHERE status = 1
END
GO

EXEC dbo.CountTotalDepartments

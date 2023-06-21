USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[GetInfoManagement]
AS
BEGIN
	DECLARE @Department INT = (	SELECT COUNT(*) FROM dbo.Department WHERE status = 1)

	DECLARE @Employee INT = (SELECT COUNT(*) FROM dbo.Employees WHERE status = 1)

	SELECT @Department AS SL_DP , @Employee AS SL_NV
END
GO
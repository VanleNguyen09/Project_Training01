USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[CountTotalPositions]
AS
BEGIN
	SELECT COUNT(*) AS SL_PS FROM dbo.Position
	WHERE status = 1
END
GO

EXEC dbo.CountTotalPositions
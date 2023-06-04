USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[CountTotalLeaves]
AS
BEGIN
	SELECT COUNT(*) AS SL_Leaves FROM dbo.leave
	WHERE status = 1
END
GO

EXEC dbo.CountTotalLeaves
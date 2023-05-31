SET ANSI_NULLS ON
GO
USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[GetAllDepartments]
AS
BEGIN
	SELECT * FROM dbo.Department
	WHERE status = 1
END
GO

SELECT * FROM dbo.Department
WHERE status = 0

GO	
EXEC [GetAllDepartments]
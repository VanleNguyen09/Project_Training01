
USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[GetAllEmployees]
AS
BEGIN
	SELECT * FROM dbo.Employees
	WHERE status = 1
	ORDER BY id
END
GO
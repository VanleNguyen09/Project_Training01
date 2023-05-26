USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[CheckManagerExit]
	-- Add the parameters for the stored procedure here
	@name NVARCHAR(255)
AS
BEGIN
	DECLARE @dept_exit INT
	IF EXISTS (SELECT 1 FROM dbo.Department WHERE name = @name)
		SET @dept_exit = 1
	ELSE
		SET @dept_exit = 0
END
	SELECT	'ReturnValue' = @dept_exit
GO
USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[CheckDepartmentExitForUpdate]
	-- Add the parameters for the stored procedure here
	@name NVARCHAR(255),
	@id INT
AS
BEGIN
	DECLARE @dept_exit INT
	IF EXISTS (SELECT 1 FROM dbo.Department WHERE name = @name AND id <> @id)
		SET @dept_exit = 1
	ELSE
		SET @dept_exit = 0
END
	SELECT	'ReturnValue' = @dept_exit
GO
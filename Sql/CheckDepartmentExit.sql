USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[CheckDepartmentExit]
	-- Add the parameters for the stored procedure here
	@name NVARCHAR(255)
AS
BEGIN
	DECLARE @dept_exit INT

	IF EXISTS (
	   SELECT 1 FROM dbo.Department WHERE name = @name 
	   AND status = 1
	)
		SET @dept_exit = 1
	ELSE
		SET @dept_exit = 0
	SELECT	@dept_exit AS ReturnValue
END
GO
USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[CheckEmployeeExit]
	-- Add the parameters for the stored procedure here
	@name NVARCHAR(255),
	@phone VARCHAR(20)
AS
BEGIN
	DECLARE @employee_exit INT
	IF EXISTS (SELECT 1 FROM dbo.Employees WHERE (name = @name OR phone = @phone) AND status = 1)
		SET @employee_exit = 1
	ELSE
		SET @employee_exit = 0
	SELECT	@employee_exit AS ReturnValue
END
GO
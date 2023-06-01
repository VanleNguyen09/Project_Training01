USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[CheckEmployeeExitForUpdate]
	-- Add the parameters for the stored procedure here
	@phone VARCHAR(20),
	@id INT
AS
BEGIN
	DECLARE @employee_exit INT
	IF EXISTS (SELECT 1 FROM dbo.Employees WHERE phone = @phone AND id <> @id)
		SET @employee_exit = 1
	ELSE
		SET @employee_exit = 0
	SELECT @employee_exit AS ReturnValue
END
GO
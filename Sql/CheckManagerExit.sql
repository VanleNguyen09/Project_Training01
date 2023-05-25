USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[CheckManagerExit]
	-- Add the parameters for the stored procedure here
	@emp_id INT, @dept_id INT 
AS
BEGIN
	DECLARE @employee_exit INT
	IF EXISTS (SELECT 1 FROM dbo.Dept_manager WHERE emp_id = @emp_id AND dept_id = @dept_id)
		SET @employee_exit = 1
	ELSE
		SET @employee_exit = 0
END
	SELECT	'ReturnValue' = @employee_exit
GO

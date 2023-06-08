USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[CheckManagerDateBigger]
	-- Add the parameters for the stored procedure here
	@emp_id INT,
	@dept_id INT,
	@from_date DATE,
	@to_date DATE
AS
BEGIN
	DECLARE @isBigger INT
	IF EXISTS (SELECT 1 FROM dbo.Dept_manager WHERE	
	emp_id = @emp_id AND dept_id = @dept_id AND (from_date > @from_date 
	OR to_date > @to_date) AND status = 1)
		SET @isBigger = 0
	SELECT	@isBigger AS ReturnValue
END
GO

USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[CheckManagerExit]
    @emp_id INT,
    @dept_id INT
AS
BEGIN
	DECLARE @isDupplicate INT
    IF EXISTS (SELECT 1 FROM dbo.Dept_manager 
	WHERE emp_id = @emp_id AND dept_id = @dept_id 
	AND status = 1)
        SET @isDupplicate = 1
    ELSE
        SET @isDupplicate = 0
	SELECT	@isDupplicate AS ReturnValue
END
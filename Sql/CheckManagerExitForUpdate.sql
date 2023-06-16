USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[CheckManagerExitForUpdate]
    @dept_id INT,
	@emp_id INT,
	@id INT
AS
BEGIN
	DECLARE @isDuplicate INT
     IF EXISTS (SELECT 1 FROM dbo.Dept_manager 
	WHERE (emp_id = @emp_id AND dept_id = @dept_id AND id <> @id) 
	AND status = 1)
        SET @isDuplicate = 1
    ELSE
        SET @isDuplicate = 0
	SELECT @isDuplicate AS ReturnValue
END
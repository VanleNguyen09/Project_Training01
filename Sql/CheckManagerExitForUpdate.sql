USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[CheckManagerExitForUpdate]
    @dept_id INT,
    @employee_exit INT OUTPUT
AS
BEGIN
    IF EXISTS (SELECT 1 FROM dbo.Dept_manager WHERE dept_id = @dept_id AND status = 1)
        SET @employee_exit = 1
    ELSE
        SET @employee_exit = 0
END
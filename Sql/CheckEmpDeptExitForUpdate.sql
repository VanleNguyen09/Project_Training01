USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE OR ALTER PROCEDURE [dbo].[CheckEmpDeptExitForUpdate]
    @dept_id INT,
	@emp_id INT,
	@from_date DATE,
	@to_date DATE
AS
BEGIN
	DECLARE @isDuplicate INT
    IF EXISTS (SELECT 1 FROM dbo.Dept_emp 
	WHERE emp_id = @emp_id AND dept_id = @dept_id AND	
	from_date = @from_date AND to_date = @to_date AND status = 1)
        SET @isDuplicate = 1
    ELSE
        SET @isDuplicate = 0
	SELECT @isDuplicate AS ReturnValue
END
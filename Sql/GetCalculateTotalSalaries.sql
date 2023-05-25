
USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[GetCalculateTotalSalaries]
    @TotalSalary DECIMAL(18, 2) OUTPUT
AS
BEGIN
	SELECT @TotalSalary = SUM(salary)
	FROM dbo.Salaries
END
GO
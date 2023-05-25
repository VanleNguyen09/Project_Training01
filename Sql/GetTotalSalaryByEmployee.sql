USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[GetTotalSalaryByEmployee]
AS
BEGIN
	SELECT emp_id, SUM(salary) AS total_salary 
	FROM dbo.Salaries
	GROUP BY emp_id
END
GO

USE [EmployeeManagement]
GO
/****** Object:  StoredProcedure [dbo].[GetEmployeesByName]    Script Date: 17/05/2023 17:19:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[GetTotalSalaryByEmployee]
AS
BEGIN
	SELECT emp_id, SUM(salary) AS total_salary 
	FROM dbo.Salaries
	GROUP BY emp_id
END
GO	

EXEC dbo.GetTotalSalaryByEmployee

Debbugging
ENABLE BREAK points
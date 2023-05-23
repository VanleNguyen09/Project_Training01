USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[InsertDeptEmp]
	@emp_id INT,
	@dept_id INT,
    @from_date DATETIME,
	@to_date DATETIME
AS
BEGIN
	INSERT INTO dbo.Dept_emp
	(
	    emp_id,
	    dept_id,
	    from_date,
	    to_date
	)
    VALUES(@emp_id, @dept_id, @from_date, @to_date)
END

SELECT * FROM dbo.Dept_emp
ORDER BY dept_id
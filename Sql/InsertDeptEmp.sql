USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[InsertDeptEmp]
	-- Add the parameters for the stored procedure here
	@emp_id INT,
    @dept_id INT,
	@from_date DATETIME,
	@to_date DATETIME,
	@status INT
AS
BEGIN

	IF EXISTS (SELECT 1 FROM dbo.Dept_emp WHERE emp_id = @emp_id AND dept_id = @dept_id AND status = 0)
	BEGIN
		UPDATE dbo.Dept_emp SET status = 1, 
		from_date = @from_date, to_date = @to_date
		WHERE emp_id = @emp_id AND dept_id = @dept_id AND status = 0;
	END
	ELSE
	BEGIN
	    INSERT INTO dbo.Dept_emp
	    (
	        emp_id,
	        dept_id,
	        from_date,
	        to_date,
	        status
	    )
		VALUES(@emp_id, @dept_id, @from_date, @to_date, @status);
	END
END
GO
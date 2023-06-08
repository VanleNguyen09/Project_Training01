﻿USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[UpdateDeptEmp]
	-- Add the parameters for the stored procedure here
	@emp_id INT,
    @dept_id INT,
	@from_date DATE,
	@to_date DATE,
	@deptemp_id INT,
	@status INT
AS
BEGIN	
	UPDATE dbo.Dept_emp
	SET status = 0
	WHERE id = @deptemp_id

	UPDATE dbo.Dept_emp
	SET status = 1, emp_id = @emp_id, dept_id = @dept_id, 
	from_date = @from_date, to_date = @to_date
	WHERE emp_id = @emp_id AND dept_id = @dept_id

	IF @@ROWCOUNT = 0
	BEGIN	
	INSERT INTO dbo.Dept_emp
	(
		emp_id,
		dept_id,
		from_date,
		to_date,
		status
	)
	VALUES
	(   
		@emp_id, @dept_id, @from_date, @to_date, @status
	)
	END
END
GO	

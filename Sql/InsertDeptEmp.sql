USE [EmployeeManagement]
GO
/****** Object:  StoredProcedure [dbo].[InsertEmployees]    Script Date: 19/05/23 11:34:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

ALTER PROCEDURE [dbo].[InsertDeptEmp]
	-- Add the parameters for the stored procedure here
	@emp_id INT,
	@dept_id INT,
    @from_date DATETIME,
	@to_date DATETIME
AS
BEGIN

	--DECLARE @currDate DATETIME;
	--SET @currDate = GETDATE()
	INSERT INTO dbo.Dept_emp
	(
	    emp_id,
	    dept_id,
	    from_date,
	    to_date
	)
    VALUES(@emp_id, @dept_id, @from_date, @to_date)
END

EXEC dbo.InsertDeptEmp @emp_id = 25,                      
                       @dept_id = 1,                     
                       @from_date = '2023-05-19 06:51:51', 
                       @to_date = '2023-05-19 06:51:51'    
GO

SELECT * FROM dbo.Dept_emp
ORDER BY dept_id
USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[InsertDeptManager]
	-- Add the parameters for the stored procedure here
	@emp_id INT,
    @dept_id INT,
	@from_date DATETIME,
	@to_date DATETIME
AS
BEGIN
	SET NOCOUNT ON;

	INSERT INTO dbo.Dept_manager
	(
	    emp_id,
	    dept_id,
	    from_date,
	    to_date
	)
	VALUES(@emp_id, @dept_id, @from_date, @to_date)
END
GO
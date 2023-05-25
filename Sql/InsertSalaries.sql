USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[InsertSalaries]
	-- Add the parameters for the stored procedure here
	@emp_id INT,
    @salary FLOAT,
	@from_date DATETIME,
	@to_date DATETIME
AS
BEGIN
	INSERT INTO dbo.Salaries(emp_id, salary, from_date, to_date)
	VALUES(@emp_id, @salary, @from_date, @to_date)
END
GO
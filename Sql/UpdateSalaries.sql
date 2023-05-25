SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

USE EmployeeManagement
GO	

CREATE OR ALTER PROCEDURE UpdateSalaries
	-- Add the parameters for the stored procedure here
	@id INT,
    @emp_id INT,
	@salary FLOAT,
	@from_date DATETIME,
	@to_date DATETIME
AS
BEGIN
	UPDATE dbo.Salaries
	SET emp_id = @emp_id,
		salary = @salary,
		from_date = @from_date,
		to_date = @to_date
	WHERE id = @id
END
GO

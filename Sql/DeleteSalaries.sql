SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
USE EmployeeManagement
GO	

CREATE OR ALTER PROCEDURE DeleteSalaries
	-- Add the parameters for the stored procedure here
	@id INT
AS
BEGIN
	UPDATE dbo.Salaries
	SET status = 0
	WHERE id = @id
END
GO
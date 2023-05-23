SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

USE EmployeeManagement
GO	

CREATE PROCEDURE DeleteSalaries
	-- Add the parameters for the stored procedure here
	@id INT
AS
BEGIN
	DELETE FROM dbo.Salaries
	WHERE id = @id
END
GO

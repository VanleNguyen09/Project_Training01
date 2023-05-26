SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
USE EmployeeManagement
GO	
CREATE OR ALTER PROCEDURE UpdateManager
	-- Add the parameters for the stored procedure here
	@emp_id INT,
	@dept_id INT,
	@from_date DATE,
	@to_date DATE
AS
BEGIN
	UPDATE dbo.Dept_manager
	SET emp_id = @emp_id
	WHERE emp_id = @id
END
GO
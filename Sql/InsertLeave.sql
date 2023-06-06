USE EmployeeManagement
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Dat
-- Create date: 24/5/2023
-- Update date: 5/6/2023
-- Description:	Insert Leave By Id
-- =============================================

CREATE OR ALTER PROCEDURE InsertLeave 
	-- Add the parameters for the stored procedure here
	@emp_id INT,
	@emp_name NVARCHAR(255),
	@from_date DATETIME,
	@reason NVARCHAR(255)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	IF EXISTS (SELECT 1 FROM dbo.leave WHERE emp_id = @emp_id AND from_date = @from_date AND status = 1)
	BEGIN
		THROW 50001, 'This leave data is existed!', 1
	END

	IF EXISTS (SELECT 1 FROM dbo.leave WHERE emp_id = @emp_id AND from_date = @from_date AND status = 0)
	BEGIN
		DELETE FROM leave
		WHERE id = (SELECT id FROM dbo.leave WHERE emp_id = @emp_id AND from_date = @from_date AND status = 0)
	END

	INSERT INTO leave(emp_id, emp_name, from_date, reason, status, is_confirmed)
	VALUES (@emp_id, @emp_name, @from_date, @reason, 1, 0)
END
GO

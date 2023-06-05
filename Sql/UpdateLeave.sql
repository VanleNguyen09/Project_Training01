USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Dat
-- Create date: 24/5/2023
-- Update date: 5/6/2023
-- Description:	Update Leave
-- =============================================

CREATE OR ALTER PROCEDURE [dbo].[UpdateLeave]
	-- Add the parameters for the stored procedure here
	@id INT,
	@emp_id INT,
	@emp_name NVARCHAR(255),
  	@from_date DATETIME,
	@reason NVARCHAR(255)
AS
BEGIN
	IF EXISTS (SELECT 1 FROM dbo.leave WHERE emp_id = @emp_id AND from_date = @from_date AND reason = @reason AND status = 1)
	BEGIN
		THROW 50001, 'This leave data is existed!', 1
	END
	
	IF EXISTS (SELECT 1 FROM dbo.leave WHERE emp_id = @emp_id AND from_date = @from_date AND status = 0)
	BEGIN
		DELETE FROM leave
		WHERE id = (SELECT id FROM dbo.leave WHERE emp_id = @emp_id AND from_date = @from_date AND status = 0)
	END

	UPDATE leave
	SET status = 1, reason = @reason, emp_id = @emp_id, from_date = @from_date, emp_name = @emp_name
	WHERE id = @id
END
GO

--EXEC dbo.GetAllDepartments

--SELECT * FROM dbo.Department WHERE status = 1 AND name = 'Comtor'
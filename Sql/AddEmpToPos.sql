USE EmployeeManagement
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Dat
-- Create date: 19/5/2023
-- Update date: 26/5/2023
-- Description:	Add Employee to Position
-- =============================================
CREATE OR ALTER PROCEDURE AddEmpToPos
@emp_id INT,
@pos_id INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @currDate DATETIME;
	SET @currDate = GETDATE();

    -- Insert statements for procedure here
	IF EXISTS (SELECT * FROM Emp_Pos WHERE emp_id = @emp_id AND pos_id = @pos_id AND status = 1)
	BEGIN
		THROW 50001, 'This Position for this Employee is Existed!', 1
	END

	IF EXISTS (SELECT * FROM Emp_Pos WHERE emp_id = @emp_id AND pos_id = @pos_id AND status = 0)
	BEGIN
		UPDATE Emp_Pos
		SET status = 1
		WHERE emp_id = @emp_id AND pos_id = @pos_id
	END
	ELSE
	BEGIN
		INSERT INTO Emp_Pos(emp_id, pos_id, from_date, status)
		VALUES (@emp_id, @pos_id, @currDate, 1)
	END
END
GO
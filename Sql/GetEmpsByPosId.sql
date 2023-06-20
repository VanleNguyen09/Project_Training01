-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Dat
-- Create date: 19/5/2023
-- Update date: 26/5/2023
-- Description:	Get all Employees By Position Id
-- =============================================
CREATE OR ALTER PROCEDURE GetEmpsByPosId
	@pos_id INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	IF @pos_id < 0
	BEGIN
		SELECT ROW_NUMBER() OVER (ORDER BY e.id) as stt, e.id, e.name, e.phone, e.email, CONVERT(date, e.birthday) AS birthday, p.name as pos_name, p.id as pos_id FROM Employees e
		INNER JOIN Emp_Pos ep ON e.id = ep.emp_id
		INNER JOIN Position p ON p.id = ep.pos_id
		WHERE ep.status = 1
	END
	ELSE
	BEGIN
		-- Insert statements for procedure here
		SELECT ROW_NUMBER() OVER (ORDER BY e.id) as stt, e.id, e.name, e.phone, e.email, CONVERT(date, e.birthday) AS birthday, p.name as pos_name, p.id as pos_id FROM Employees e
		INNER JOIN Emp_Pos ep ON e.id = ep.emp_id
		INNER JOIN Position p ON p.id = ep.pos_id
		WHERE ep.pos_id = @pos_id AND ep.status = 1
	END
END
GO

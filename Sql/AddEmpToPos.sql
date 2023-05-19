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
-- Description:	Add Employee to Position
-- =============================================
CREATE PROCEDURE AddEmpToPos
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
	INSERT INTO Emp_Pos(emp_id, pos_id, from_date)
	VALUES (@emp_id, @pos_id, @currDate)
END
GO
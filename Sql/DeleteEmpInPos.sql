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
-- Description:	Delete An Employee in Selected Position
-- =============================================
CREATE OR ALTER PROCEDURE DeleteEmpInPos
@emp_id INT,
@pos_id INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Emp_Pos
	SET status = 0
	WHERE emp_id = @emp_id AND pos_id = @pos_id
END
GO
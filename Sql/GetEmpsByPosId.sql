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
-- Description:	Get all Employees By Position Id
-- =============================================
CREATE PROCEDURE GetEmpsByPosId
	@pos_id INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT e.* FROM Employees e
	INNER JOIN Emp_Pos ep
	ON e.id = ep.emp_id
	WHERE ep.pos_id = @pos_id
END
GO

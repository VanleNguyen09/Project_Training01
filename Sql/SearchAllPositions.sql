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
-- Create date: 22/5/2023
-- Update date: 26/5/2023
-- Description:	Search all Positions
-- =============================================
CREATE OR ALTER PROCEDURE SearchAllPositions
@text nvarchar(255)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT ROW_NUMBER() OVER (ORDER BY p.id) as stt, COUNT(p.id) as emp_num, p.id, p.name FROM Position p
	RIGHT JOIN Emp_Pos ep ON p.id = ep.pos_id
	WHERE p.status = 1 AND ep.status = 1
	GROUP BY p.id, p.name
	HAVING CAST(COUNT(p.id) AS nvarchar(255)) = @text OR p.name LIKE '%'+ @text +'%'
END
GO

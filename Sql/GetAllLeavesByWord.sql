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
-- Create date: 24/5/2023
-- Update date: 5/6/2023
-- Description:	Get All Leaves By Word
-- =============================================
CREATE OR ALTER PROCEDURE GetAllLeavesByWord
@word NVARCHAR(255)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT ROW_NUMBER() OVER (ORDER BY id) as stt, * FROM leave l
	WHERE status = 1 AND (l.emp_name like '%' + @word + '%' OR l.emp_id like '%' + @word + '%' OR l.reason like '%' + @word + '%')
END
GO
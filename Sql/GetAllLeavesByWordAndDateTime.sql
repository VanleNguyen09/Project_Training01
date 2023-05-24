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
-- Description:	Get Leaves By Word And Date Time
-- =============================================
CREATE OR ALTER PROCEDURE GetAllLeavesByWordAndDateTime
@word NVARCHAR(255),
@s_datetime DATETIME,
@e_datetime DATETIME
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT * FROM leave l
	WHERE (l.emp_name like '%' + @word + '%' OR l.emp_id like '%' + @word + '%' OR l.id like '%' + @word + '%')
	AND l.from_date >= CONVERT(datetime, @s_datetime) AND l.from_date <= CONVERT(datetime, @e_datetime)
END
GO

-- exec GetAllLeavesByWordAndDateTime 'Ha', @s_datetime = '2023-05-13 00:00:00', @e_datetime = '2023-05-19 00:00:00'
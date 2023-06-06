USE EmployeeManagement
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Dat
-- Create date: 22/5/2023
-- Update date: 5/6/2023
-- Description:	Get all leaves list by words
-- =============================================

CREATE OR ALTER PROCEDURE GetAllLeavesByWordAndDateTime
@word NVARCHAR(255),
@s_datetime DATETIME,
@e_datetime DATETIME
AS
BEGIN
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT ROW_NUMBER() OVER (ORDER BY id) as stt, * FROM leave l
	WHERE (l.emp_name like '%' + @word + '%' OR l.emp_id like '%' + @word + '%' OR l.reason like '%' + @word + '%')
	AND l.from_date >= CONVERT(datetime, @s_datetime) AND l.from_date <= CONVERT(datetime, @e_datetime) AND l.status = 1
END
GO

-- exec GetAllLeavesByWordAndDateTime 'Ha', @s_datetime = '2023-05-13 00:00:00', @e_datetime = '2023-05-19 00:00:00'
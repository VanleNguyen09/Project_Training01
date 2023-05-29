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
-- Create date: 29/5/2023
-- Description:	Get all salaries list by words
-- =============================================
CREATE OR ALTER PROCEDURE GetAllSalariesByWords
@words nvarchar(255)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	SELECT ROW_NUMBER() OVER (ORDER BY id) as stt, id as salary_id, salary_name, salary FROM SalaryEmp
	WHERE status = 1 
	AND salary_name LIKE '%' + @words + '%'
	OR salary LIKE '%' + @words + '%'
END
GO
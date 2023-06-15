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
USE EmployeeManagement
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Dat
-- Create date: 29/5/2023
-- Update date: 14/6/2023
-- Description:	Get all employees by words
-- =============================================
CREATE OR ALTER PROCEDURE GetAllEmployeesByWords
@words nvarchar(255)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	SELECT ROW_NUMBER() OVER (ORDER BY id) as stt, * FROM Employees
	WHERE status = 1 
	AND (name LIKE '%' + @words + '%' 
	OR id LIKE '%' + @words + '%' 
	OR phone LIKE '%' + @words + '%'
	OR address LIKE '%' + @words + '%')
END
GO
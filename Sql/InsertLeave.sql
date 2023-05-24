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
-- Description:	Insert Leave
-- =============================================
CREATE OR ALTER PROCEDURE InsertLeave 
	-- Add the parameters for the stored procedure here
@emp_id INT,
@from_date DATETIME,
@reason NVARCHAR(255)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @emp_name NVARCHAR(255) = (SELECT TOP(1) e.name FROM Employees e WHERE e.id = @emp_id)

    -- Insert statements for procedure here
	INSERT INTO leave(emp_id, emp_name, from_date, reason)
	VALUES (@emp_id, @emp_name, @from_date, @reason)
END
GO

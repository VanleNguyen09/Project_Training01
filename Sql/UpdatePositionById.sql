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
-- Create date: 23/5/2023
-- Update date: 29/5/2023
-- Description:	Update Position By Id
-- =============================================
CREATE OR ALTER PROCEDURE UpdatePositionById
@pos_id INT,
@name NVARCHAR(255)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF EXISTS (SELECT * FROM Position WHERE name = @name AND status = 1)
	BEGIN
		THROW 50000, 'Exist this name!', 1;
	END

	IF EXISTS (SELECT * FROM Position WHERE name = @name AND status = 0)
	BEGIN
		DELETE FROM Position
		WHERE name = @name AND status = 0
	END

	UPDATE Position
	SET name = @name
	WHERE id = @pos_id
END
GO
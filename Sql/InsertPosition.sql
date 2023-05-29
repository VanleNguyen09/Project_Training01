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
-- Update date: 29/5/2023
-- Description:	Add position
-- =============================================
CREATE OR ALTER PROCEDURE InsertPosition
@name nvarchar(255)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF EXISTS (SELECT * FROM Position WHERE name = @name AND status = 1)
	BEGIN
		THROW 50005, N'Exist This Name', 1;
	END

	IF NOT EXISTS (SELECT * FROM Position WHERE name = @name AND status = 0)
	BEGIN
		INSERT INTO Position(name, status) VALUES (@name, 1)
		RETURN 0
	END
	ELSE
	BEGIN
	DECLARE @pos_id INT = (SELECT TOP 1 id FROM Position WHERE name = @name AND status = 0 ORDER BY id)
		UPDATE Position
		SET status = 1
		WHERE id = @pos_id

		UPDATE Emp_Pos
		SET status = 1
		WHERE pos_id = @pos_id
	END
END
GO

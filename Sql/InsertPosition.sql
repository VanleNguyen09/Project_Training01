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
	IF NOT EXISTS (SELECT * FROM Position WHERE name = @name AND status = 1)
	BEGIN
		IF NOT EXISTS (SELECT * FROM Position WHERE name = @name AND status = 0)
		BEGIN
			INSERT INTO Position(name, status) VALUES (@name, 1)
		END
		ELSE
		BEGIN
			UPDATE Position
			SET status = 1
			WHERE name = @name
		END
	END
	ELSE
	BEGIN
		THROW 50005, N'Exist This Name', 1;
	END
END
GO

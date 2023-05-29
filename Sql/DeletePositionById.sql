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
CREATE OR ALTER PROCEDURE DeletePositionById
@pos_id INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE Emp_Pos
	SET status = 0
	WHERE pos_id = @pos_id

	UPDATE Position
	SET status = 0
	WHERE id = @pos_id
END
GO

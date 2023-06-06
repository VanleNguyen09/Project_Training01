USE EmployeeManagement
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

-- =============================================
-- Author:		Dat
-- Create date: 24/5/2023
-- Update date: 5/6/2023
-- Description:	Soft Delete Leave by Id 
-- =============================================

CREATE OR ALTER PROCEDURE DeleteLeaveById
	@leave_id INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	UPDATE dbo.leave
	SET status = 0
	WHERE id = @leave_id
END
GO
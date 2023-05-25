USE [EmployeeManagement]
GO
/****** Object:  StoredProcedure [dbo].[DeleteManager]    Script Date: 24/05/23 06:25:51 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[DeleteManager]
	@emp_id INT,
	@dept_id INT
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM Dept_manager
	WHERE Dept_manager.emp_id = @emp_id AND dept_id = @dept_id
END
GO

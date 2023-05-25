SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE DeleteManagerInDepartment
	@emp_id INT,
	@dept_id INT
AS
BEGIN
	SET NOCOUNT ON;
	DELETE FROM Dept_manager
	WHERE emp_id = @emp_id AND dept_id = @dept_id
END
GO
USE [EmployeeManagement]
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE GetManagerByDeptId
	@dept_id INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;
    -- Insert statements for procedure here
	SELECT a.*, c.name AS department_name, 
	b.from_date AS from_date, b.to_date AS to_date  
	FROM Employees a
	INNER JOIN dbo.Dept_manager b
	ON a.id = b.emp_id
	INNER JOIN dbo.Department c
	ON c.id = b.dept_id
	WHERE b.dept_id = @dept_id
END
GO
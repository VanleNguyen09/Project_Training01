USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[GetEmployeeByDepartment]
	@dept_id INT
AS

BEGIN
	SET NOCOUNT ON;
    -- Insert statements for procedure here
	SELECT a.*, c.name AS department_name, b.id AS deptemp_id, b.dept_id AS dept_id,
	b.from_date AS from_date, b.to_date AS to_date  
	FROM Employees a
	INNER JOIN dbo.Dept_emp b
	ON a.id = b.emp_id
	INNER JOIN dbo.Department c
	ON c.id = b.dept_id
	WHERE b.dept_id = @dept_id AND b.status = 1
	ORDER BY b.id
END
GO


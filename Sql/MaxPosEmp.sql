USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[MaxPosEmp]
AS
BEGIN
	SELECT TOP 1 c.name AS position_name, COUNT(b.pos_id) AS employee_count
	FROM dbo.Employees a
	JOIN dbo.Emp_Pos b 
	ON a.id = b.emp_id
	JOIN dbo.Position c
	ON c.id = b.pos_id
	WHERE b.status = 1
	GROUP BY c.id, c.name
	ORDER BY COUNT(b.pos_id) DESC
END
GO	
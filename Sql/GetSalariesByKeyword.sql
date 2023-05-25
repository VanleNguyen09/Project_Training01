USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[GetSalariesByKeyWord]
	@keyword NVARCHAR(255)
AS
BEGIN
	SELECT * FROM dbo.Salaries
	WHERE id LIKE '%' + @keyword + '%' OR 
	emp_id LIKE '%' + @keyword + '%' OR salary LIKE '%' + @keyword + '%'
	OR from_date LIKE '%' + @keyword + '%' OR to_date 
	LIKE '%' + @keyword + '%'
END
GO
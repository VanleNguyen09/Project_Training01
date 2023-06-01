USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[GetDepartmentsByKeyWord]
	@keyword NVARCHAR(255)
AS
BEGIN
	SELECT * FROM dbo.Department
	WHERE id LIKE @keyword OR name  LIKE '%' + @keyword  + '%' AND status = 1
	ORDER BY id
END
GO
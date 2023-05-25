
USE [EmployeeManagement]
GO
/****** Object:  StoredProcedure [dbo].[GetEmployeesByName]    Script Date: 17/05/2023 17:19:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[GetDepartmentsByKeyWord]
	@keyword NVARCHAR(255)
AS
BEGIN
	SELECT * FROM dbo.Department
	WHERE id LIKE @keyword OR name  LIKE '%' + @keyword  + '%'	
END
GO
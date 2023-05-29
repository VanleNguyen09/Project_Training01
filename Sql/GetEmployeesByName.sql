
USE [EmployeeManagement]
GO
/****** Object:  StoredProcedure [dbo].[GetEmployeesByName]    Script Date: 17/05/2023 17:19:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[GetEmployeesByKeyword]
	@name NVARCHAR(255),
	@address NVARCHAR(255)
AS
BEGIN
	SELECT * FROM dbo.Employees
	WHERE name LIKE '%' + @name + '%' OR address LIKE '%' + @address + '%'
END


EXEC GetEmployeesByName @name = N'%Thoảng%' 

EXEC dbo.GetAllEmployees




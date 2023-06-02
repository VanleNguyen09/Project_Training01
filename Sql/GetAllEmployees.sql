
USE [EmployeeManagement]
GO
/****** Object:  StoredProcedure [dbo].[GetAllEmployees]    Script Date: 17/05/2023 17:19:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[GetAllEmployees]
AS
BEGIN
	SELECT * FROM dbo.Employees
	WHERE status = 1
	ORDER BY id
END
GO
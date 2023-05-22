
SET ANSI_NULLS ON
GO
USE [EmployeeManagement]
GO
/****** Object:  StoredProcedure [dbo].[InsertEmployees]    Script Date: 19/05/23 11:34:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[GetAllDepartments]
AS
BEGIN
	SELECT * FROM dbo.Department
END

EXEC dbo.GetAllDepartments 


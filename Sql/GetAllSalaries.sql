USE [EmployeeManagement]
GO
/****** Object:  StoredProcedure [dbo].[GetAllEmployees]    Script Date: 23/05/23 09:47:56 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetAllSalaries]
AS
BEGIN
	SELECT * FROM dbo.Salaries
END
GO

--EXEC dbo.GetAllSalaries
USE [EmployeeManagement]
GO
/****** Object:  StoredProcedure [dbo].[GetAllProvinces]    Script Date: 17/05/2023 17:19:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[GetAllProvinces]
AS
BEGIN
	SELECT * FROM provinces
END

SELECT * from provinces
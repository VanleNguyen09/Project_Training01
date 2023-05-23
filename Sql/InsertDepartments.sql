USE [EmployeeManagement]
GO
/****** Object:  StoredProcedure [dbo].[InsertEmployees]    Script Date: 19/05/23 11:34:19 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[InsertDepartments]
	-- Add the parameters for the stored procedure here
    @name NVARCHAR(255)
AS
BEGIN
	INSERT INTO dbo.Department(name)
    VALUES(@name)
END
GO	

--EXEC dbo.InsertDepartments @name = N'BrSE'

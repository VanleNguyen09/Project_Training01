USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[InsertDepartments]
	-- Add the parameters for the stored procedure here
    @name NVARCHAR(255)
AS
BEGIN
	INSERT INTO dbo.Department(name)
    VALUES(@name)
END
GO
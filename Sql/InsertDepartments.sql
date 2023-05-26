USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[InsertDepartments]
	-- Add the parameters for the stored procedure here
    @name NVARCHAR(255)
	@status INT		
AS
BEGIN
	INSERT INTO dbo.Department(name)
    VALUES(@name, @status)
END
GO
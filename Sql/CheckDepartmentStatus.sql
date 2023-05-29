USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[CheckDepartmentStatus]
    -- Add the parameters for the stored procedure here
    @name NVARCHAR(255),
    @status INT OUTPUT
AS
BEGIN
	SELECT @status = status
	FROM dbo.Department
	WHERE name = @name
END
GO	
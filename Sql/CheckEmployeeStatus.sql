USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[CheckEmployeeStatus]
    -- Add the parameters for the stored procedure here
    @phone NVARCHAR(255),
    @status INT OUTPUT
AS
BEGIN
	SELECT @status = status
	FROM dbo.Employees
	WHERE phone = @phone
END
GO	
USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[UpdateEmployeeStatus]
    -- Add the parameters for the stored procedure here
    @phone NVARCHAR(255)
AS
BEGIN
    -- Update the status of the duplicate department with status = 0
	UPDATE TOP(1) dbo.Employees
	SET status = 1
	WHERE phone = @phone AND status = 0
END
GO	
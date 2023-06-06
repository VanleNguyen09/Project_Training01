USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[UpdateUserIsLoggedIn]
	-- Add the parameters for the stored procedure here
	@email VARCHAR(255),
	@isLoggedIn BIT
AS
BEGIN
	UPDATE dbo.users
	SET isLoggedIn = @isLoggedIn
	WHERE email = @email
END
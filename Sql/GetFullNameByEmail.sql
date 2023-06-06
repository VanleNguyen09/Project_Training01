USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[GetFullNameByEmail]
	@email VARCHAR(255)
AS

BEGIN
	SET NOCOUNT ON;
    -- Insert statements for procedure here
	SELECT full_name AS fullName
	FROM dbo.users
	WHERE email = @email
END
GO

EXEC dbo.GetFullNameByEmail @email = 'thoangrikai@gmail.com'

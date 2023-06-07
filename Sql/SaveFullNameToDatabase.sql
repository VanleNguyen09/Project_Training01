USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[SaveFullNameToDatabase]
	@email VARCHAR(255),
	@fullName NVARCHAR(255)
AS

BEGIN
    UPDATE dbo.users SET full_name = @fullName WHERE email = @email
END
GO

--EXEC dbo.SaveFullNameToDatabase @email = 'thoangrikai@gmail.com',    -- varchar(255)
--                                @fullName = N'thoangRikai' -- nvarchar(255)




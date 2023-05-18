-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Dat
-- Create date: 18/5/2023
-- Description:	Add New user
-- =============================================
CREATE PROCEDURE AddUser 
	@email varchar(255),
	@full_name nvarchar(255),
	@password varchar(255)
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
	SET NOCOUNT ON;

    INSERT INTO Users
	(full_name, email, password)
    VALUES(@full_name, @email, @password)

    SELECT SCOPE_IDENTITY() AS [User Id]
END
GO

Exec AddUser '', '', ''

SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE UpdateEmployees
	-- Add the parameters for the stored procedure here
	@id INT,
    @name nvarchar(255),
    @phone VARCHAR(20),
    @address NVARCHAR(255),
	@gender bit,
    @birthday datetime,
    @email varchar(255)
AS
BEGIN
	UPDATE Employees
	SET name = @name,
		phone = @phone,
		address = @address,
		gender = @gender,
		birthday = @birthday,
		email = @email
	WHERE id = @id
END
GO


CREATE PROCEDURE UpdateEmployees1
	-- Add the parameters for the stored procedure here
	@id INT,
    @name nvarchar(255),
    @phone VARCHAR(20),
	@birthday DATETIME
AS
BEGIN
	UPDATE Employees
	SET name = @name,
		phone = @phone,
		birthday = @birthday
	WHERE id = @id
END
GO

DROP PROCEDURE dbo.UpdateEmployees1
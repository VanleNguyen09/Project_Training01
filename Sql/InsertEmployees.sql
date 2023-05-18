
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE InsertEmployees
	-- Add the parameters for the stored procedure here
	@id INT,
    @name nvarchar(255),
    @phone VARCHAR(20),
    @address NVARCHAR(255),
	@gender bit,
    @birthday datetime,
    @email VARCHAR(255)
AS
BEGIN
	INSERT INTO Employees
	(
	    name,
	    phone,
	    address,
	    gender,
	    birthday,
	    email
	)
    VALUES
         (@name, @phone, @address, @gender, @birthday, @email)

	    -- Set the output parameter with the inserted ID
    SET @id = SCOPE_IDENTITY()
END
GO

--ALTER PROCEDURE InsertEmployees
--	-- Add the parameters for the stored procedure here
--	@id INT,
--    @name NVARCHAR(255),
--    @phone VARCHAR(20),
--    @address NVARCHAR(255),
--	@gender BIT,
--    @birthday DATETIME,
--    @email VARCHAR(255),
--	@pass VARCHAR(255)
--AS
--BEGIN
--	INSERT INTO Employees
--	(
--	    name,
--	    phone,
--	    address,
--	    gender,
--	    birthday,
--	    email,
--	    pass
--	)
--    VALUES
--         (@name, @phone, @address, @gender, @birthday, @email, @pass)

--	    -- Set the output parameter with the inserted ID
--    SET @id = SCOPE_IDENTITY()
--END
--GO


DROP PROCEDURE dbo.InsertEmployees;


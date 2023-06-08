USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[UpdateDepartments]
	-- Add the parameters for the stored procedure here
	@id INT,
    @name NVARCHAR(255),
	@status INT
AS
BEGIN	
	UPDATE dbo.Department
	SET status = 0
	WHERE id = @id

	UPDATE dbo.Department
	SET status = 1, name = @name
	WHERE id = @id AND status = 0

	IF @@ROWCOUNT = 0
	BEGIN	
		INSERT INTO dbo.Department(name, status)
		VALUES(@name, @status)
	END 
END
GO
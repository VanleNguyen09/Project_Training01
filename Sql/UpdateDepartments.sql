SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

USE EmployeeManagement
GO	

CREATE PROCEDURE UpdateDepartments
	-- Add the parameters for the stored procedure here
	@id INT,
    @name NVARCHAR(255)
AS
BEGIN
	UPDATE dbo.Department
	SET name = @name
	WHERE id = @id
END
GO

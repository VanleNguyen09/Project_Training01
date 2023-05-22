SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

USE EmployeeManagement
GO	

CREATE PROCEDURE DeleteDepartment
	-- Add the parameters for the stored procedure here
	@id INT,
AS
BEGIN
	DELETE FROM dbo.Department
	SET name = @name
	WHERE id = @id
END
GO

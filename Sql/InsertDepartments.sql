﻿USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[InsertDepartments]
	-- Add the parameters for the stored procedure here
    @name NVARCHAR(255),
	@status INT
AS
BEGIN
	DECLARE @exist INT
	SET @exist = 0

	IF EXISTS (SELECT 1 FROM dbo.Department WHERE name = @name)
	BEGIN
		SET @exist = 1
	END
	ELSE	
	BEGIN
		DECLARE @dept_id INT
		UPDATE dbo.Department
		SET status = 0
		WHERE id = @dept_id

		UPDATE dbo.Department
		SET status = 1
		WHERE id = @dept_id AND status = 0
		UPDATE dbo.Dept_emp SET status = 1 WHERE dept_id = @dept_id AND status = 0 
		UPDATE dbo.Dept_manager SET status = 1 WHERE dept_id = @dept_id AND status = 0 		

		IF @@ROWCOUNT = 0
		BEGIN	
			INSERT INTO dbo.Department(name, status)
			VALUES(@name, @status)
		END 
	END
	SELECT @exist AS IsDuplicate	
END


USE [EmployeeManagement]
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

	IF EXISTS (SELECT 1 FROM dbo.Department WHERE name = @name AND status = 1)
	BEGIN
		SET @exist = 1
	END
	ELSE	
	BEGIN
		
		IF EXISTS (SELECT 1 FROM dbo.Dept_emp WHERE emp_id = @emp_id AND dept_id = @dept_id AND status = 0)
		BEGIN
			-- Cập nhật status của bản ghi hiện có từ 0 thành 1
			UPDATE dbo.Dept_emp SET status = 1 WHERE emp_id = @emp_id AND dept_id = @dept_id AND status = 0;
			SET @isDuplicate = 0; -- Đánh dấu là cập nhật thành công
		END

		IF @@ROWCOUNT = 0
		BEGIN	
			INSERT INTO dbo.Department(name, status)
			VALUES(@name, @status)
		END 
	END
	SELECT @exist AS IsDuplicate
END


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
	DECLARE @isDuplicate INT
 	-- Kiểm tra trùng lặp dữ liệu
	IF EXISTS (SELECT 1 FROM dbo.Department WHERE name = @name)
	BEGIN
		IF EXISTS (SELECT 1 FROM dbo.Department WHERE name = @name AND status = 1)
		BEGIN
			SET @isDuplicate = 1; -- Đánh dấu là đã tồn tại
		END
		ELSE
		BEGIN
			-- Cập nhật status của bản ghi hiện có từ 0 thành 1
			DECLARE @dept_id INT = (SELECT TOP 1 id FROM dbo.Department WHERE name = @name AND status = 0 ORDER BY id)
			UPDATE dbo.Department SET status = 1 WHERE id = @dept_id AND status = 0
			UPDATE dbo.Dept_emp SET status = 1 WHERE dept_id = @dept_id AND status = 0 
			UPDATE dbo.Dept_manager SET status = 1 WHERE dept_id = @dept_id AND status = 0 
			SET @isDuplicate = 0; -- Đánh dấu là cập nhật thành công

		END
	END
	ELSE
	BEGIN
	   -- Insert the department
		INSERT INTO dbo.Department(name, status)
		VALUES(@name, @status)
		SET @isDuplicate = 0; -- Đánh dấu là thêm mới thành công
	END
	
	SELECT @isDuplicate AS IsDuplicate;
END


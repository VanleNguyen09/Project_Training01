SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
USE EmployeeManagement
GO	
CREATE OR ALTER PROCEDURE UpdateDepartments
	-- Add the parameters for the stored procedure here
	@id INT,
    @name NVARCHAR(255)
AS
BEGIN
	DECLARE @isDuplicate INT
 	-- Kiểm tra trùng lặp dữ liệu
	IF EXISTS (SELECT 1 FROM dbo.Department WHERE name = @name AND id <> @id)
	BEGIN
		IF EXISTS (SELECT 1 FROM dbo.Department WHERE name = @name AND id <> @id AND status = 1)
		BEGIN
			SET @isDuplicate = 1; -- Đánh dấu là đã tồn tại
		END
		ELSE
		BEGIN
			-- Cập nhật status của bản ghi hiện có từ 0 thành 1
			UPDATE dbo.Department SET status = 1 WHERE name = @name AND id <> @id AND status = 0
			SET @isDuplicate = 0; -- Đánh dấu là cập nhật thành công
		END
	END
	ELSE
	BEGIN
	   -- Update the department
		UPDATE dbo.Department
		SET name = @name
		WHERE id = @id
		SET @isDuplicate = 0; -- Đánh dấu là thêm mới thành công
	END

	SELECT @isDuplicate AS IsDuplicate;

END
GO
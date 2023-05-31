SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
USE EmployeeManagement
GO	
CREATE OR ALTER PROCEDURE UpdateManager
	-- Add the parameters for the stored procedure here
	@emp_id INT,
	@dept_id INT,
	@from_date DATE,
	@to_date DATE,
	@status INT
AS
BEGIN
	DECLARE @isDuplicate INT;

	-- Kiểm tra trùng lặp dữ liệu
	IF EXISTS (SELECT 1 FROM dbo.Dept_manager WHERE emp_id = @emp_id AND dept_id = @dept_id)
	BEGIN
		IF EXISTS (SELECT 1 FROM dbo.Dept_manager WHERE emp_id = @emp_id AND dept_id = @dept_id AND status = 1)
		BEGIN
			SET @isDuplicate = 1; -- Đánh dấu là đã tồn tại
		END
		ELSE
		BEGIN
			-- Cập nhật status của bản ghi hiện có từ 0 thành 1
			UPDATE dbo.Dept_manager SET status = 1 WHERE emp_id = @emp_id AND dept_id = @dept_id AND status = 0;
			SET @isDuplicate = 0; -- Đánh dấu là cập nhật thành công
		END
	END
	ELSE
	BEGIN
		UPDATE dbo.Dept_manager
		SET dept_id = @dept_id, from_date = @from_date, to_date = @to_date
		WHERE emp_id = @emp_id AND status = @status
	END
	
	SELECT @isDuplicate AS IsDuplicate;
END
GO

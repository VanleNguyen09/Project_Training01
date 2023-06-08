USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[InsertDeptEmp]
	-- Add the parameters for the stored procedure here
	@emp_id INT,
    @dept_id INT,
	@from_date DATETIME,
	@to_date DATETIME,
	@status INT
AS
BEGIN
	SET NOCOUNT ON;
	DECLARE @isDuplicate INT;

	-- Kiểm tra trùng lặp dữ liệu
	
	IF EXISTS (SELECT 1 FROM dbo.Dept_emp WHERE emp_id = @emp_id AND dept_id = @dept_id AND status = 1)
	BEGIN
		SET @isDuplicate = 1; -- Đánh dấu là đã tồn tại
	END

	ELSE IF EXISTS (SELECT 1 FROM dbo.Dept_emp WHERE emp_id = @emp_id AND dept_id = @dept_id AND status = 0)
	BEGIN
		-- Cập nhật status của bản ghi hiện có từ 0 thành 1
		UPDATE dbo.Dept_emp SET status = 1 WHERE emp_id = @emp_id AND dept_id = @dept_id AND status = 0;
		SET @isDuplicate = 0; -- Đánh dấu là cập nhật thành công
	END
	ELSE
	BEGIN
	    INSERT INTO dbo.Dept_emp
	    (
	        emp_id,
	        dept_id,
	        from_date,
	        to_date,
	        status
	    )
		VALUES(@emp_id, @dept_id, @from_date, @to_date, @status);
		SET @isDuplicate = 0; -- Đánh dấu là thêm mới thành công
	END
	
	SELECT @isDuplicate AS IsDuplicate;
END
GO
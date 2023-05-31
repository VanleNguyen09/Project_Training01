SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
USE EmployeeManagement
GO	
CREATE OR ALTER PROCEDURE UpdateEmployees
	-- Add the parameters for the stored procedure here
	@id INT,
	@department_id INT,
    @name NVARCHAR(255),
    @phone VARCHAR(20),
    @address NVARCHAR(255),
	@gender BIT,
    @birthday DATETIME,
    @email VARCHAR(255),
	@image VARBINARY(MAX),
	@status INT
AS
BEGIN
	DECLARE @isDuplicate INT
 	-- Kiểm tra trùng lặp dữ liệu
	IF EXISTS (SELECT 1 FROM dbo.Employees WHERE phone = @phone AND id <> @id)
	BEGIN
		IF EXISTS (SELECT 1 FROM dbo.Employees WHERE phone = @phone AND id <> @id AND status = 1)
		BEGIN
			SET @isDuplicate = 1; -- Đánh dấu là đã tồn tại
		END
		ELSE
		BEGIN
			-- Cập nhật status của bản ghi hiện có từ 0 thành 1
			UPDATE dbo.Employees SET status = 1 WHERE phone = @phone AND id <> @id AND status = 0
			SET @isDuplicate = 0; -- Đánh dấu là cập nhật thành công
		END
	END
	ELSE
	BEGIN
		UPDATE Employees
		SET name = @name,
			phone = @phone,
			address = @address,
			gender = @gender,
			birthday = @birthday,
			email = @email,
			image = @image
		WHERE id = @id
		UPDATE dbo.Dept_emp
		SET dept_id = @department_id
		WHERE emp_id = @id
	END

	SELECT @isDuplicate AS IsDuplicate;
END
GO
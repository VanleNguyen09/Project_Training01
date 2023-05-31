USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[InsertEmployees]
	-- Add the parameters for the stored procedure here
    @name NVARCHAR(255),
	@department_id INT,
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
	IF EXISTS (SELECT 1 FROM dbo.Employees WHERE phone = @phone)
	BEGIN
		IF EXISTS (SELECT 1 FROM dbo.Employees WHERE phone = @phone AND status = 1)
		BEGIN
			SET @isDuplicate = 1; -- Đánh dấu là đã tồn tại
		END
		ELSE
		BEGIN
			-- Cập nhật status của bản ghi hiện có từ 0 thành 1
			UPDATE dbo.Employees SET status = 1 WHERE phone = @phone AND status = 0
			SET @isDuplicate = 0; -- Đánh dấu là cập nhật thành công
		END
	END
	ELSE
	BEGIN
	   -- Insert the department
		INSERT INTO Employees
		(
			name,
			phone,
			address,
			gender,
			birthday,
			email,
			image,
			status
		)
		VALUES(@name, @phone, @address, @gender, @birthday, @email, @image, @status)
		DECLARE @generated_id INT
		SET @generated_id = SCOPE_IDENTITY()
		INSERT INTO dbo.Dept_emp(emp_id, dept_id)
		VALUES(@generated_id, @department_id)
	END
	
	SELECT @isDuplicate AS IsDuplicate;
END
GO
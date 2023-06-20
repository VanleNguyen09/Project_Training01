SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Dat Rikai
-- Create date: 20/06/2023
-- Description:	UpdateSalariesByExcelFile
-- =============================================
CREATE OR ALTER PROCEDURE UpdateSalariesByExcelFile 
	@emp_id INT,
	@emp_name NVARCHAR(255),
	@salary_name NVARCHAR(255),
	@salary DECIMAL(12,2)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	IF NOT EXISTS (SELECT 1 id FROM SalaryEmp WHERE id = -1)
	BEGIN
		SET IDENTITY_INSERT SalaryEmp ON

		INSERT INTO SalaryEmp(id, salary_name, salary, status)
		VALUES (-1, 'Unknown', 1, 1)

		-- Turn off IDENTITY_INSERT cho SalaryEmp
		SET IDENTITY_INSERT SalaryEmp OFF
	END

	IF NOT EXISTS(SELECT id, name FROM Employees WHERE id = @emp_id AND name = @emp_name and status = 1)
	BEGIN
		DECLARE @Result NVARCHAR(255) = CONCAT('This name: ', @emp_name , ' with id: ', @emp_id , ' is not existed');
		THROW 50001, @Result, 1
	END

	IF (@salary_name IS NULL AND @salary IS NULL)
	BEGIN
		UPDATE Employees
		SET salary_emp_id = -1
		WHERE id = @emp_id
		RETURN
	END

	IF (@salary_name IS NOT NULL AND @salary IS NULL) OR (@salary_name IS NULL AND @salary IS NOT NULL)
	BEGIN
		THROW 50001, 'Please check salary and salary name if not null then both is not null', 1
	END

	IF EXISTS(SELECT 1 id FROM SalaryEmp WHERE salary_name = @salary_name AND status = 0)
	BEGIN
		UPDATE SalaryEmp
		SET salary = @salary, status = 1
		WHERE salary_name = @salary_name
	END
	ELSE IF NOT EXISTS(SELECT 1 id FROM SalaryEmp WHERE salary_name = @salary_name AND status = 1)
	BEGIN
		INSERT INTO SalaryEmp(salary, salary_name, status)
		VALUES (@salary, @salary_name, 1)
	END
	ELSE IF EXISTS(SELECT 1 id FROM SalaryEmp WHERE salary_name = @salary_name AND status = 1)
	BEGIN
		DECLARE @checkSalary DECIMAL(12,2);
		SELECT @checkSalary = salary FROM SalaryEmp WHERE salary_name = @salary_name AND status = 1
		IF (@checkSalary <> @salary)
		BEGIN
			DECLARE @ResultError NVARCHAR(255) = CONCAT('Salary name: ', @salary_name , ' with salary: ', @salary , ' is not in sync');
			THROW 50001, @ResultError, 1
		END
	END

	DECLARE @id INT;
	SELECT @id = id FROM SalaryEmp WHERE salary_name = @salary_name AND status = 1
	exec UpdateSalaryForEmp @emp_id, @id
END
GO

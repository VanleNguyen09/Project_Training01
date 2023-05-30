-- ================================================
-- Template generated from Template Explorer using:
-- Create Procedure (New Menu).SQL
--
-- Use the Specify Values for Template Parameters 
-- command (Ctrl-Shift-M) to fill in the parameter 
-- values below.
--
-- This block of comments will not be included in
-- the definition of the procedure.
-- ================================================
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		Dat
-- Create date: 30/5/2023
-- Description:	Update Salary For Emp
-- =============================================
CREATE OR ALTER PROCEDURE UpdateSalaryForEmp
@emp_id INT,
@salary_id INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	IF NOT EXISTS (SELECT * FROM SalaryEmp WHERE id = -1)
	BEGIN
		SET IDENTITY_INSERT SalaryEmp ON

		INSERT INTO SalaryEmp(id, salary_name, salary)
		VALUES (-1, 'Unknown', 1)

		-- Turn off IDENTITY_INSERT cho SalaryEmp
		SET IDENTITY_INSERT SalaryEmp OFF
	END

	UPDATE Employees
	SET Employees.salary_emp_id = @salary_id
	FROM Employees
	WHERE Employees.id = @emp_id
END
GO
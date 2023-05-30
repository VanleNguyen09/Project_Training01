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
-- Description:	Delete Salary By Id
-- =============================================
CREATE OR ALTER PROCEDURE DeleteSalaryById
@salary_id INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	IF (@salary_id = -1)
	BEGIN
		THROW 50001, 'Can not delete default salary!!', 1
		RETURN
	END

	-- Set auto -1 for these employees
    UPDATE Employees
	SET salary_emp_id = -1
	FROM Employees
	INNER JOIN SalaryEmp ON SalaryEmp.id = Employees.salary_emp_id
	WHERE salary_emp_id = @salary_id

	UPDATE SalaryEmp
	SET status = 0
	WHERE id = @salary_id
END
GO

use EmployeeManagement
select * from Employees
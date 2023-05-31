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
-- Description:	Update Salary By Id
-- =============================================
CREATE OR ALTER PROCEDURE UpdateSalaryById
@salary_id INT,
@salary_name NVARCHAR(255),
@salary DECIMAL(12,2)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    IF EXISTS (SELECT 1 FROM SalaryEmp WHERE status = 1 AND salary_name = @salary_name AND id <> @salary_id)
	BEGIN
		THROW 50001, 'This Salary name is existed!', 1
	END

	IF EXISTS (SELECT 1 FROM SalaryEmp WHERE status = 0 AND salary_name = @salary_name)
	BEGIN
		DELETE FROM SalaryEmp WHERE id in (SELECT id FROM SalaryEmp WHERE status = 0 AND salary_name = @salary_name)
	END

	UPDATE SalaryEmp
	SET salary_name = @salary_name, salary = @salary
	WHERE id = @salary_id
END
GO

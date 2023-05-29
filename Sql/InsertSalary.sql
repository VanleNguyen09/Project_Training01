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
-- Create date: 29/5/2023
-- Description:	Insert one salary by name and salary
-- =============================================
CREATE OR ALTER PROCEDURE InsertSalary
@name nvarchar(255),
@salary decimal(10,2)
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    -- Insert statements for procedure here
	IF EXISTS (SELECT 1 FROM SalaryEmp WHERE status = 1 AND salary_name = @name)
	BEGIN
		THROW 50001, 'This Salary name is existed!', 1
	END
	
	-- If name is existed but it is deleted (status = 0)
	IF EXISTS (SELECT 1 FROM SalaryEmp WHERE status = 0 AND salary_name = @name)
	BEGIN
		UPDATE SalaryEmp
		SET salary = @salary, status = 1
		WHERE salary_name = @name
	END
	ELSE
	BEGIN
		INSERT INTO SalaryEmp(salary_name, salary, status)
		VALUES(@name, @salary, 1)
	END
END
GO
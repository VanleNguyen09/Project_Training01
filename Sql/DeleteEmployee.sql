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
USE [EmployeeManagement]
GO
/****** Object:  StoredProcedure [dbo].[GetAllProvinces]    Script Date: 17/05/2023 17:19:48 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
ALTER PROCEDURE [dbo].[DeleteEmployee] 	
	@id INT
AS
BEGIN
	DELETE FROM	dbo.Dept_emp
	WHERE emp_id = @id
	DELETE FROM dbo.Employees
	WHERE id = @id
END


--DROP PROCEDURE dbo.GetEmployeeByID

EXEC dbo.DeleteEmployee @id = 24

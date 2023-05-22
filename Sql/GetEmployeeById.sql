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
ALTER PROCEDURE [dbo].[GetEmployeeByID] 	
	@id INT
AS
BEGIN
	SELECT b.dept_id, a.* FROM dbo.Employees AS a
	JOIN dbo.Dept_emp AS b
	ON a.id = b.emp_id
	WHERE b.emp_id = @id

END


--DROP PROCEDURE dbo.GetEmployeeByID

EXEC dbo.GetEmployeeByID @id = 1

USE [EmployeeManagement]
GO
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE [dbo].[UpdateLeave]
	-- Add the parameters for the stored procedure here
	@id INT,
	@emp_id INT,
  	@from_date DATETIME,
	@reason NVARCHAR(255),
	@status INT
AS
BEGIN
	DECLARE @exist INT
	DECLARE @emp_name NVARCHAR(255) = (SELECT TOP(1) e.name FROM Employees e WHERE e.id = @emp_id)

	SET @exist = 0

	IF EXISTS (SELECT 1 FROM dbo.leave WHERE emp_id = @emp_id and from_date = @from_date AND id <> @id AND status = 1)
	BEGIN
		SET @exist = 1
	END
	ELSE	
	BEGIN
		
		UPDATE dbo.leave
		SET status = 0
		WHERE id = @id

		UPDATE dbo.leave
		SET status = 1, emp_id = @emp_id, emp_name = @emp_name, from_date = @from_date, reason = @reason
		WHERE id = @id AND status = 0		

		IF @@ROWCOUNT = 0
		BEGIN	
			INSERT INTO dbo.leave
			(
			    emp_id,
			    emp_name,
			    from_date,
			    reason,
				status
			)
			VALUES (@emp_id, @emp_name, @from_date, @reason, @status)
		END 
	END
	SELECT @exist AS IsDuplicate
END
GO

--EXEC dbo.GetAllDepartments

--SELECT * FROM dbo.Department WHERE status = 1 AND name = 'Comtor'
USE EmployeeManagement
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE OR ALTER PROCEDURE InsertLeave 
	-- Add the parameters for the stored procedure here
	@emp_id INT,
	@from_date DATETIME,
	@reason NVARCHAR(255),
	@status INT
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

	DECLARE @exist INT
	DECLARE @emp_name NVARCHAR(255) = (SELECT TOP(1) e.name FROM Employees e WHERE e.id = @emp_id)
    
	SET @exist = 0

	IF EXISTS (SELECT 1 FROM dbo.leave WHERE emp_id = @emp_id AND from_date = @from_date AND status = 1)
	BEGIN
		SET @exist = 1
	END
	ELSE 
	BEGIN
		DECLARE @leave_id INT 
		UPDATE dbo.leave
		SET status = 0
		WHERE id = @leave_id

		UPDATE dbo.Department
		SET status = 1
		WHERE id = @leave_id AND status = 0

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

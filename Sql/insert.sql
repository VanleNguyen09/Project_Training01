
-- SP Insert 
ALTER PROCEDURE [dbo].[sp_Insert_]
    -- Add the parameters for the stored procedure here
    @StandardId int = null,
    @StudentName varchar(50)
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;

        INSERT INTO [DatabaseName].[dbo].[TableName]([StudentName],[StandardId])
        VALUES(@StudentName, @StandardId)

    SELECT SCOPE_IDENTITY() AS StudentId

END


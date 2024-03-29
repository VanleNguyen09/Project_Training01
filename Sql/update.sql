ALTER PROCEDURE [dbo].[sp_Update]
    -- Add the parameters for the stored procedure here
    @StudentId int,
    @StandardId int = null,
    @StudentName varchar(50)
AS
BEGIN
    -- SET NOCOUNT ON added to prevent extra result sets from
    -- interfering with SELECT statements.
    SET NOCOUNT ON;

    Update [TableName].[dbo].[TableName] 
    set StudentName = @StudentName,StandardId = @StandardId
    where StudentID = @StudentId;

END
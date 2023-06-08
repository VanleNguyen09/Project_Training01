/*  
execute a list of .sql files against the server and DB specified  
*/  
CREATE OR ALTER PROCEDURE RunAllFiles
@DBServerName VARCHAR(100),
@DBName VARCHAR(100),
@FilePath VARCHAR(200)
AS
BEGIN

SET NOCOUNT ON  

SET XACT_ABORT ON  

    BEGIN TRAN
	/*
	create a holder for all filenames to be executed  
	*/  
	DECLARE @sql NVARCHAR(1000) = 'dir /B "'+ @FilePath +'"'
	DECLARE @FileList TABLE(Files NVARCHAR(MAX))
	INSERT INTO @FileList
	EXEC xp_cmdshell @sql; --Change path here

	WHILE (SELECT COUNT(Files) FROM @FileList) > 0  
	BEGIN  
	   /*  
	   execute each file one at a time  
	   */
		DECLARE @FileName NVARCHAR(MAX) = (SELECT TOP(1) Files FROM @FileList)

		IF @FileName = 'RunAllFiles' -- ignore this file if same folder
		BEGIN
			DELETE FROM @FileList WHERE Files = @FileName
			BREAK
		END

		DECLARE @command  VARCHAR(500)  = 'sqlcmd -S ' + @DBServerName + ' -d  ' + @DBName + ' -i "' + @FilePath + @Filename +'"'  
		EXEC xp_cmdshell  @command
		PRINT 'EXECUTED: ' + @FileName
		DELETE FROM @FileList WHERE Files = @FileName
	END   
    COMMIT
END

-- use EmployeeManagement
-- Example: exec RunAllFiles 'DESKTOP-8T6JQDI' , 'EmployeeManagement', 'E:\.NET\.Net Training\Project_Training01\Sql\'

-- ENABLE xp_cmdshell
-- To allow advanced options to be changed.
--EXEC sp_configure 'show advanced options', 1
--GO
---- To update the currently configured value for advanced options.
--RECONFIGURE
--GO
---- To enable the feature.
--EXEC sp_configure 'xp_cmdshell', 1
--GO
---- To update the currently configured value for this feature.
--RECONFIGURE
--GO
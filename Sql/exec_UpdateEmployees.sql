USE [EmployeeManagement]
GO

EXEC UpdateEmployees @id = 3, 
@name = N'Long Nhật' , 
@phone = N'097959375', 
@address = N'26, Phường Bình An, Quận Cầu Giấy, Hà Nội',
@gender = '',
@birthday = '08/18/2002',
@email = 'longnhat12@gmailcom'


EXEC UpdateEmployees1 @id = 4, 
@name = N'Nhân Vũ' , 
@phone = N'0979593425', 
@birthday = '05/10/2004'

SELECT * FROM dbo.Employees
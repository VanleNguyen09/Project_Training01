use EmployeeManagement
go

insert into Position(name)
values
(N'Giám đốc'),
(N'Quản lý dự án'),
(N'Leader team'),
(N'BA'),
(N'Coder');

insert into Emp_Pos(emp_id, pos_id, from_date)
values
(1, 1, '2023-04-14'),
(1, 2, '2023-04-14'),
(1, 3, '2023-04-14'),
(1, 4, '2023-04-14'),
(1, 5, '2023-04-14');
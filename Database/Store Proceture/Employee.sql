
use MiniStop
go
--Employee
DROP PROCEDURE IF EXISTS SP_Insert_Employee;
go
create proc SP_Insert_Employee
@Last_name nvarchar(50),
@First_name nvarchar(50),
@Phone varchar(12),
@Birth_day date,
@Address nvarchar(50),
@Email nvarchar(50),
@Id_Position int
as
begin
	if (@Last_name='' or @First_name='' or @Phone='' or @Birth_day='' or @Address='' or @Email=''or @Id_Position='')
		THROW 50001, N'Nhập đầy đủ thông tin',1
	if exists (select Email from Employee where Email=@Email)
		THROW 50001, N'Email đã tồn tại',2
	else
		begin
			insert into Employee values (@Last_name,@First_name,@Phone,@Birth_day,@Address,@Email,@Id_Position)
		end
end
execute SP_Insert_Employee 'tuan','hung','98765432','2020/07/11','tan lap 2','hung@gmail.com',4
select*from Position
select*from Employee
-------------------
DROP PROCEDURE IF EXISTS SP_Update_Employee;
go
create proc SP_Update_Employee
@Id_Employee int,
@Last_name nvarchar(50),
@First_name nvarchar(50),
@Phone varchar(12),
@Birth_day date,
@Address nvarchar(50),
@Email nvarchar(50),
@Id_Position int
as
begin
	if (@Last_name='' or @First_name='' or @Phone='' or @Birth_day='' or @Address='' or @Email=''or @Id_Position='')
		THROW 50001, N'Nhập đầy đủ thông tin',1
	if not exists (select Id_Employee from Employee where Id_Employee=@Id_Employee)
		THROW 50001, N'Không tìm thấy nhân viên cần sửa',2
	else
		begin
			update Employee
			set Last_name=@Last_name,First_name=@First_name,Phone=@Phone,Birth_day=@Birth_day,
				Address=@Address,Email=@Email,Id_Position=@Id_Position
			where Id_Employee=@Id_Employee
		end
end
execute SP_Update_Employee 1,'tuan','hung','12345678','2020/07/11','tan lap 2','hung@gmail.com',4
select*from Position
---------------------
DROP PROCEDURE IF EXISTS SP_Delete_Employee;
go
create proc SP_Delete_Employee
@Id_Employee int
as
begin
	if not exists (select Id_Employee from Employee where Id_Employee=@Id_Employee)
		THROW 50001,N'Nhân viên không tồn tại',1
	else
		delete from Employee where Id_Employee=@Id_Employee
end
execute SP_Delete_Employee 1
select*from Employee

use MiniStop
go
--Account
DROP PROCEDURE IF EXISTS SP_Insert_Account;
go
create proc SP_Insert_Account
@Username nvarchar(50),
@Password nvarchar(50),
@Role nvarchar(50),
@Status nvarchar(50),
@Id_Employee int
as
begin
	if (@Username='' or @Password='' or @Date_create='' or @Role='' or @Status='enable'or @Id_Employee='')
		THROW 50001, N'Nhập đầy đủ thông tin',1
	if exists (select Username from Account where Username=@Username)
		THROW 50001, N'Username đã tồn tại',2
	else
		begin
			insert into Account values (@Username,@Password,CONVERT(date, GETDATE()),@Role,@Status,@Id_Employee)
		end
end
execute SP_Insert_Account 'nhan','nhan123','2020/07/11','insert, update, delete','enable',2
select*from Account
select*from Employee
--------------------
DROP PROCEDURE IF EXISTS SP_Delete_Account;
go
create proc SP_Delete_Account
@Username nvarchar(50)
as
begin
	if not exists (select Username from Account where Username=@Username)
		THROW 50001,N'Không tìm thấy Account', 1
	else
		update Account
		set Status='disable'
		where Username=@Username
end
execute SP_Delete_Account 'nhan' 
select *from Account
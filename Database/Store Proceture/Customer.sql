
use MiniStop
go
--Customer
DROP PROCEDURE IF EXISTS SP_Insert_Customer;
go
Create Proc SP_Insert_Customer
@Last_name nvarchar(50),
@First_name nvarchar(50),
@Phone varchar(12),
@Email nvarchar(50)
as
begin
	if (@Last_name='' or @First_name='' or @Phone='' or @Email='')
		THROW 50001, N'Nhập đầu đủ thông tin thông tin',1
	if exists ( select Email from Customer where Email=@Email)
		THROW 50001, N'Email đã tồn tại',2
	else
		insert into Customer values (@Last_name,@First_name,@Phone,@Email)	
end

execute SP_Insert_Customer 'Nguyen Thanh', 'Nhan', '1234567','nhan@gmail.com'
delete from Customer
select *from Customer
-----------------------
DROP PROCEDURE IF EXISTS SP_Update_Customer;
go
Create Proc SP_Update_Customer
@Id_Customer int,
@Last_name nvarchar(50),
@First_name nvarchar(50),
@Phone varchar(12),
@Email nvarchar(50)
as
begin
	if (@Last_name='' or @First_name='' or @Phone='' or @Email='')
		THROW 50001, N'Nhập đầu đủ thông tin thông tin',1
	if not exists ( select Id_Customer from Customer where Id_Customer=@Id_Customer)
		THROW 50001, N'không tìm thấy khách hàng cần sửa',2
	else
		begin
			update Customer
			set Last_name=@Last_name,First_name=@First_name,Phone=@Phone,Email=@Email
			where Id_Customer=@Id_Customer
		end	
end

execute SP_Update_Customer 2, 'Nguyen Thanh', 'Nhan', '01234567','thanhnhan@gmail.com'
delete from Customer
select *from Customer


use MiniStop
go
--Supplier
DROP PROCEDURE IF EXISTS SP_Insert_Supplier;
go
create proc SP_Insert_Supplier
@Name nvarchar(50),
@Address nvarchar(50),
@Phone varchar(12)
as
begin
	if(@Name='' or @Address='' or @Phone='')
		THROW 50001,N'Điền đầy đủ thông tin',1
	if exists (select Name from Supplier where Name=@Name)
		THROW 50001,N'Nhà cung cấp đã tồn tại',2
	else
		insert into Supplier values (@Name,@Address,@Phone)
end
------------------
DROP PROCEDURE IF EXISTS SP_Delete_Supplier;
go
create proc SP_Delete_Supplier
@Name int
as
begin try
	delete from Supplier where Name=@Name 
end try
begin catch
	THROW 50001,N'Xóa thất bại',1
end catch

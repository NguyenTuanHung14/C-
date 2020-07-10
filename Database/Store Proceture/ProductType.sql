
use MiniStop
go
--ProductType
DROP PROCEDURE IF EXISTS SP_Insert_ProductType;
go
create proc SP_Insert_ProductType
@Name nvarchar(50)
as
begin 
	if(@Name='')
		THROW 50001, N'Nhập thông tin',1
	else
		insert into ProductType values(@Name)
end 
------------
DROP PROCEDURE IF EXISTS SP_Delete_ProductType;
go
create proc SP_Delete_ProductType
@Id_ProductType int
as
begin try 
	delete from ProductType where Id_ProductType=@Id_ProductType
end try
begin catch
	THROW 50001, N'Xóa bị lõi',1
end catch
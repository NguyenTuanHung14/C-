
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
		THROW 50001, N'Vui lòng nhập thông tin',1
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
	THROW 50001, N'Loại sản phẩm không tồn tại!',1
end catch


-----------
DROP PROCEDURE IF EXISTS SP_GetAll_ProductType;
go
create proc SP_GetAll_ProductType
as
	SELECT ProductType.Id_ProductType AS MaLoaiHangHoa, ProductType.Name_Type AS TenLoaiHangHoa from ProductType

EXEC SP_GetAll_ProductType
------------
DROP PROCEDURE IF EXISTS SP_GetByID_ProductType;
go
create proc SP_GetByID_ProductType
@Id_ProductType int
as
begin try 
	Select * from ProductType where Id_ProductType=@Id_ProductType
end try
begin catch
	THROW 50001, N'Loại sản phẩm không tồn tại!',1
end catch


select * from ProductType
exec SP_Delete_ProductType 1

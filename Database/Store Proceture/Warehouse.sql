use MiniStop
go
--Warehouse
DROP PROCEDURE IF EXISTS SP_Insert_Warehouse;
go
create proc SP_Insert_Warehouse
@Inventory int,
@Id_Product int
as
begin try
	if (@Inventory='')
		THROW 50001, N'Nhập thông tin',1
	else
		insert into Warehouse values (@Inventory,@Id_Product)
end try 
begin catch
	THROW 50001, N'Thêm thất bại', 2
end catch

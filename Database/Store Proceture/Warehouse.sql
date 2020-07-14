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


--Get hàng hóa tồn kho

DROP PROCEDURE IF EXISTS SP_GetAll_WarehouseProduct;
go
create proc SP_GetAll_WarehouseProduct
as
	SELECT Product.Id_Product, Product.Name_product, Product.Price,Product.Amount, WareHouse.Inventory 
	FROM WareHouse, Product 
	WHERE Product.Id_Product = WareHouse.Id_Product 


EXEC SP_GetAll_WarehouseProduct
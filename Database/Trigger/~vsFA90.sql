USE MiniStop
GO


---Cap nhat ton kho khi nhap hang
IF OBJECT_ID ('TG_Insert_ReceipNote') IS NOT NULL
	DROP TRIGGER TG_Insert_ReceipNote
GO

CREATE TRIGGER TG_Insert_ReceipNote 
ON ReceiptNoteDetail
AFTER INSERT 
AS
	BEGIN
		UPDATE WareHouse
		SET Inventory = Inventory + (SELECT Amount FROM INSERTED 
								WHERE Id_Product = WareHouse.Id_Product)
		FROM  WareHouse, INSERTED WHERE WareHouse.Id_Product =INSERTED.Id_Product
	END

-- Them phieu nhap khi nhap hang

	

--Cap nhat ton kho va hang hoa tren ke khi xuat hang
IF OBJECT_ID ('TG_Insert_DeliveryNote') IS NOT NULL
	DROP TRIGGER TG_Insert_DeliveryNote
GO

CREATE TRIGGER TG_Insert_DeliveryNote 
ON DeliveryNoteDetail
AFTER INSERT 
AS
	BEGIN
	--C?p nh?t hàng hóa trong kho
		UPDATE WareHouse
		SET Inventory = Inventory - (SELECT Amount FROM INSERTED 
								WHERE Id_Product = WareHouse.Id_Product)
		FROM  WareHouse, INSERTED WHERE WareHouse.Id_Product =INSERTED.Id_Product

	-- C?p nh?t hàng hóa trên k? 
		UPDATE Product
		SET Amount = Amount + (SELECT Amount FROM INSERTED WHERE Id_Product = Product.Id_Product)
		FROM Product, INSERTED WHERE Product.Id_Product = INSERTED.Id_Product
	END
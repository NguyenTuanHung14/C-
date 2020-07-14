use MiniStop
go 

--ReceiptNoteDetail
DROP PROCEDURE IF EXISTS SP_Insert_ReceiptNoteDetail;
go
create proc SP_Insert_ReceiptNoteDetail
@Id_GoodsReceiptNote int,
@Id_Product int,
@Price float,
@Amount int,
@MFG_date date,
@EXP_date date
as

	if(@Price='' or @Amount='' or @MFG_date ='' or @EXP_date ='')
		THROW 50001,N'Nhập đầy đủ thông tin',1
begin try
	insert into ReceiptNoteDetail values (@Price,@Amount,@Id_GoodsReceiptNote,@Id_Product,@MFG_date,@EXP_date)
end try
begin catch
	DECLARE @ErrorMessage NVARCHAR(2000)
	SELECT @ErrorMessage = 'Error: ' + ERROR_MESSAGE()
	RAISERROR(@ErrorMessage, 16, 1)
end catch


exec SP_Insert_ReceiptNoteDetail 1,5, 20000, 4, '2020-08-20', '2020-10-03'
select * from GoodsReceiptNote
select * from ReceiptNoteDetail
select * from WareHouse
select * from Product
---Trigger thêm phiếu nhập
IF OBJECT_ID ('TG_Insert_ReceiptNote') IS NOT NULL
	DROP TRIGGER TG_Insert_ReceiptNote
GO

CREATE TRIGGER TG_Insert_ReceiptNote 
ON ReceiptNoteDetail
AFTER INSERT 
AS
	BEGIN
	--C?p nh?t hàng hóa trong kho
		UPDATE WareHouse
		SET WareHouse.Inventory = WareHouse.Inventory + INSERTED.Amount
		FROM  WareHouse, INSERTED WHERE WareHouse.Id_Product = INSERTED.Id_Product

	-- C?p nh?t hàng hóa trên k? 
		
		UPDATE Product
		SET Product.Amount = Product.Amount + INSERTED.Amount,
		 Product.Price = INSERTED.Price,
		 Product.MFG_date = INSERTED.MFG_date,
		 Product.EXP_date = INSERTED.EXP_date
		FROM Product, INSERTED WHERE Product.Id_Product = INSERTED.Id_Product


		Update GoodsReceiptNote 
		SET Total = Total + (INSERTED.Price * INSERTED.Amount)
		FROM GoodsReceiptNote, INSERTED WHERE GoodsReceiptNote.Id_GoodsReceiptNote = INSERTED.Id_GoodsReceiptNote
	END
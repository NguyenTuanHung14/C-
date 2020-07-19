
use MiniStop
go 

--DeliveryNoteDetail
DROP PROCEDURE IF EXISTS SP_Insert_DeliveryNoteDetail;
go
create proc SP_Insert_DeliveryNoteDetail
@Id_GoodsDeliveryNote int,
@Id_Product int,
@Amount int
as 
begin try
	if(@Amount='')
		THROW 50001,N'Nhập số lượng sản phẩm',1
	else
		insert into DeliveryNoteDetail values (@Amount,@Id_GoodsDeliveryNote,CONVERT(time, GETDATE()),@Id_Product)
end try
begin catch
	DECLARE @ErrorMessage NVARCHAR(2000)
	SELECT @ErrorMessage = 'Error: ' + ERROR_MESSAGE()
	RAISERROR(@ErrorMessage, 16, 1)
end catch
-----------
---Trigger cập nhật kho khi xuất hàng và hàng hóa trên kệ

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
		SET WareHouse.Inventory = WareHouse.Inventory - INSERTED.Amount
		FROM  WareHouse, INSERTED WHERE WareHouse.Id_Product = INSERTED.Id_Product

	-- C?p nh?t hàng hóa trên k? 
		
		UPDATE Product
		SET Product.Amount = Product.Amount + INSERTED.Amount
		FROM Product, INSERTED WHERE Product.Id_Product = INSERTED.Id_Product


		Update GoodsDeliveryNote 
		SET Total = Total + (Product.Price * INSERTED.Amount)
		FROM GoodsDeliveryNote,Product, INSERTED WHERE GoodsDeliveryNote.Id_GoodsDeliveryNote = INSERTED.Id_GoodsDeliveryNote 
		and INSERTED.Id_Product = Product.Id_Product
	END



select * from DeliveryNoteDetail
select * from GoodsDeliveryNote
select * from WareHouse
select * from Product

exec SP_Insert_DeliveryNoteDetail 1 ,5 ,5

--Get all
DROP PROCEDURE IF EXISTS SP_GetAll_DeliveryNoteDetail;
go
create proc SP_GetAll_DeliveryNoteDetail
AS 
	SELECT * FROM DeliveryNoteDetail

DROP PROCEDURE IF EXISTS SP_GetAllByID_DeliveryNoteDetail;
go


--Get all by ID

DROP PROCEDURE IF EXISTS SP_GetAllByID_DeliveryNoteDetail;
go
create proc SP_GetAllByID_DeliveryNoteDetail
@Id int
AS 
	IF NOT EXISTS (SELECT Id_GoodsDeliveryNote FROM GoodsDeliveryNote WHERE Id_GoodsDeliveryNote = @Id) or @Id =''
		THROW 50001, N'Phiếu nhập không tồn tại',1
BEGIN TRY
	SELECT DeliveryNoteDetail.Id_DeliveryNoteDetail, Product.Name_product, DeliveryNoteDetail.Amount, Product.Price,Product.MFG_date,Product.EXP_date,
	GoodsDeliveryNote.Date_create, DeliveryNoteDetail.Time, Employee.Last_name,Employee.Id_Employee,GoodsDeliveryNote.Id_GoodsDeliveryNote
	FROM DeliveryNoteDetail,GoodsDeliveryNote, Product , Employee WHERE DeliveryNoteDetail.Id_GoodsDeliveryNote = @Id
	AND GoodsDeliveryNote.Id_GoodsDeliveryNote = DeliveryNoteDetail.Id_GoodsDeliveryNote 
	AND GoodsDeliveryNote.Id_Employee = Employee.Id_Employee AND
	Product.Id_Product = DeliveryNoteDetail.Id_Product
END TRY
BEGIN CATCH
	DECLARE @ErrorMessage NVARCHAR(2000)
	SELECT @ErrorMessage = 'Error: ' + ERROR_MESSAGE()
	RAISERROR(@ErrorMessage, 16, 1)
END CATCH

exec SP_GetAllByID_DeliveryNoteDetail 9

select * from GoodsDeliveryNote


SElect * from DeliveryNoteDetail
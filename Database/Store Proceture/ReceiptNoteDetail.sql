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
@EXP_date date,
@Id_supplier int
as

	if(@Price='' or @Amount='' or @MFG_date ='' or @EXP_date ='' or @Id_supplier='')
		THROW 50001,N'Nhập đầy đủ thông tin',1
begin try
	insert into ReceiptNoteDetail values (@Price,@Amount,@Id_GoodsReceiptNote,@Id_Product,CONVERT(time, GETDATE()),@MFG_date,@EXP_date,@Id_supplier)
end try
begin catch
	DECLARE @ErrorMessage NVARCHAR(2000)
	SELECT @ErrorMessage = 'Error: ' + ERROR_MESSAGE()
	RAISERROR(@ErrorMessage, 16, 1)
end catch


exec SP_Insert_ReceiptNoteDetail 1,7, 20000, 4, '2020-08-20', '2020-10-03',1
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
		SET Product.Price = INSERTED.Price,
		 Product.MFG_date = INSERTED.MFG_date,
		 Product.EXP_date = INSERTED.EXP_date
		FROM Product, INSERTED WHERE Product.Id_Product = INSERTED.Id_Product


		Update GoodsReceiptNote 
		SET Total = Total + (INSERTED.Price * INSERTED.Amount)
		FROM GoodsReceiptNote, INSERTED WHERE GoodsReceiptNote.Id_GoodsReceiptNote = INSERTED.Id_GoodsReceiptNote
	END


--Get all 
DROP PROCEDURE IF EXISTS SP_GetAll_ReceiptNoteDetail;
go
create proc SP_GetAll_ReceiptNoteDetail
AS 
	SELECT * FROM ReceiptNoteDetail

--Get by Phieu nhap
DROP PROCEDURE IF EXISTS SP_GetAllByID_ReceiptNoteDetail;
go
create proc SP_GetAllByID_ReceiptNoteDetail
@Id int
AS 
	IF NOT EXISTS (SELECT Id_Supplier FROM Supplier WHERE Id_Supplier = @Id) or @Id =''
		THROW 50001, N'Hôm nay chưa tạo phiếu nhập',1
BEGIN TRY
	SELECT ReceiptNoteDetail.Id_ReceiptNoteDetail, Product.Name_product, ReceiptNoteDetail.Amount, ReceiptNoteDetail.Price,ReceiptNoteDetail.MFG_date,ReceiptNoteDetail.EXP_date,
	GoodsReceiptNote.Date_create, ReceiptNoteDetail.Time, Employee.First_name,Employee.Id_Employee,GoodsReceiptNote.Id_GoodsReceiptNote
	FROM ReceiptNoteDetail,GoodsReceiptNote, Product , Employee WHERE ReceiptNoteDetail.Id_GoodsReceiptNote = @Id
	AND GoodsReceiptNote.Id_GoodsReceiptNote = ReceiptNoteDetail.Id_GoodsReceiptNote 
	AND GoodsReceiptNote.Id_Employee = Employee.Id_Employee AND
	Product.Id_Product = ReceiptNoteDetail.Id_Product
END TRY
BEGIN CATCH
	DECLARE @ErrorMessage NVARCHAR(2000)
	SELECT @ErrorMessage = 'Error: ' + ERROR_MESSAGE()
	RAISERROR(@ErrorMessage, 16, 1)
END CATCH

exec SP_GetAllByID_ReceiptNoteDetail 1
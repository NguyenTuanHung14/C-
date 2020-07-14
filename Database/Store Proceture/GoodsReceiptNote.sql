use MiniStop
go 

--GoodsReceiptNote
DROP PROCEDURE IF EXISTS SP_Insert_GoodsReceiptNote;
go
create proc SP_Insert_GoodsReceiptNote
@Id_Employee int
as
	IF EXISTS (SELECT Id_GoodsReceiptNote FROM GoodsReceiptNote WHERE Date_create = CONVERT(date, GETDATE()))
		THROW 50001, N'Hôm nay đã tạo phiếu nhập rồi',1
	IF @Id_Employee = ''
		THROW 50001, N'Vui lòng nhập đầy đủ thông tin',1
	begin try
		insert into GoodsReceiptNote values( CONVERT(date, GETDATE()), CONVERT(time, GETDATE()),0,@Id_Employee)
	end try
	begin catch
		DECLARE @ErrorMessage NVARCHAR(2000)
		SELECT @ErrorMessage = 'Error: ' + ERROR_MESSAGE()
		RAISERROR(@ErrorMessage, 16, 1)
	end catch

select * from GoodsReceiptNote
exec SP_Insert_GoodsReceiptNote 1


--Get GoodsReceiptNote theo ngày
DROP PROCEDURE IF EXISTS SP_Get_GoodsReceiptNote;
go
create proc SP_Get_GoodsReceiptNote
AS
	SELECT Id_GoodsReceiptNote FROM GoodsReceiptNote WHERE Date_create = CONVERT(date, GETDATE())
select * from GoodsDeliveryNote
exec SP_Insert_GoodsDeliveryNote 1
EXEC SP_Get_GoodsReceiptNote
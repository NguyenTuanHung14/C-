
use MiniStop
go

--GoodsDeliveryNote
DROP PROCEDURE IF EXISTS SP_Insert_GoodsDeliveryNote;
go
create proc SP_Insert_GoodsDeliveryNote
@Id_Employee int
as 
	if( @Id_Employee='')
		THROW 50001, N'Vui lòng nhập đầy đủ thông tin.', 1
	IF EXISTS (SELECT Id_GoodsDeliveryNote FROM GoodsDeliveryNote WHERE Date_create = CONVERT(date, GETDATE()))
		THROW 50001, N'Hôm nay đã tạo phiếu xuất rồi',1
begin try
	insert into GoodsDeliveryNote values (CONVERT(date, GETDATE()),0,@Id_Employee)
end try
begin catch
	DECLARE @ErrorMessage NVARCHAR(2000)
	SELECT @ErrorMessage = 'Error: ' + ERROR_MESSAGE()
	RAISERROR(@ErrorMessage, 16, 1)
end catch

--Get GoodsDeliveryNote theo ngày
DROP PROCEDURE IF EXISTS SP_Get_GoodsDeliveryNote;
go
create proc SP_Get_GoodsDeliveryNote
AS
	SELECT Id_GoodsDeliveryNote FROM GoodsDeliveryNote WHERE Date_create = CONVERT(date, GETDATE())
select * from GoodsDeliveryNote
exec SP_Insert_GoodsDeliveryNote 1
EXEC SP_Get_GoodsDeliveryNote

delete from GoodsDeliveryNote where Id_GoodsDeliveryNote = 8



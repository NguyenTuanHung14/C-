
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
		insert into DeliveryNoteDetail values (@Amount,@Id_GoodsDeliveryNote,@Id_Product)
end try
begin catch
	THROW 50001,N'Thêm sản để xuất thất bại', 2
end catch
-----------
DROP PROCEDURE IF EXISTS SP_Update_DeliveryNoteDetail;
go
create proc SP_Update_DeliveryNoteDetail
@Id_DeliveryNoteDetail int,
@Id_Product int,
@Amount int
as
begin
	declare @Id_GoodsDeliveryNote int=(select Id_GoodsDeliveryNote from GoodsDeliveryNote where Date_create=CONVERT(DATE, GETDATE()))	
	update DeliveryNoteDetail
	set Amount+=@Amount
	where Id_DeliveryNoteDetail=@Id_GoodsDeliveryNote and Id_Product=@Id_Product
end

-------------
DROP PROCEDURE IF EXISTS SP_Delete_DeliveryNoteDetail;
go
create proc SP_Delete_DeliveryNoteDetail
@Id_DeliveryNoteDetail int,
@Id_Product int,
@Amount int
as
begin
	declare @Id_GoodsDeliveryNote int=(select Id_GoodsDeliveryNote from GoodsDeliveryNote where Date_create=CONVERT(DATE, GETDATE()))	
	delete from DeliveryNoteDetail
	where Id_DeliveryNoteDetail=@Id_GoodsDeliveryNote and Id_Product=@Id_Product
end

select *from DeliveryNoteDetail
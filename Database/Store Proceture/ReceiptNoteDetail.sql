use MiniStop
go 

--ReceiptNoteDetail
DROP PROCEDURE IF EXISTS SP_Insert_ReceiptNoteDetail;
go
create proc SP_Insert_ReceiptNoteDetail
@Id_GoodsReceiptNote int,
@Id_Product int,
@Price float,
@Amount int
as
begin try
	if(@Price='' or @Amount='')
		THROW 50001,N'Nhập đầy đủ thông tin',1
	insert into ReceiptNoteDetail values (@Price,@Amount,@Id_GoodsReceiptNote,@Id_Product)
end try
begin catch
	THROW 50001,N'Thêm sản phẩm bị lõi',2
end catch

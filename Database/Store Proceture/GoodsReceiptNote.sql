use MiniStop
go 

--GoodsReceiptNote
DROP PROCEDURE IF EXISTS SP_Insert_GoodsReceiptNote;
go
create proc SP_Insert_GoodsReceiptNote
@Total float
as
begin try
	insert into GoodsReceiptNote values( CONVERT(date, GETDATE()), CONVERT(time, GETDATE()),@Total)
end try
begin catch
	THROW 50001,N'Tạo phiếu nhập bị lõi',1
end catch

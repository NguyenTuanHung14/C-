
use MiniStop
go

--GoodsDeliveryNote
DROP PROCEDURE IF EXISTS SP_Insert_GoodsDeliveryNote;
go
create proc SP_Insert_GoodsDeliveryNote
@Total float,
@Id_Employee int
as 
begin
	if(@Total='' or @Id_Employee='')
		THROW 50001, N'Tạo phiếu nhập thất bại', 1
	else
		insert into GoodsDeliveryNote values (CONVERT(date, GETDATE()),CONVERT(time, GETDATE()),@Total,@Id_Employee)
end


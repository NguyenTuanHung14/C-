
use MiniStop
go
--Bill detail
DROP PROCEDURE IF EXISTS SP_Insert_BillDetail;
go
create proc SP_Insert_BillDetail
@Price float,
@Amount int,
@Id_Bill int,
@Id_Product int
as
begin 
	declare @Amount_catelog int=(select Amount from Product where Id_Product=@Id_Product) 
	if(@Amount_catelog=0)
		THROW 50001, N'Mặt hàng đã hết',1
	else
		insert into BillDetail values(@Price,@Amount,@Id_Bill,@Id_Product)
end 

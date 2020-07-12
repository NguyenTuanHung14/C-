
use MiniStop
go
--Card
DROP PROCEDURE IF EXISTS SP_Insert_Card;
go
Create Proc SP_Insert_Card
@Score int
as
begin
	if (@Score='')
		THROW 50001, N'Nhập thông tin',1
	else
		insert into Card values (CONVERT(date, GETDATE()),@Score)	
end

execute SP_Insert_Card 10
select *from card
-------------------
DROP PROCEDURE IF EXISTS SP_Update_Card;
go
create proc SP_Update_Card
@Id_Card int,
@Score int
as
begin
	if (@Score='')
		THROW 50001, N'Nhập thông tin',1
	else
		update Card 
		set Score=@Score
		where Id_Card=@Id_Card
end

execute SP_Update_Card 1,8
select *from card


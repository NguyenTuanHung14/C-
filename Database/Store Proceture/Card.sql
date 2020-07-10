
use MiniStop
go
--Card
DROP PROCEDURE IF EXISTS SP_Insert_Card;
go
Create Proc SP_Insert_Card
@Date_create date,
@Score int
as
begin
	if (@Score='')
		THROW 50001, N'Nhập thông tin',1
	else
		insert into Card values (@Date_create,@Score)	
end

execute SP_Insert_Card '2020/10/20', 10
select *from card
-------------------
DROP PROCEDURE IF EXISTS SP_Update_Card;
go
create proc SP_Update_Card
@Id_Card int,
@Date_create date,
@Score int
as
begin
	if (@Score='')
		THROW 50001, N'Nhập thông tin',1
	else
		update Card 
		set Date_create=@Date_create, Score=@Score
		where Id_Card=@Id_Card
end

execute SP_Update_Card 1, '2020/10/10',8
select *from card


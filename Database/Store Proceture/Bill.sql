use MiniStop
go
--Bil
DROP PROCEDURE IF EXISTS SP_Insert_Bill;
go
create proc SP_Insert_Bill
@Date_create date,
@Time time,
@Total float,
@Id_Employee int
as
begin
	insert into Bill values(@Date_create,@Time,@Total,@Id_Employee)
end
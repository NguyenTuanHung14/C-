use MiniStop
go
--Bil
DROP PROCEDURE IF EXISTS SP_Insert_Bill;
go
create proc SP_Insert_Bill
@Total float,
@Id_Employee int
as
begin
	insert into Bill values(CONVERT(date, GETDATE()),CONVERT(time, GETDATE()),@Total,@Id_Employee)
end
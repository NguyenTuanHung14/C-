use MiniStop
go
--Bil
DROP PROCEDURE IF EXISTS SP_Insert_Bill;
go
create proc SP_Insert_Bill
@Id_Employee int
as
begin
	insert into Bill values(CONVERT(date, GETDATE()),CONVERT(time, GETDATE()),0,@Id_Employee,0)
end

exec SP_Insert_Bill  1
select * from Bill


---update status bill

DROP PROCEDURE IF EXISTS SP_Update_Bill;
go
create proc SP_Update_Bill
@id_bill INT
as
begin
	UPDATE Bill 
	SET Status = 1
	WHERE Id_Bill = @id_bill
end

exec SP_Update_Bill 3
select * from Bill


--Select Bill

DROP PROCEDURE IF EXISTS SP_Get_Bill;
go
create proc SP_Get_Bill
as
begin
	SELECT * FROM Bill WHERE Status = 0
end

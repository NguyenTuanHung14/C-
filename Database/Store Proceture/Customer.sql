
use MiniStop
go
--Customer
ALTER TABLE Customer
drop column Last_name
DROP PROCEDURE IF EXISTS SP_Insert_Customer;
go
Create Proc SP_Insert_Customer
@First_name nvarchar(50),
@Phone varchar(12),
@Email nvarchar(50)
as
begin
	if (@First_name='' or @Phone='' or @Email='')
		THROW 50001, N'Nhập đầu đủ thông tin thông tin',1
	if exists ( select Email from Customer where Email=@Email)
		THROW 50001, N'Email đã tồn tại',2
	else
		insert into Customer values (@First_name,@Phone,@Email)	
end

execute SP_Insert_Customer 'Nhan', '1234567','nhaffn@gmail.com'
SELECT * from Card
select *from Customer
-----------------------


IF OBJECT_ID ('TG_Insert_Card') IS NOT NULL
	DROP TRIGGER TG_Insert_Card
GO

CREATE TRIGGER TG_Insert_Card
ON Customer
FOR INSERT
AS 
BEGIN
	DECLARE @Id_cus int
	SELECT @Id_cus = inserted.Id_Customer FROM inserted
	INSERT INTO  Card VALUES (CONVERT(DATE,GETDATE()),0,@Id_cus)
END


----Get Member by Email

DROP PROCEDURE IF EXISTS SP_GetByEmail_Member;
go
Create Proc SP_GetByEmail_Member
@Email nvarchar(50)
as
begin
	if not exists ( select Email from Customer where Email=@Email) or @Email=''
		THROW 50001, N'Email chưa đăng ký thành viên',2
	else
		select Customer.Id_Customer , Customer.First_name, Card.Id_Card,Card.Score
		 FROM Customer,Card WHERE Customer.Id_Customer = Card.Id_Customer 
		 AND Customer.Email = @Email
end
exec SP_GetByEmail_Member '123@gmail.com'


--Update diem
DROP PROCEDURE IF EXISTS SP_UpdateScore_Card;
go
Create Proc SP_UpdateScore_Card
@Id_member nvarchar(50),
@score int
as
begin
	DECLARE @ID_CARD INT
	SELECT @ID_CARD= Id_Card FROM Card,Customer WHERE Card.Id_Customer = Customer.Id_Customer
		update Card
		set Score = Score+@score
		where Id_Card = @ID_CARD
end

exec SP_UpdateScore_Card 3, 1000
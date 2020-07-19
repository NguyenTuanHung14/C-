
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
	if(@Amount_catelog<0)
		THROW 50001, N'Mặt hàng đã hết',1
	if(@Amount_catelog < @Amount)
		THROW 50001, N'Không đủ hàng hóa',1
	else
		DECLARE @ID_BillDetailExsist INT
		DECLARE @amountConst INT = 1
		SELECT @ID_BillDetailExsist = Id_BillDetail, @amountConst = Amount
		FROM BillDetail
		WHERE Id_Bill = @Id_Bill and Id_Product = @Id_Product

		IF(@ID_BillDetailExsist!=0)
			BEGIN
				DECLARE @SoLuongSauKhiThem  INT = @amountConst + @Amount
				if(@SoLuongSauKhiThem > 0)
					UPDATE BillDetail SET Amount = @SoLuongSauKhiThem where Id_Product = @Id_Product and Id_Bill = @Id_Bill
				else if(@SoLuongSauKhiThem <=0)
					DELETE BillDetail WHERE Id_Bill = @Id_Bill and Id_Product = @Id_Product
			END
		ELSE
			BEGIN
				IF (@Amount<=0)
					THROW 50001, N'Số lượng phải là số nguyên dương',1
				INSERT INTO BillDetail VALUES (@Price,@Amount,@Id_Bill,@Id_Product)
			END	
END

select * from BillDetail
select * from Product


exec SP_Insert_BillDetail 12000,-100,4,9
select * from BillDetail
select * from Product

--Update Bill detail

select * from Bill
select * from Product



--Delete bill detail



IF OBJECT_ID ('TG_Update_Product') IS NOT NULL
	DROP TRIGGER TG_Update_Product
GO

CREATE TRIGGER TG_Update_Product
ON BillDetail
AFTER INSERT
AS 
BEGIN
	UPDATE Product 
	SET Amount = Product.Amount - inserted.Amount
	FROM Product, inserted WHERE Product.Id_Product = inserted.Id_Product


	UPDATE Bill
	SET Total = Bill.Total + (inserted.Price*inserted.Amount)
	FROM Bill, inserted WHERE Bill.Id_Bill = inserted.Id_Bill
END


IF OBJECT_ID ('TG_Update_BillDetail') IS NOT NULL
	DROP TRIGGER TG_Update_BillDetail
GO

CREATE TRIGGER TG_Update_BillDetail
ON BillDetail
INSTEAD OF UPDATE
AS 
BEGIN
	DECLARE @amount int
	DECLARE @id_billDetail int
	DECLARE @current_ammount int
	SELECT @amount = Amount ,@id_billDetail =Id_BillDetail FROM inserted
	SELECT @current_ammount  = Amount FROM BillDetail WHERE Id_BillDetail = @id_billDetail
	UPDATE BillDetail 
	SET Amount = @amount 
	WHERE Id_BillDetail = @id_billDetail
	
	UPDATE Product 
	SET Amount = Product.Amount - inserted.Amount +@current_ammount
	FROM Product, inserted WHERE Product.Id_Product = inserted.Id_Product
END

IF OBJECT_ID ('TG_Update_ProductForCheckOut') IS NOT NULL
	DROP TRIGGER TG_Update_ProductForCheckOut
GO

CREATE TRIGGER TG_Update_ProductForCheckOut
ON BillDetail
FOR DELETE
AS 
BEGIN

	UPDATE Product 
	SET Amount = Product.Amount + deleted.Amount
	FROM Product, deleted WHERE Product.Id_Product = deleted.Id_Product

	
	UPDATE Bill
	SET Total = Bill.Total - (deleted.Price*deleted.Amount)
	FROM Bill, deleted WHERE Bill.Id_Bill = deleted.Id_Bill
	DECLARE @id_bill int
	SELECT @id_bill =Id_Bill FROM deleted
	IF NOT EXISTS (SELECT * FROM Bill,BillDetail WHERE Bill.Id_Bill = BillDetail.Id_Bill AND Bill.Id_Bill = @id_bill)
		BEGIN
			DELETE FROM Bill WHERE Bill.Id_Bill = @id_bill
		END
END



--Get bill detail by bill

DROP PROCEDURE IF EXISTS SP_GetAllByID_BillDetail;
go
CREATE PROC SP_GetAllByID_BillDetail
@id_bill INT
AS
BEGIN
	IF NOT EXISTS (SELECT * FROM Bill WHERE Id_Bill = @id_bill)
	THROW 50001, N'Hóa đơn không tồn tại',1
	SELECT Product.Id_Product,Product.Name_product, BillDetail.Amount, BillDetail.Price, Product.Discount, 
	(BillDetail.Amount*BillDetail.Price - (BillDetail.Amount*BillDetail.Price)*(Product.Discount/100)) AS Total
	FROM BillDetail, Product WHERE BillDetail.Id_Bill = @id_bill AND BillDetail.Id_Product = Product.Id_Product
END

EXEC SP_GetAllByID_BillDetail 32



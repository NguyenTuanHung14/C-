USE MiniStop
GO

--Create a product
IF OBJECT_ID ('SP_Insert_Product') IS NOT NULL
	DROP PROC SP_Insert_Product
GO

CREATE PROC SP_Insert_Product 
	(@Name_product NVARCHAR(50),
	 @Price FLOAT,
	 @Amount INT,
	 @MFG_date DATE,
	 @EXP_date DATE,
	 @Discount FLOAT,
	 @Id_ProductType INT)
AS 
		IF EXISTS (SELECT Id_Product FROM Product WHERE Name_product = @Name_product )
		THROW 50001, N'Tên Hàng hóa đã tồn tại',1
		IF @Name_product = ''
		THROW 50001, N'Tên hàng hóa không được bỏ trống',1
		BEGIN TRANSACTION
		BEGIN TRY	
				INSERT INTO Product
				VALUES (@Name_product,@Price,@Amount,@MFG_date,@EXP_date,@Discount,@Id_ProductType)
				COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK TRANSACTION
			DECLARE @ErrorMessage NVARCHAR(2000)
			SELECT @ErrorMessage = 'Error: ' + ERROR_MESSAGE()
			RAISERROR(@ErrorMessage, 16, 1)
		END CATCH


SELECT * FROM Product
EXEC SP_Insert_Product N'Thịt heo', '',0,'','',0,'1'

--Delete a product

IF OBJECT_ID ('SP_Delete_Product') IS NOT NULL
	DROP PROC SP_Delete_Product
GO

CREATE PROC SP_Delete_Product (@Id_product int)
AS 
	BEGIN
		IF NOT EXISTS (SELECT @Id_product FROM Product WHERE Id_Product = @Id_product)
		THROW 50001, N'Hàng hóa không tồn tại!',1
		DELETE FROM Product WHERE Id_Product = @Id_product 
	END

SELECT * FROM Product

EXEC SP_Delete_Product 2


--Update Product

IF OBJECT_ID ('SP_Update_Product') IS NOT NULL
	DROP PROC SP_Update_Product
GO

CREATE PROC SP_Update_Product 
	(@Id_product INT,
	 @Name_product NVARCHAR(50),
	 @Price FLOAT,
	 @Amount INT,
	 @MFG_date DATE,
	 @EXP_date DATE,
	 @Discount FLOAT,
	 @Id_ProductType INT)
AS 
	BEGIN TRANSACTION
		BEGIN TRY
			IF NOT EXISTS (SELECT Id_product FROM Product WHERE Id_product = @Id_product)
			THROW 50001, N'Hàng hóa không tồn tại',1
			IF @Name_product = ''
			THROW 50001, N'Tên hàng hóa không được bỏ trống',1		
			IF EXISTS (SELECT Id_product FROM Product WHERE Name_product = @Name_product AND Id_product != @Id_product)
			THROW 50001, N'Tên Hàng hóa đã tồn tại',1
			UPDATE Product
			SET Name_product = @Name_product,
				Price = @Price,
				Amount = @Amount,
				MFG_date = @MFG_date,
				EXP_date= @EXP_date,
				Discount=@Discount,
				Id_ProductType=@Id_ProductType
			WHERE Id_product = @Id_product
			COMMIT
		END TRY
		BEGIN CATCH
			ROLLBACK TRANSACTION
			DECLARE @ErrorMessage NVARCHAR(2000)
			SELECT @ErrorMessage = 'Error: ' + ERROR_MESSAGE()
			RAISERROR(@ErrorMessage, 16, 1)
		END CATCH
SELECT * FROM Product
exec SP_Update_Product 3 , N'Thịt bò', '','','','',50,1

--Get all Product

IF OBJECT_ID ('SP_GetAll_Product') IS NOT NULL
	DROP PROC SP_GetAll_Product
GO
CREATE PROC  SP_GetAll_Product
AS
BEGIN
	SELECT *
	FROM  Product 
END

EXEC SP_GetAll_Product

--Get Product by ID

IF OBJECT_ID ('SP_GetByID_Product') IS NOT NULL
	DROP PROC SP_GetByID_Product
GO
CREATE PROC  SP_GetByID_Product
(@Id_product INT)
AS
BEGIN
	IF NOT EXISTS (SELECT Id_product FROM Product WHERE Id_product = @Id_product)
	THROW 50001, N'Hàng hóa không tồn tại',1
	SELECT *
	FROM  Product 
	WHERE Id_product=@Id_product
END
EXEC SP_GetByID_Product 3

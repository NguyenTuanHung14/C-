

USE  MiniStop

IF OBJECT_ID ('TG_Insert_WareHouse') IS NOT NULL
	DROP TRIGGER TG_Insert_WareHouse
GO

CREATE TRIGGER TG_Insert_WareHouse 
ON Product
AFTER INSERT
AS 
	BEGIN
		DECLARE @Id_Product INT
		SET @Id_Product = (SELECT Id_Product FROM INSERTED)
		INSERT WareHouse
		VALUES (0, @Id_Product)
	END


select * from WareHouse
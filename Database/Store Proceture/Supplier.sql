
use MiniStop
go
--Supplier
DROP PROCEDURE IF EXISTS SP_Insert_Supplier;
go
create proc SP_Insert_Supplier
@Name nvarchar(50),
@Address nvarchar(50),
@Phone varchar(12),
@Image image
as
	if(@Name='' or @Address='' or @Phone='' or @Image is Null)
		THROW 50001,N'Điền đầy đủ thông tin',1
	if exists (select Name from Supplier where Name=@Name)
		THROW 50001,N'Nhà cung cấp đã tồn tại',2
begin try
		insert into Supplier values (@Name,@Address,@Phone,@Image)
end try
begin catch
	DECLARE @ErrorMessage NVARCHAR(2000)
	SELECT @ErrorMessage = 'Error: ' + ERROR_MESSAGE()
	RAISERROR(@ErrorMessage, 16, 1)
end catch
------------------
DROP PROCEDURE IF EXISTS SP_Delete_Supplier;
go
create proc SP_Delete_Supplier
@Id int
as
IF NOT EXISTS (SELECT Id_Supplier FROM Supplier WHERE Id_Supplier = @Id)
THROW 50001, N'Nhà cung cấp không tồn tại!',1
begin try
	delete from Supplier where Id_Supplier=@Id 
end try
begin catch
	THROW 50001,N'Xóa thất bại',1
end catch

---Cập nhật nhà cung cấp
DROP PROCEDURE IF EXISTS SP_Update_Supplier;
go
create proc SP_Update_Supplier
@Id int,
@Name nvarchar(50),
@Address nvarchar(50),
@Phone varchar(12),
@Image image
as
	IF NOT EXISTS (SELECT Id_Supplier FROM Supplier WHERE Id_Supplier = @Id)
		THROW 50001, N'Nhà cung cấp không tồn tại',1
	if(@Id is null or @Name='' or @Address='' or @Phone='' or @Image is Null)
		THROW 50001,N'Điền đầy đủ thông tin',1
	IF EXISTS (SELECT Id_Supplier FROM Supplier WHERE Name = @Name AND Id_Supplier != @Id)
		THROW 50001, N'Tên nhà cung cấp đã tồn tại',1
begin try
		UPDATE Supplier 
		SET Name=@Name,
		Address=@Address,
		Phone =@Phone,
		HinhAnh=@Image
		WHERE Id_Supplier = @Id
end try
begin catch
	DECLARE @ErrorMessage NVARCHAR(2000)
	SELECT @ErrorMessage = 'Error: ' + ERROR_MESSAGE()
	RAISERROR(@ErrorMessage, 16, 1)
end catch

exec SP_Update_Supplier 2, N'Chợ', 'Thu duc','9383947','' 
select * from Supplier

exec SP_Delete_Supplier 1
---Lấy tất cả nhà cung cấp

DROP PROCEDURE IF EXISTS SP_GetAll_Supplier
GO


CREATE PROCEDURE SP_GetAll_Supplier 
AS
	SELECT * FROM Supplier

EXEC SP_GetAll_Supplier

--Lấy nhà cung cấp theo id
DROP PROCEDURE IF EXISTS SP_GetById_Supplier
GO


CREATE PROCEDURE SP_GetById_Supplier 
@Id INT
AS
	IF NOT EXISTS (SELECT Id_Supplier FROM Supplier WHERE Id_Supplier = @Id) or @Id =''
		THROW 50001, N'Nhà cung cấp không tồn tại',1
	BEGIN TRY
		SELECT * FROM Supplier WHERE Id_Supplier=@Id
	END TRY
	BEGIN CATCH
		DECLARE @ErrorMessage NVARCHAR(2000)
		SELECT @ErrorMessage = 'Error: ' + ERROR_MESSAGE()
		RAISERROR(@ErrorMessage, 16, 1)
	END CATCH
	

EXEC SP_GetAll_Supplier
EXEC SP_GetById_Supplier 6
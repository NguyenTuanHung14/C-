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

---Get All Bill
DROP PROCEDURE IF EXISTS SP_GetAll_Bill;
go
create proc SP_GetAll_Bill
as
begin
	SELECT Bill.Id_Bill,Bill.Date_create,Bill.Time,Bill.Total,Employee.Last_name , Employee.Id_Employee
	FROM Bill, Employee WHERE Status = 1 AND
	Bill.Id_Employee = Employee.Id_Employee
end


EXEC SP_GetAll_Bill

---GET BILL BY DATE
DROP PROCEDURE IF EXISTS SP_GetAllByDate_Bill;
go
create proc SP_GetAllByDate_Bill
@fromDate Date,
@toDate Date
as
begin
	SELECT Bill.Id_Bill,Bill.Date_create,Bill.Time,Bill.Total,Employee.Last_name, Employee.Id_Employee
	FROM Bill,Employee
	 WHERE CONVERT(date,@fromDate) <= Date_create and  CONVERT(date,@toDate) >= Date_create
	 AND Bill.Id_Employee = Employee.Id_Employee
end
exec SP_GetAllByDate_Bill '2020-7-15','2020-7-30'



-----Thống kế theo sản phẩm

SELECT * FROM BillDetail
DROP PROCEDURE IF EXISTS SP_Statistical_ByProduct;
go
create proc SP_Statistical_ByProduct
AS
BEGIN
	select Product.Name_product,  SUM(BillDetail.Amount) AS Amount,WareHouse.Inventory from BillDetail,Product, WareHouse
	WHERE BillDetail.Id_Product = Product.Id_Product 
	AND WareHouse.Id_Product = Product.Id_Product
	GROUP BY Product.Name_product,WareHouse.Inventory
END


exec SP_Statistical_ByProduct


-----Thống kế theo loại sản phẩm
DROP PROCEDURE IF EXISTS SP_Statistical_ByProductType;
go
create proc SP_Statistical_ByProductType
AS
BEGIN
	select ProductType.Name_Type, SUM(BillDetail.Amount) AS Amount from BillDetail,Product, ProductType
	WHERE BillDetail.Id_Product = Product.Id_Product
	AND Product.Id_ProductType = ProductType.Id_ProductType
	GROUP BY ProductType.Name_Type
END

exec SP_Statistical_ByProductType

---Thống kê theo ngày
DROP PROCEDURE IF EXISTS SP_Statistical_ByDate;
go
create proc SP_Statistical_ByDate
AS
BEGIN
	select Product.Name_product,Bill.Date_create ,SUM(BillDetail.Amount) AS Amount from BillDetail,Product, Bill
	WHERE BillDetail.Id_Product = Product.Id_Product 
	AND Bill.Id_Bill = BillDetail.Id_Bill
	AND Bill.Date_create = CONVERT(date,GETDATE())
	GROUP BY Product.Name_product,Bill.Date_create
END

exec SP_Statistical_ByDate

---Thống kê theo tháng

DROP PROCEDURE IF EXISTS SP_Statistical_ByMonth;
go
create proc SP_Statistical_ByMonth
AS
BEGIN
	select Product.Name_product,MONTH(Bill.Date_create) as Month, SUM(BillDetail.Amount) AS Amount from BillDetail,Product, Bill
	WHERE BillDetail.Id_Product = Product.Id_Product 
	AND Bill.Id_Bill = BillDetail.Id_Bill
	GROUP BY MONTH(Bill.Date_create), Product.Name_product
END

exec SP_Statistical_ByMonth
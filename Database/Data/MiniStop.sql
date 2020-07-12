

IF EXISTS 
   (
    SELECT name FROM master.dbo.sysdatabases 
    WHERE name = N'MiniStop'
    )
BEGIN
    SELECT 'Database Name already Exist' AS Message
END
ELSE
BEGIN
    CREATE DATABASE MiniStop
END
GO
USE MiniStop
Go
if not exists (select * from sysobjects where name='Position')
    create table Position (
		Id_Position int not null IDENTITY(1,1),
        Name varchar(50),
		Primary Key (Id_Position)
    )
go
if not exists (select * from sysobjects where name='Customer')
    create table Customer (
		Id_Customer int not null IDENTITY(1,1),
        Last_name nvarchar(50),
		First_name nvarchar(50),
		Phone varchar(12),
		Email nvarchar(50),
		Primary Key (Id_Customer),
    )
go
if not exists (select * from sysobjects where name='Employee')
    create table Employee (
		Id_Employee int not null IDENTITY(1,1),
        Last_name nvarchar(50),
		First_name nvarchar(50),
		Phone varchar(12),
		Birth_day date,
		Address nvarchar(50),
		Email nvarchar(50),
		Id_Position int,
		Primary Key (Id_Employee),
		FOREIGN KEY (Id_Position) REFERENCES Position(Id_Position)

    )
go
if not exists (select * from sysobjects where name='Account')
    create table Account (
		Id_Account int not null IDENTITY(1,1),
        Username nvarchar(50),
		Password nvarchar(50), 
		Date_create date,
		Role nvarchar(50),
		Status nvarchar(50),
		Id_Employee int,
		Primary Key (Id_Account),
		FOREIGN KEY (Id_Employee) REFERENCES Employee(Id_Employee)
    )
go

if not exists (select * from sysobjects where name='Card')
    create table Card (
		Id_Card int not null IDENTITY(1,1),
        Date_create date,
		Score int, 
		Id_Customer int,
		Id_Employee int,
		Primary Key (Id_Card),
		FOREIGN KEY (Id_Customer) REFERENCES Customer(Id_Customer),
		FOREIGN KEY (Id_Employee) REFERENCES Employee(Id_Employee)
    )
go


if not exists (select * from sysobjects where name='ProductType')
    create table ProductType (
		Id_ProductType int not null IDENTITY(1,1),
        Name_Type nvarchar(50),
		Primary Key (Id_ProductType),
    )
go
if not exists (select * from sysobjects where name='Product')
    create table Product (
		Id_Product int not null IDENTITY(1,1),
        Name_product nvarchar(50),
		Price float,
		Amount int,
		MFG_date date,
		EXP_date date,
		Discount float,
		Id_ProductType int,
		Primary Key (Id_Product),
		FOREIGN KEY (Id_ProductType) REFERENCES ProductType(Id_ProductType)
    )
go
if not exists (select * from sysobjects where name='WareHouse')
    create table WareHouse (
		Id_WareHouse int not null IDENTITY(1,1),
        Inventory int,
		Id_Product int,
		Primary Key (Id_WareHouse),
		FOREIGN KEY (Id_Product) REFERENCES Product(Id_Product)
    )
go
if not exists (select * from sysobjects where name='Supplier')
    create table Supplier (
		Id_Supplier int not null IDENTITY(1,1),
        Name nvarchar(50),
		Phone varchar(12),
		Address nvarchar(50),
		Primary Key (Id_Supplier)
    )
go
if not exists (select * from sysobjects where name='GoodsReceiptNote')
    create table GoodsReceiptNote (
		Id_GoodsReceiptNote int not null IDENTITY(1,1),
		Date_create date,
		Time time,
		Total float,
		Id_Supplier int,
		Id_Employee int,
		Primary Key (Id_GoodsReceiptNote),
		FOREIGN KEY (Id_Supplier) REFERENCES Supplier(Id_Supplier),
		FOREIGN KEY (Id_Employee) REFERENCES Employee(Id_Employee)
    )
go
if not exists (select * from sysobjects where name='ReceiptNoteDetail')
    create table ReceiptNoteDetail (
		Id_ReceiptNoteDetail int not null IDENTITY(1,1),
		Price float,
		Amount int,
		Id_GoodsReceiptNote int,
		Id_Product int,
		Primary Key (Id_ReceiptNoteDetail),
		FOREIGN KEY (Id_GoodsReceiptNote) REFERENCES GoodsReceiptNote(Id_GoodsReceiptNote),
		FOREIGN KEY (Id_Product) REFERENCES Product(Id_Product)
    )
go
if not exists (select * from sysobjects where name='GoodsDeliveryNote')
    create table GoodsDeliveryNote (
		Id_GoodsDeliveryNote int not null IDENTITY(1,1),
		Date_create date,
		Time time,
		Total float,
		Id_Employee int,
		Primary Key (Id_GoodsDeliveryNote),
		FOREIGN KEY (Id_Employee) REFERENCES Employee(Id_Employee)
    )
go
if not exists (select * from sysobjects where name='DeliveryNoteDetail')
    create table DeliveryNoteDetail (
		Id_DeliveryNoteDetail int not null IDENTITY(1,1),
		Amount int,
		Id_GoodsDeliveryNote int,
		Id_Product int
		Primary Key (Id_DeliveryNoteDetail),
		FOREIGN KEY (Id_GoodsDeliveryNote) REFERENCES GoodsDeliveryNote(Id_GoodsDeliveryNote),
		FOREIGN KEY (Id_Product) REFERENCES Product(Id_Product)
    )
go
if not exists (select * from sysobjects where name='Bill')
    create table Bill (
		Id_Bill int not null IDENTITY(1,1),
		Date_create date,
		Time time,
		Total float,
		Id_Employee int,
		Primary Key (Id_Bill),
		FOREIGN KEY (Id_Employee) REFERENCES Employee(Id_Employee)
    )
go
if not exists (select * from sysobjects where name='BillDetail')
    create table BillDetail (
		Id_BillDetail int not null IDENTITY(1,1),
		Price float,
		Amount int,
		Id_Bill int,
		Id_Product int,
		Primary Key (Id_BillDetail),
		FOREIGN KEY (Id_Bill) REFERENCES Bill(Id_Bill),
		FOREIGN KEY (Id_Product) REFERENCES Product(Id_Product)
    )
go

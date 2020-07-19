
use MiniStop
go
--Employee



ALTER TABLE Employee
ADD Tinhtrang nvarchar(20)



ALTER TABLE Employee
DROP COLUMN  First_name

DROP PROCEDURE IF EXISTS SP_Insert_Employee;
go
create proc SP_Insert_Employee
@Last_name nvarchar(50),
@Phone varchar(12),
@Birth_day date,
@Address nvarchar(50),
@Email nvarchar(50),
@Id_Position int
as
begin
	if (@Last_name=''  or @Phone='' or @Birth_day='' or @Address='' or @Email=''or @Id_Position='')
		THROW 50001, N'Nhập đầy đủ thông tin',1
	if exists (select Email from Employee where Email=@Email)
		THROW 50001, N'Email đã tồn tại',2
	else
		begin
			insert into Employee values (@Last_name, @Phone, @Birth_day, @Address, @Email, @Id_Position, N'Đang sử dụng')
		end
end
execute SP_Insert_Employee 'tuan','hung','98765432','2020/07/11','tan lap 2','hung@gmail.com',4
select*from Position
select*from Employee
-------------------
DROP PROCEDURE IF EXISTS SP_Update_Employee;
go
create proc SP_Update_Employee
@Id_Employee int,
@Last_name nvarchar(50),
@Phone varchar(12),
@Birth_day date,
@Address nvarchar(50),
@Email nvarchar(50),
@Id_Position int
as
begin
	if (@Last_name='' or @Phone='' or @Birth_day='' or @Address='' or @Email=''or @Id_Position='')
		THROW 50001, N'Nhập đầy đủ thông tin',1
	if not exists (select Id_Employee from Employee where Id_Employee=@Id_Employee)
		THROW 50001, N'Không tìm thấy nhân viên cần sửa',2
	else
		begin
			update Employee
			set Last_name=@Last_name,Phone=@Phone,Birth_day=@Birth_day,
				Address=@Address,Email=@Email,Id_Position=@Id_Position
			where Id_Employee=@Id_Employee
		end
end
execute SP_Update_Employee 1,'tuan','hung','12345678','2020/07/11','tan lap 2','hung@gmail.com',4
select*from Employee
---------------------
DROP PROCEDURE IF EXISTS SP_Delete_Employee;
go
create proc SP_Delete_Employee
@Id_Employee int
as
update Employee
			set Tinhtrang =N'Không hoạt động'
			where Id_Employee=@Id_Employee
	
		
execute SP_Delete_Employee 1
select*from Employee
DROP PROCEDURE IF EXISTS SP_GetAll_Employee;
go
create proc SP_GetAll_Employee
AS
BEGIN
	SELECT e.Id_Employee, e.Last_name, e.Phone, e.Birth_day, e.Address,e.Email, p.Name,e.Tinhtrang
	FROM  Employee e join Position p on e.Id_Position= p.Id_Position
	WHERE e.Tinhtrang != N'Không hoạt động'
END
select * from Employee


----TRIGGER INSERT ACCOUNT
IF OBJECT_ID ('TG_Insert_Account') IS NOT NULL
	DROP TRIGGER TG_Insert_Account
GO

CREATE TRIGGER TG_Insert_Account 
ON Employee
AFTER INSERT, UPDATE
AS 
BEGIN
	IF EXISTS (SELECT * FROM Account, inserted WHERE Account.Id_Employee = inserted.Id_Employee)
		BEGIN
			 UPDATE Account 
			 SET Password = inserted.Phone
			 FROM Account, inserted WHERE Account.Id_Employee = inserted.Id_Employee
		END 
	ELSE
		BEGIN
			DECLARE @username NVARCHAR(20)
			DECLARE @password NVARCHAR(20)
			DECLARE @position NVARCHAR(20)
			DECLARE @id_employee int
			SELECT @username=Email, @password = Phone, @position = Position.Name, @id_employee = inserted.Id_Employee
			FROM inserted, Position 
			WHERE inserted.Id_Position = Position.Id_Position
			INSERT Account VALUES (@username,@password, CONVERT(date,GETDATE()),@position, N'Đang hoạt động', @id_employee)
		END
END

---Get account By employee
DROP PROCEDURE IF EXISTS SP_GetByEmp_Account;
go
create proc SP_GetByEmp_Account
@Id_Employee int
as
begin
	if not exists (select * from Employee where Id_Employee=@Id_Employee)
		THROW 50001, N'Nhân viên không tồn tại',2
	else
		begin
			select Username, Password,Role from Account, Employee WHERE Employee.Id_Employee = Account.Id_Employee
			AND @Id_Employee = Employee.Id_Employee
		end
end

---Get Position

DROP PROCEDURE IF EXISTS SP_GetAll_Position
go
create proc SP_GetAll_Position
as
begin
	SELECT Id_Position AS MaChucVu, Name as TenChucVu FROM Position
end
exec SP_GetAll_Employee
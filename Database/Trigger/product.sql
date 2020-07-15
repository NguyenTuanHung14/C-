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



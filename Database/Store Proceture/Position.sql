
use MiniStop
go
--Position
DROP PROCEDURE IF EXISTS SP_Insert_Position;
go
Create Proc SP_Insert_Position
@Name nvarchar(50)
as
begin
	if (@Name='')
		THROW 50001, N'Nhập thông tin',1
	if exists (select name from Position where Name=@Name)
		THROW 50001, N'Tên chức vụ đã tồn tại',2		
	else
		insert into Position values (@Name)	
end
delete from Position
execute SP_Insert_Position 'Manage'
select * from Position


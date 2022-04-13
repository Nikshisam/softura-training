use Trial 
go


select * from tbl_Enrollment

go
alter proc sp_Enroll

@Name VarChar(20)
as
begin
delete [dbo].[tbl_Enrollment]
where StuFname=@Name
end
exec sp_Enroll 'yogalak'
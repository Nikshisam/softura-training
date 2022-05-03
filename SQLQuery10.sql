use Activity
go
select*from Customer_List
create proc GetAllCustomers
as
select CustID,CustomerName,EmailID,ContactNo
from dbo.Customer_List
exec GetAllCustomers
use Trial
Go
create table Customer
(
 CustomerID int, 
 CustomerName varchar(20),
 EmailID varchar(40),
 MobileNo varchar(10)
)
select*from Customer

create TABLE Customer
(
CustomerID int,
CustomerName varchar(20),
EMailID varchar(30),
MobileNo varchar(20),
constraint PK_CustId Primary key(CustomerID)
)
create proc GetAllCustomers
as
select CustomerID,CustomerName,EmailID,MobileNo
from dbo.Customer
exec GetAllCustomers
insert Customer values(2001,'Nikshidha','kbdajhofsu@gmail.com','9876543210')
insert Customer values(2002,'Yogalakshmi','dsvgdfu@gmail.com','8765432101')
insert Customer values(2003,'Swetha','drgdsdfyd@gmail.com','765432189')
insert Customer values(2004,'Gloria','sfghrtc@gmail.com','9876543542')
create database Activity
go
use Activity
go

--Product table

create table Product_List(
ProdID int identity(1,1),
ProdName varchar(20),
Price money,
DateofManufacture date default getdate(),
ExpiryDate date default getdate()
constraint c_Prod primary key(ProdID)
)

--Customer Table
create table Customer_List(
CustID int identity(1001,1),
CustomerName varchar(20),
Gender varchar(10),
dateOfBirth date,
ContactNo varchar(20),
EmailID varchar(40),
City varchar(20),
constraint chk_g check(Gender in ('Male','Female')),
constraint chk_c check(City in ('Chennai','Mumbai','Hyderabad','Pune')),
constraint c_Cost primary KEy(CustID)
)

--PurChase Table

create table Purchase_List(
BillNo int identity(1001,1),
CustID int,
ProdID int,
Quantity int,
TotalAmount int ,
Purchasedate date default getdate()
constraint c_pur primary KEy(BillNo),
Constraint C_customer foreign key(CustID) references Customer_List(CustID),
Constraint C_proc foreign key(ProdID) references Product_List(ProdID)
)
select*from Purchase_List
drop table Purchase_List
insert Product_List (ProdName,Price,DateofManufacture,ExpiryDate) values('SmartWatch',5300,getdate(),DATEADD(m,12,getdate()))
insert Product_List (ProdName,Price,DateofManufacture,ExpiryDate) values('haedSet',350,getdate(),DATEADD(m,12,getdate()))
insert Product_List (ProdName,Price,DateofManufacture,ExpiryDate) values('BlueTooth Speaker',750,getdate(),DATEADD(m,12,getdate()))
insert Product_List (ProdName,Price,DateofManufacture,ExpiryDate) values('airPods',1500,getdate(),DATEADD(m,12,getdate()))
delete from Product_List where ProdID=1
select Price*2 from Product_List where ProdID=2;
select*from Product_List


insert Customer_List(CustomerName,Gender,dateOfBirth,ContactNo,EmailID,City) values('GloriaSeelan','FeMale','2001-o4-11','9344737119','gloria@gmail.com','Pune')
delete from Customer_List where CustID=1004
select*from Purchase_List
go
select  ppl.ProdID,CustID,Quantity,ProdName,ppl.TotalAmount
from Product_List pl
join Purchase_List ppl
on pl.ProdID=ppl.ProdID
go

select * from Customer_List

 

 select *from Purchase_List where DateOfPurchase='2022-04-18'

 
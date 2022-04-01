use AdventureWorks2019
go
--task1
select firstname,lastname
from person.person
where Title is not null


--task2
select firstname,lastname
from person.person
where FirstName like '%a%' or lastname like '%a%' 

--task3
select sales.currency.currencycode,name
from sales.Currency,sales.Countryregioncurrency
--task 4
select * into Hr_dept
from HumanResources.Department


--task5
create table dummy
(
Sno int identity(2001001,1),
FirstName varchar(20),
LastNAme varchar(20),
Gender Varchar(1),
Age int
)
select * from dummy
insert dummy values('nikshi','sam','F',21)
insert dummy values('yoga','lakshmi','F',21)
insert dummy values('swetha','boobalan','F',21)
insert dummy values('jenitha','robin','F',20)
insert dummy values('gloria','seelan','F',21)
insert dummy values('devi','mukepshene','F',21)

--task6

select emphis.businessentityID,addresstypeid
from HumanResources.employeedepartmenthistory emphis
join person.BusinessEntityAddress pbe
on emphis.BusinessEntityID=pbe.businessentityid
inner join HumanResources.Department hrdept
on hrdept.DepartmentID=emphis.DepartmentID



--task 7
select distinct groupname
from HumanResources.Department

--task19
select addressID,pa.AddressLine1,addressline2,pa.stateprovinceID,stateProvinceCode,CountryregionCode
from person.StateProvince psp
join person.address pa
on psp.StateProvinceID=pa.StateProvinceID


--task18
select ppi.locationID,shelf,name
from production.ProductInventory ppi
join production.Location pl
on ppi.LocationID=pl.LocationID


--task17
select productID,LocationID,Shelf
from production.ProductInventory
where ProductID>=300 and ProductID<=350 and locationID=50 


--task16
select firstname,middlename,title,addresstypeID,pp.BusinessEntityID
from person.person pp
join person.BusinessEntityAddress bea
on pp.BusinessEntityID=bea.BusinessEntityID
where title is not null


--task15

select max(rate) as MaxSalary,Name
from HumanResources.EmployeePayHistory pay
join HumanResources.EmployeeDepartmentHistory dhis
on pay.BusinessEntityID = dhis.BusinessEntityID
join HumanResources.Department dept
on dept.DepartmentID = dhis.DepartmentID
GRoup By name

--task 12
select hdh.BusinessEntityID,dept.DepartmentID,ShiftID
from HumanResources.Employee He
join HumanResources.EmployeeDepartmentHistory hdh
on he.BusinessEntityID=hdh.BusinessEntityID
join HumanResources.Department dept
on dept.DepartmentID=hdh.DepartmentID
Select BirthDate,getdate() as CurrentDate, datediff(YY,BirthDate,getdate()) as age 
from HumanResources.Employee

go

--task 13
create view task12
as
Select BirthDate,getdate() as CurrentDate, datediff(YY,BirthDate,getdate()) as age 
from HumanResources.Employee
go
select *from task12


--task 14
SELECT count(*) NoOfRows
FROM [HumanResources].[Department],[HumanResources].[Employee],[HumanResources].[EmployeeDepartmentHistory],[HumanResources].[EmployeePayHistory],[HumanResources].[Shift]
 
--task 11
select Max(taxrate) MaximumTaxRate
from sales.SalesTaxRate

--task 10
select sum(SalesQuota) as sumis
 from Sales.SalesPersonQuotaHistory
 where SalesQuota>5000 and salesquota<100000
 group by SalesQuota

 select * from sales.SalesPersonQuotaHistory


 --task8
 select pp.standardcost,sum(listprice) sum1,sum(pp.standardcost+ListPrice) Sum2
from Production.Product pp
join Production.ProductCostHistory pch
on pp.ProductID = pch.ProductID
group by pp.StandardCost

--task9
select DATEDIFF (YY,StartDate,EndDate) as YearsOnAge
from HumanResources.EmployeeDepartmentHistory


--task20
select sum([SubTotal]),sum([TaxAmt])
from [Sales].[CountryRegionCurrency] crc
join [Sales].[SalesTerritory] st
on crc.[CountryRegionCode]=st.[CountryRegionCode]
join [Sales].[SalesOrderHeader] soh
on st.[TerritoryID]=soh.[TerritoryID]
group by st.[TerritoryID]





















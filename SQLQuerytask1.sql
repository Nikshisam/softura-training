use AdventureWorks2019
go
SELECT COUNT(BusinessEntityID)
FROM Person.Person

SELECT SUM(BusinessEntityID)
FROM Person.Person
SELECT DATEDIFF(year, '2009-01-07 00:00:00.000', '2009-01-09 00:00:00.000') AS ModifiedDate
select ModifiedDate from Person.PersonPhone


SELECT DATEADD(year, 1, '2009-01-07 00:00:00.000') AS ModifiedDate

SELECT CONVERT(float, 25.65)
SELECT CONVERT(int, 25.65)
 
 select * from HumanResources.Employee
 select LEFT(JobTitle,BusinessEntityID) as Employee from HumanResources.Employee


 select len(JobTitle) from HumanResources.Employee


 SELECT REVERSE(JobTitle) from HumanResources.Employee


 --task2
 select ModifiedDate,'$'+convert(varchar,EndOfDayRate) as PaymentAmount
from Sales.CurrencyRate


--task3
CREATE VIEW currency AS
SELECT CurrencyCode, Name,ModifiedDate
FROM Sales.Currency
WHERE CurrencyCode = '%A'
Insert Into currency Select 'EAI','devin Thomas',GETDATE()
Insert Into Sales.Currency(CurrencyCode,Name,ModifiedDate) values('FAT','glory',GETDATE())
select * from Sales.Currency



--task5

select Name , DaysToManufacture
from Production.Product
where DaysToManufacture in (select DaysToManufacture from Production.Product where Name='blade')





--task6


select[Name]
from[Production].[Product]
where  name like '%all%'  or name like '%any%' or name like '%some%'

select max([Weight]) as Maxweight,[ProductModelID]
from  [Production].[Product]
GRoup By [ProductModelID]



--task7

select FirstName,LastName
from Person.Person
select name
from Sales.SalesTerritory sst
join Sales.SalesPerson sp
on sp.TerritoryID=sst.TerritoryID
select max(SalesLastYear),Name
from Sales.SalesTerritory
group by Name




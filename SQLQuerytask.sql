use trial
go
create database task
use task
go
create table tbl_tasksql
(
FirstName varchar(20),
LastName VARCHAR (20),
Age int constraint chk_Age check(Age>=18),
MarksInSslC int,
MarksInHsc int,
Nameofthecollege varchar(40),
Degree varchar(20),
Percentageindegree int,
ContactNumber varchar(10),
AddressOfYourResidence varchar(50),

)

select *from tbl_tasksql
insert tbl_tasksql values('Nikshi','Sam',21,474,881,'Panimalar','BachelorofTechnology',76,'9876543211','qwertyuioplkjhgfdsazxcvbnm')
insert tbl_tasksql values('Yoga','Lakshmi',20,380,1096,'Panimalar','BachelorofTechnology',77,'8765432199','zx cnfjzsrlgzdiuzjn;skdhtiuwgs')
insert tbl_tasksql values('Swetha','Boobalan',21,476,881,'Panimalar','BachelorofTechnology',85,'9878765432','qwertyuioplkjhgfdsazxcvbnm')








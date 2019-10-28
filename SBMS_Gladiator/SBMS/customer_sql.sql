CREATE DATABASE SBMS
use SBMS
create table Customer(
Id int identity(1,1),
Code varchar(50),
Name varchar(50),
[Address] varchar(50),
Email varchar(50),
Contact varchar(50),
LoyltyPoint float(50)
)
insert into Customer(Code,Name,[Address],Email,Contact,LoyltyPoint) values ('1010','Saddam','dhaka','saddam@gmail.com','01843955825',10)
select * from Customer



)
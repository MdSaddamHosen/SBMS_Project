CREATE DATABASE SBMS
USE SBMS
create table Customer(
Id int identity(1,1),
Code varchar(50),
Name varchar(50),
[Address] varchar(50),
Email varchar(50),
Contact varchar(50),
LoyaltyPoint float
)
insert into Customer (Code,Name,[Address],Email,Contact,LoyaltyPoint) values('1010','saddam','dhaka','saddam@gmil.com','01843958825',10)
select * from Customer
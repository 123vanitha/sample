create table Login
(
Id int primary key identity(1,1),
UserName varchar(50),
Password varchar(50)
)

insert into Login values('jyoti','jyoti123'),('admin','admin123')
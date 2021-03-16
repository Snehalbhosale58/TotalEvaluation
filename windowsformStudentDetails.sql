create table information
(id int primary key identity,
name varchar(50) not null,
gender varchar(30) not null,
address varchar(50) not null,
contact varchar(20) not null,
department varchar(40) not null
)

insert into information values('Snehal Bhosale','Female','Pune',123456789,'CSE')
select *from information

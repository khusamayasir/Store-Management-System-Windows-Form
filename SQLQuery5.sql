create database Store_Management_System;
use Store_Management_System;
create table owner
(
did int primary key identity(1,1),
username varchar(20),
pass varchar(30)
);

insert into owner values('Admin','admin12')
select*from owner;

create table product
(
pid int primary key identity(1,1),
modelnumber int,
productname varchar(40),
wholesalecost int,
retailcost int,
quantity int
);
select*from product
--update product set productname ='Slanty' where pid=2
create table customer
(
did int primary key identity(1,1),
username varchar(20),
cphone int,
pass varchar(30)
);
select*from customer

create table Purchase
(
id int primary key identity(1,1),
Product_Id int,
Qty decimal
);

select username ,cphone,pproductname ,productqty  from SShoping where username =''
insert into SShoping (username,cphone,pproductname,productqty )
values('Talha',23242,'Lays',6)
select productname,sum(quantity) as Qty,sum(productqty) as SellQty ,sum(quantity) -sum(productqty) as balanceQty from(
select*from SShoping inner join product on SShoping.pproductname=product.productname )a group by productname
alter view inv_detail as
select productname ,isnull(quantity,0) as quantity,isnull(TotalSellQty,0) as TotalSellQty ,isnull(quantity,0)-isnull(TotalSellQty,0) as Bal from product left join vw_sell on product.productname=vw_sell.pproductname 

select * from inv_detail
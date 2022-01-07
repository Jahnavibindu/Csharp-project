create database salesmanandcostumer
----to display all the information of all salesmen
create table salesman(salesmanId int,Name varchar(30),city varchar(15),commission decimal(5,2))   
insert into salesman values(5001,'James Hoog','New York',0.15)
insert into salesman values(5002,'Nail Knite','Paris',0.13)
insert into salesman values(5005,'Pit Alex','London',0.11)
insert into salesman values(5006,'Mc Lyon','Paris',0.14)
insert into salesman values(5007,'Paul Adam','Rome',0.13)
insert into salesman values(5003,'Lauson Hen','San Jose',0.12)
select *from salesman
drop table salesman
-------------------------
----to display specific columns like name and commission for all the salesmen
select Name,commission from salesman         
--------------------------
--to find the salespeople who lives in the City of 'Paris'. Return salesperson's name, city.
select name,city from salesman Where city = 'Paris' 
---------------------------------
--number of salesperson
select count(salesmanid) as noofsalespeople from salesman

---------------------------------------------------
---- to display orderlike orderdate, salesmanid, ordernumber and purchaseamount from for all the orders
create table ord(orddate date,salesmanid int,ordid int,purchamt decimal(8,2))   
insert into ord values('2012-10-05',5002,70001,150.5)
insert into ord values('2012-09-10',5005,70009,270.65)
insert into ord values('2012-10-05',5001,70002,65.26)
insert into ord values('2012-08-17',5003,70004,110.5)
insert into ord values('2012-09-10',5002,70007,948.5)
insert into ord values('2012-07-27',5001,70005,2400.6)
insert into ord values('2012-09-10',5001,70008,5760)
insert into ord values('2012-10-10',5006,70010,1983.43)
insert into ord values('2012-10-10',5003,70003,2480.4)
insert into ord values('2012-06-27',5002,70012,250.45)
insert into ord values('2012-08-17',5007,70011,75.29)
insert into ord values('2012-04-25',5001,70013,3045.6)

select *from ord
drop table ord
-----------------------------------------
-----to find the orders,salesperson of ID. 5001. Return ord_no, ord_date, purch_amt
select ordid,orddate,purchamt from ord where salesmanid=5001

---------------------------------------------
----update table for cusid
alter table ord add cusId int
update ord set cusid=3005 where ordid= 70001
update ord set cusid=3001 where ordid= 70009
update ord set cusid=3002 where ordid= 70002
update ord set cusid=3009 where ordid= 70004
update ord set cusid=3005 where ordid= 70007
update ord set cusid=3007 where ordid= 70005
update ord set cusid=3002 where ordid= 70008
update ord set cusid=3004 where ordid= 70010
update ord set cusid=3009 where ordid= 70003
update ord set cusid=3008 where ordid= 70012  
update ord set cusid=3003 where ordid= 70011
update ord set cusid=3002 where ordid= 70013

---avg puramt
select avg(purchamt) as avgpuramt from ord

-----max puramt
select cusId,max(purchamt) as maxpuramt from ord group by cusId

-------------------------------
create table customer(cusid int,cusName varchar(20),city varchar(15),grade int,salesmanid int)

insert into customer values(30002,'nick rimando','new york',100,5001)
insert into customer values(3007,'brad davis','new york',200,5001)
insert into customer values(3005,'graham zusi','california',200,5002)
insert into customer values(3008,'julian greeem','london',300,5002)
insert into customer values(3004,'fabian johnson','paris',300,5006)
insert into customer values(3009,'geoff cameron','berlin',100,5003)
insert into customer values(3003,'jozy altidor','moscow',200,5007)
insert into customer values(3001,'brad guzen','london',0,5005)
select *from customer
drop table customer
--to find those customers whose grade is 200. Return customer_id, cust_name, city, grade, salesman_id
select cusid,cusName,city,grade,salesmanid from customer where grade=200 

--count the customer
select count(cusName) as cuscount from customer
---------------
--highes grade
select city, max(grade) as highestgrade from customer group by city
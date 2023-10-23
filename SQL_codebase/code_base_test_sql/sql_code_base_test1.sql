-- Table for books
create table books (
id int primary key,
title varchar(50),
author varchar(50),
isbn varchar(50) unique,
published_date datetime
);

select * from books;

insert into books values (1, 'My first SQL book', 'Mary Parker', '981483029127', '2012-02-22 12:08:00'),
(2, 'My Second SQL book', 'John Mayer', '857300923713', '1972-07-03 09:22:00'),
(3, 'My Third SQL book', 'Cary Flint', '523120967812', '2015-10-18 14:05:44');


 --1) Write a query to fetch the details of the books written by author whose name ends with er
 select *
 from books
 where author like '%er';

 -- Table for reviews

create table reviews (
id int ,
book_id int foreign key references books(id),
reviewer_name varchar(50),
content varchar(50),
rating int,
published_date DATETIME
);

insert into reviews values
(1,1,  'John Smith','My first review',4, '2017-12-10 00:00:00'),
(2, 2,  'John Smith','My second review', 5, '2017-10-13 15:05:12'),
(3, 2,'Alice Walker','Another review', 1,  '2017-10-22 00:00:00');

select * from reviews;
select * from books;
--2)Display the Title ,Author and ReviewerName for all the books from the above table 
select b.title  , b.author , r.reviewer_name
from books b, reviews r
where r.book_id = b.id;

--3)Display the  reviewer name who reviewed more than one book.
select reviewer_name
from reviews
group by (reviewer_name)
having count (distinct book_id)>1;


create table customers (
 id int primary key,
 names varchar(40),
 age int,
 address varchar(50),
 salary DECIMAL(10, 2)
);

insert into customers values
(1, 'Ramesh', 32, 'Ahmedabad', 2000.00),
(2, 'Khilan', 25, 'Delhi', 1500.00),
(3, 'Kaushik', 23, 'Kota', 2000.00),
(4, 'Chaitali', 25, 'Mumbai', 100.00),
(5, 'Hardik', 27, 'Bhopal', 8500.00),
(6, 'Komal', 22, 'Indore', 100.00),
(7, 'Muffy', 24, 'Leeee', 100000.00);

select * from customers;
--4)Display the Name for the customer from above customer table  who live in same address which has character o anywhere in address
select names
from customers
where address like '%o%';

--create order table

create table orders (
oid int unique not null,
date datetime,
customer_id int foreign key references customers(id),
amount int not null
);

select * from orders;
select * from customers;
insert into orders values
(102 ,'2009-10-08 00:00:00',3,3000),
(100,'2009-10-08 00:00:00',3,1500),
(101 ,'2009-11-20 00:00:00',2,1560),
(103 ,'2009-10-08 00:00:00',4,2060);

--5)Write a query to display the Date,Total no of customer  placed order on same Date 
select date, count(distinct customer_id) as 'no of orders'
from orders
group by date
having count(customer_id)>1;

--create employee
create table employee (
 id int primary key,
 names varchar(40),
 age int,
 address varchar(50),
 salary DECIMAL(10, 2)
);

select * from employee;


insert into employee values
(1, 'Ramesh', 32, 'Ahmedabad', 2000.00),
(2, 'Khilan', 25, 'Delhi', 1500.00),
(3, 'Kaushik', 23, 'Kota', 2000.00),
(4, 'Chaitali', 25, 'Mumbai', 100.00),
(5, 'Hardik', 27, 'Bhopal', 8500.00),
(6, 'Komal', 22, 'mp',null),
(7, 'Muffy', 24, 'Indore',null);


--6) Display the Names of the Employee in lower case, whose salary is null 
select lower(names) 
from employee
where salary is null;
--create student 

CREATE TABLE students (
 RegisterNo int,
 Names varchar(55),
 Age int,
 Qualification varchar(55),
 MobileNo varchar(55),
 Mad_id varchar(55),
 Location varchar(55),
 gender varchar(25)
);


INSERT INTO students values
(2, 'Sai', 22, 'BE', '9952836777', 'Sai@gmai.com', 'Chennai','m'),
(3, 'Selvi', 20, 'BSC', '7890125648', 'Kumar@gmail.com', 'Madurai','m'),
(4, 'Nisha', 22, 'B. Tech', '8904567342', 'selvi@gnai.com', 'Salem','f'),
(5, 'Sai Saran', 25, 'M.E', '7834672310', 'usha@gmail.com', 'Theni','f'),
(6, 'Tom', 21, 'BCA', '7890345678', 'saran@gmai.com', 'Madurai','f');

select * from students;

update students
set Qualification ='BBA'
where RegisterNo =7;


--7)Write a sql server query to display the Gender,Total no of male and female from the above relation.
select gender , count(*) as 'no of male and female'
from students 
group by (gender);

                 

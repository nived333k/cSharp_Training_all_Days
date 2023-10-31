create table dept(
deptno int,
dname varchar(30),
dloc varchar(30),
primary key(deptno)
);

select * from dept;

create table emp(
empno int primary key,
ename varchar(40),
ejob varchar(30),
emgr_id int ,
ehire_date date not null ,
salary int not null,
comm int,
deptno int foreign key references dept(deptno)
);

select * from emp;


insert into dept values
(10, 'ACCOUNTING', 'NEW YORK'),
(20, 'RESEARCH', 'DALLAS'),
(30, 'SALES', 'CHICAGO'),
(40, 'OPERATIONS', 'BOSTON');

insert into emp values
(7369, 'SMITH', 'CLERK', 7902, '1980-12-17', 800, NULL, 20),
(7499, 'ALLEN', 'SALESMAN', 7698, '1981-02-20', 1600, 300, 30),
(7521, 'WARD', 'SALESMAN', 7698, '1981-02-22', 1250, 500, 30),
(7566, 'JONES', 'MANAGER', 7839, '1981-04-02', 2975, NULL, 20),
(7654, 'MARTIN', 'SALESMAN', 7698, '1981-09-28', 1250, 1400, 30),
(7698, 'BLAKE', 'MANAGER', 7839, '1981-05-01', 2850, NULL, 30),
(7782, 'CLARK', 'MANAGER', 7839, '1981-06-09', 2450, NULL, 10),
(7788, 'SCOTT', 'ANALYST', 7566, '1987-04-19', 3000, NULL, 20),
(7839, 'KING', 'PRESIDENT', NULL, '1981-11-17', 5000, NULL, 10),
(7844, 'TURNER', 'SALESMAN', 7698, '1981-09-08', 1500, 0, 30),
(7876, 'ADAMS', 'CLERK', 7788, '1987-05-23', 1100, NULL, 20),
(7900, 'JAMES', 'CLERK', 7698, '1981-12-03', 950, NULL, 30),
(7902, 'FORD', 'ANALYST', 7566, '1981-12-03', 3000, NULL, 20),
(7934, 'MILLER', 'CLERK', 7782, '1982-01-23', 1300, NULL, 10);


--1. List all employees whose name begins with 'A'.
select *
from emp
where ename like 'a%';
--2 Select all those employees who don't have a manager. 
select ename
from emp 
where emgr_id is null;
--3. List employee name, number and salary for those employees who earn in the range 1200 to 1400. 

select empno,ename,salary
from emp
where salary in(
select salary 
from emp 
where salary between 1200 and 1400);

--4. Give all the employees in the RESEARCH department a 10% pay rise. Verify that this has been done by listing all their details before and after the rise.
select ename , salary as 'befor rise' , e.deptno
from emp as e , dept as d
where  d.deptno =20 and e.deptno=d.deptno;
--update the pay
update emp 
set salary = salary*1.1
where deptno = 20;
--updated salaey table

select ename , salary as 'after rise',e.deptno 
from emp as e , dept as d
where d.deptno=20 and e.deptno=d.deptno;

--5)Find the number of CLERKS employed. Give it a descriptive heading. 
select count(*) as 'clerks employed'
from emp 
where ejob='clerk';
--6)Find the average salary for each job type and the number of people employed in each job. 
select ejob ,avg(salary) as 'average salary' , count(*) as 'number of employee'
from emp
group by ejob;

--7. List the employees with the lowest and highest salary. 
select ename , salary as 'max sal and min sal'
from emp 
where salary in(
select max(salary)
from emp)
union
select ename , salary 
from emp 
where salary in(
select min(salary)
from emp)

--8. List full details of departments that don't have any employees. 
select * 
from dept 
where deptno not in (select deptno from emp );

--9. Get the names and salaries of all the analysts earning more than 1200 who are based in department 20. Sort the answer by ascending order of name. 
select ename , salary 
from emp 
where ejob='analyst' and salary > 1200 and deptno = 20
order by ename asc

--10. For each department, list its name and number together with the total salary paid to employees in that department.
select d.deptno , d.dname ,sum(e.salary) as 'total salary from the dept'
from dept as d left join emp as e
on d.deptno=e.deptno 
group by d.deptno,d.dname;

-- 11.Find out salary of both MILLER and SMITH.
select ename , salary
from emp 
where ename in ('miller','smith');
--12. Find out the names of the employees whose name begin with ‘A’ or ‘M’.

select ename
from emp 
where ename like 'a%' or ename like 'm%';

--13. Compute yearly salary of SMITH. 
select ename , salary * 12 as 'yearly salary'
from emp 
where ename = 'smith'

--14. List the name and salary for all employees whose salary is not in the range of 1500 and 2850.
select ename ,salary
from emp
where salary not between 1500 and 2850;

--15. Find all managers who have more than 2 employees reporting to them
select m.ename as 'manager name' , count(e.empno) as 'no of emp'
from emp m
join emp e on m.empno = e.emgr_id
group by m.ename
having count(e.empno) > 2;

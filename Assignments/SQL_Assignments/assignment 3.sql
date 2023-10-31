select * from emp;
select * from dept;


--1. Retrieve a list of MANAGERS. 

select ename , empno
from emp
where ejob = 'manager';

--2. Find out the names and salaries of all employees earning more than 1000 per month.

select ename , salary 
from emp 
where salary > 1000;

--3. Display the names and salaries of all employees except JAMES. 

select ename , salary
from emp
where ename != 'james';

--4. Find out the details of employees whose names begin with ‘S’.
select *
from emp 
where ename like 's%';

--5. Find out the names of all employees that have ‘A’ anywhere in their name. 
select ename
from emp 
where ename like '%a%';
--6. Find out the names of all employees that have ‘L’ as their third character in their name.
select ename
from emp 
where ename like '__l%';
 -- 7. Compute daily salary of JONES. 
 select (salary/30) as 'daily salary'
 from emp 
 where ename ='jones';
 --8. Calculate the total monthly salary of all employees. 
 select sum(salary+(salary*comm)/100) as 'total salary'
 from emp
 --9. Print the average annual salary .
  select avg(salary*12) as 'average annual salary'
 from emp

 -- 10.Select the name, job, salary, department number of all employees except SALESMAN from department number 30. 
 select ename , ejob , salary , deptno
 from emp
 where ejob != 'salesman' and deptno !=30;

 --11. List unique departments of the EMP table. 
 select distinct(e.deptno) , d.dname
 from emp as e , dept as d
 where e.deptno = d.deptno;

 --12. List the name and salary of employees who earn more than 1500 and are in department 10 or 30. Label the columns Employee and Monthly Salary respectively.
 select ename as' employee' , salary as 'monthly salary'
 from  emp 
 where salary > 1500 and deptno =10 | 30;

 --13. Display the name, job, and salary of all the employees whose job is MANAGER or ANALYST and their salary is not equal to 1000, 3000, or 5000.
 select ename ,ejob, salary 
 from  emp 
 where ejob = 'manager' or ejob='analyst' and salary not in (1000,3000,5000);


 --14. Display the name, salary and commission for all employees whose commission amount is greater than their salary increased by 10%. 

 select ename , salary , comm
 from emp
 where comm>salary*0.1;

 --15. Display the name of all employees who have two L's in their name and are in department 30 or their manager is 7782. 

 select ename
 from emp 
 where ename like '%l%l%' and deptno=30 or emgr_id=7782;
 
--16. Display the names of employees with experience of over 30 years and under 40 yrs. Count the total number of employees.
 

 select  ename  
 from emp
 where DATEDIFF(year,ehire_date,getdate())>30
 and DATEDIFF(year ,ehire_date,GETDATE())<40;

--17. Retrieve the names of departments in ascending order and their employees in descending order. 
select dname, ename from dept
join emp on dept.deptno = emp.deptno
order by dname asc, ename desc;

--18. Find out experience of MILLER.
select DATEDIFF(year, ehire_date,getdate())
from emp
where ename='miller';

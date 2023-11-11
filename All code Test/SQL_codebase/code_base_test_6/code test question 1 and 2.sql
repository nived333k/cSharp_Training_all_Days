/*a. Create a table called Code_Employee(empno int primary key,
   empname varchar(35), (is a required field)
  empsal numeric(10,2) - (check empsal >=25000)
  emptype char(1) ) (either 'F' for fulltime or 'P' part time) (Empty Table)*/


create table code_employee(
empno int primary key,
empname varchar(35) not null,
empsal decimal(10,2),
emptype char(1) check(emptype in('f','p'))
);

select * from code_employee;


--b. Create a stored procedure to add new employee records. The procedure should accept all the employee details as input parameters, except empno. Generate the new employee no in the procedure and then insert the record

create proc addemployee
@empname varchar(35),
@empsal decimal(10,2),
@emptype char(1)
as
begin
declare @newempno int ;
select @newempno = ISNULL(max(empno),0)+1 from code_employee;

insert into code_employee(empno , empname , empsal,emptype)
values(@newempno,@empname,@empsal,@emptype)
end





--II. Write a Cursor program, that retrieves all the employees and updates salary for all employees of Department 10(Accounting) by 15%

select * from emp;

-- Declare the cursor
DECLARE emp_cursor CURSOR FOR
SELECT empno, salary
FROM emp
WHERE deptno = 10;

OPEN emp_cursor;

BEGIN TRANSACTION;

FETCH NEXT FROM emp_cursor;

WHILE @@FETCH_STATUS = 0
BEGIN
-- Update the salary with a 15% increase
    UPDATE emp
    SET salary = salary * 1.15
    WHERE CURRENT OF emp_cursor;
	FETCH NEXT FROM emp_cursor;
	end

COMMIT TRANSACTION;
CLOSE emp_cursor;
DEALLOCATE emp_cursor;
SELECT * FROM emp WHERE deptno = 10;

--lets create client table
create table clients(
client_id int primary key,
cname varchar(40) NOT NULL,
caddress varchar(40),
cemail varchar(30) unique,
cphone int ,
cbusiness varchar NOT NULL
);

-- Insert data into client table

alter table clients
alter column cbusiness varchar(20);

insert into clients values 
(1001, 'ACME Utilities', 'Noida', 'contact@acmeutil.com', '9567880032', 'Manufacturing'),
(1002, 'Trackon Consultants', 'Mumbai', 'consult@trackon.com', '8734210090', 'Consultant'),
(1003, 'MoneySaver Distributors', 'Kolkata', 'save@moneysaver.com', '7799886655', 'Reseller'),
(1004, 'Lawful Corp', 'Chennai', 'justice@lawful.com', '9210342219', 'Professional');

-- To display the client 
select * from clients;

-- Lets create the department table
CREATE TABLE Departments (
    Deptno int  PRIMARY KEY,
    Dname varchar(30) NOT NULL,
    Loc varchar(30)
);
select * from Departments;

-- add value to dept

insert into Departments values
    (10, 'Design', 'Pune'),
    (20, 'Development', 'Pune'),
    (30, 'Testing', 'Mumbai'),
    (40, 'Document', 'Mumbai');

	--create employee tables
	CREATE TABLE Employees (
    Empno int  PRIMARY KEY,
    Ename varchar(30) NOT NULL,
    Job varchar(30),
    Salary  int  ,
    Deptno int ,
    FOREIGN KEY (Deptno) REFERENCES Departments(Deptno),
	CHECK (Salary > 0)
);
select * from Employees;

-- insert values into employee table
insert into Employees values 
(7001, 'Sandeep', 'Analyst', 25000, 10),
(7002, 'Rajesh', 'Designer', 30000, 10),
(7003, 'Madhav', 'Developer', 40000, 20),
(7004, 'Manoj', 'Developer', 40000, 20),
(7005, 'Abhay', 'Designer', 35000, 10),
(7006, 'Uma', 'Tester', 30000, 30),
(7007, 'Gita', 'Tech. Writer', 30000, 40),
(7008, 'Priya', 'Tester', 35000, 30),
(7009, 'Nutan', 'Developer', 45000, 20),
(7010, 'Smita', 'Analyst', 20000, 10),
(7011, 'Anand', 'Project Mgr', 65000, 10);

--Lets create project table
CREATE TABLE Projects (
    Project_ID int PRIMARY KEY,
    Descr varchar(30) NOT NULL,
    Start_Dates DATE,
    Planned_End_Date DATE,
    Actual_End_date DATE ,CHECK (Actual_End_date > Planned_End_Date),
    Budget int CHECK (Budget > 0),
    Client_ID int,
    FOREIGN KEY (Client_ID) REFERENCES Clients(Client_ID)
);

select * from Projects;

-- lets add date to projects table
insert into Projects values 
(401, 'Inventory', '01-Apr-11', '01-Oct-11', '31-Oct-11', 150000, 1001),
(402, 'Accounting', '01-Aug-11', '01-Jan-12', NULL, 500000, 1002),
(403, 'Payroll', '01-Oct-11', '31-Dec-11', NULL, 75000, 1003),
(404, 'Contact Mgmt', '01-Nov-11', '31-Dec-11', NULL, 50000, 1004);



--create empProjectstask table
CREATE TABLE EmpProjectTasks (
    Project_ID int,
    Empno int,
    Start_Dates DATE,
    End_Date DATE,
    Task varchar(30) NOT NULL,
    Status varchar(30) NOT NULL,
    PRIMARY KEY (Project_ID, Empno),
    FOREIGN KEY (Project_ID) REFERENCES Projects(Project_ID),
    FOREIGN KEY (Empno) REFERENCES Employees(Empno)
);
select * from EmpProjectTasks;
--insert values into empprojecttask
insert into EmpProjectTasks values
(401, 7001, '01-Apr-11', '20-Apr-11', 'System Analysis', 'Completed'),
(401, 7002, '21-Apr-11', '30-May-11', 'System Design', 'Completed'),
(401, 7003, '01-Jun-11', '15-Jul-11', 'Coding', 'Completed'),
(401, 7004, '18-Jul-11', '01-Sep-11', 'Coding', 'Completed'),
(401, 7006, '03-Sep-11', '15-Sep-11', 'Testing', 'Completed'),
(401, 7009, '18-Sep-11', '05-Oct-11', 'Code Change', 'Completed'),
(401, 7008, '06-Oct-11', '16-Oct-11', 'Testing', 'Completed'),
(401, 7007, '06-Oct-11', '22-Oct-11', 'Documentation', 'Completed'),
(401, 7011, '22-Oct-11', '31-Oct-11', 'Sign off', 'Completed'),
(402, 7010, '01-Aug-11', '20-Aug-11', 'System Analysis', 'Completed'),
(402, 7002, '22-Aug-11', '30-Sep-11', 'System Design', 'Completed'),
(402, 7004, '01-Oct-11', NULL, 'Coding', 'In Progress');
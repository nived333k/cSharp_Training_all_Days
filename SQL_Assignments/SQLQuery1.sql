create database normalization;
use normalization;

-- first normal form
create table first_normal_form(
c_number varchar(50),
c_name varchar(50),
propertyNo varchar(50),
p_address varchar(50),
rent_start date,
rent_finish date,
rent int,
owner_no varchar(50),
ownerName varchar(50)
);

insert into first_normal_form
values
('CR76','John Kay','PG4','6 Lawrence','2000-07-09','2001-09-09',350,'CO40','tina murphy'),
('CR76','John Kay','PG16','5 novar dr glass grow','2001-09-02','2001-09-02',450,'CO93','tony shaw'),
('CR56','Aline stewart','PG4','6 Lawrence','1999-09-01','2000-09-01',350,'CO40','tina murphy '),
('CR56','Aline stewart','PG36','2 manor rd, glass gow','2000-10-10','2001-12-01',370,'CO93','tony shaw'),
('CR56','Aline stewart','PG16','5 novar dr glass grow','2002-11-01','2003-08-01',450,'CO93','tony shaw');

select * from first_normal_form;

-- second normal form
-- client table
create table clients(
client_no nvarchar(40) primary key,
client_name varchar(50) 
);

insert into clients values
('CR76','John kay'),
('CR56','Aline stewart');
-- properties table
create table propertie (
propertyNo varchar(25) primary key,
p_address varchar(25),
owner_no VARCHAR(25),
ownerName VARCHAR(25)
);
 

insert into propertie values
('PG4' , '6 Lawrence','CO40','tina Murphy'),
('PG16' , '5 novar dr glass grow','CO93','tony shaw'),
('PG36' , '2 Manor glass grow','CO93','tony shaw');

select * from propertie;

--client renting in second normal form
CREATE TABLE second_normal_form (
c_number nvarchar(40) foreign key references clients(client_no),
propertyNo VARCHAR(25) foreign key references propertie(propertyNo),
rent_start DATE,
rent_finish DATE,
rent INT,
primary key(c_number,propertyNo)
);

insert into second_normal_form
values
('CR76', 'PG4', '2003-07-09', '2001-09-01', 350),
('CR76', 'PG16', '2001-09-02', '2001-09-02', 450),
('CR56', 'PG4', '1999-09-01', '2000-09-01', 350),
('CR56', 'PG36', '2000-10-10', '2001-12-01', 370),
('CR56', 'PG16', '2002-11-01', '2003-08-01', 450);

select * from second_normal_form;

--Third normal form

 -- Clients table
create table  client_3nf (
client_number varchar(50) PRIMARY KEY,
client_name varchar(50)
);

insert into client_3nf values
('CR76', 'John Kay'),
('CR56', 'Aline Stewart');

select * from client_3nf;

--Properties table
create table propertie_3nf (
  property_number varchar(50) primary key,
  p_address varchar(50),
  owner_no varchar(50)
);
-- Insert data into the properties table
insert into propertie_3nf values
('PG4', '6 Lawrence', 'CO40'),
('PG16', '5 Novar Dr Glass Grow', 'CO93'),
('PG36', '2 Manor Rd, Glass Gow', 'CO93');

select * from propertie_3nf;

-- Rentals table
CREATE TABLE rentals_3nf (
  
  client_number varchar(50) REFERENCES client_3nf(client_number),
  property_number varchar(50) REFERENCES propertie_3nf(property_number),
  rent_start date,
  rent_finish date,
  rent int,
  primary key(client_number,property_number)
);

insert into rentals_3nf values
('CR76', 'PG4', '2003-07-09', '2001-09-01', 350),
('CR76', 'PG16', '2001-09-02', '2001-09-02', 450),
('CR56', 'PG4', '1999-09-01', '2000-09-01', 350),
('CR56', 'PG36', '2000-10-10', '2001-12-01', 370),
('CR56', 'PG16', '2002-11-01', '2003-08-01', 450);

select * from rentals_3nf;

-- Property Owners table
create table property_owners_3nf (
owner_no varchar(50) PRIMARY KEY,
owner_name varchar(50)
);

-- Insert data into the property_owners table
insert into  property_owners_3nf values
('CO40', 'Tina Murphy'),
('CO93', 'Tony Shaw');
select * from property_owners_3nf;





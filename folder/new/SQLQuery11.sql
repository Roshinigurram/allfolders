CREATE TABLE DECEMP
(
     autoid int  not null identity(1,1),
	 empid int  not null primary key,
	 empname varchar(50) ,
	 empslaray  money,
	 emplocation varchar(50),
	 empfirstname nvarchar(100)
);

CREATE TABLE Decdep
(
   depid int not null primary key ,
   empid int not null ,
   deploc varchar(100),
   depname varchar(70),
    Foreign key (empid) REFERENCES DECEMP(empid)

);

insert into DECEMP values(1,'abac',300000,'hyderabad','hq')
insert into DECEMP values(2,'bac',3500000,'nellore','h')
insert into DECEMP values(3,'aac',304000,'guntur','c')
insert into DECEMP values(4,'abc',300000,'hyderabad','d')
insert into DECEMP values(5,'aacy',800000,'hyderabad','e')
insert into DECEMP values(6,'bac',70000,'warangal','f')
insert into DECEMP values(7,'ac',30000,'nellore','g')
insert into DECEMP values(8,'ac',40000,'hyderabad','hh')
insert into DECEMP values(9,'c',300,'tirupati','hh')

insert into Decdep values(1,1,'hyderabad','arts')
insert into Decdep values(2,2,'hyderabad','science')
insert into Decdep values(3,4,'hyderabad','computer')
insert into Decdep values(5,5,'hyderabad','maths')
insert into Decdep values(6,6,'hyderabad','arts')
insert into Decdep values(7,7,'hyderabad','social')
insert into Decdep values(8,8,'hyderabad','arts')
insert into Decdep values(9,9,'hyderabad','economy')

select* from DECEMP
select * from Decdep


CREATE NONCLUSTERED INDEX empfirstname
ON DECEMP ([empfirstname] ASC)


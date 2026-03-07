use DATABASE Insurancedb;

create table address_details(address_id int primary key,h_no varchar(6),city varchar(50),
addressline1 varchar(50),state varchar(50),pin varchar(50));



create table user_details(user_id int primary key,firstname varchar(50),lastname varchar(50),
email varchar(50),mobileno varchar(50),address_id int references address_details(address_id),
dob date);


create table ref_policy_types(policy_type_code varchar(10) primary key,
policy_type_name varchar(50));

CREATE TABLE policy_sub_types
(
    policy_type_id VARCHAR(10) PRIMARY KEY,
    
    policy_type_code VARCHAR(10),
    
    description VARCHAR(50),
    
    yearsofpayements INT,
    
    amount DECIMAL(12,2),
    
    maturityperiod INT,
    
    maturityamount DECIMAL(12,2),
    
    validity INT,
    
    CONSTRAINT FK_policy_type
        FOREIGN KEY (policy_type_code)
        REFERENCES ref_policy_types(policy_type_code)
);


create table user_policies(policy_no varchar(20) primary key,
user_id int references user_details(user_id),date_registered date,
policy_type_id varchar(10) references policy_sub_types(policy_type_id) );


CREATE TABLE policy_payments
(
    receipno INT PRIMARY KEY,
    
    user_id INT,
    
    policy_no VARCHAR(20),
    
    dateofpayment DATE,
    
    amount DECIMAL(12,2),
    
    fine DECIMAL(12,2),
    
    CONSTRAINT FK_payment_user
        FOREIGN KEY (user_id)
        REFERENCES user_details(user_id),
    
    CONSTRAINT FK_payment_policy
        FOREIGN KEY (policy_no)
        REFERENCES user_policies(policy_no)
);


insert into address_details values(1,'6-21','hyderabad','kphb','andhrapradesh',1254);
insert into address_details values(2,'7-81','chennai','seruseri','tamilnadu',16354);
insert into address_details values(3,'3-71','lucknow','street','uttarpradesh',86451);
insert into address_details values(4,'4-81','mumbai','iroli','maharashtra',51246);
insert into address_details values(5,'5-81','bangalore','mgroad','karnataka',125465);
insert into address_details values(6,'6-81','ahamadabad','street2','gujarat',125423);
insert into address_details values(7,'9-21','chennai','sholinganur','tamilnadu',654286);

select*from address_details;

insert into user_details values(1111,'raju','reddy','raju@gmail.com','9854261456',4,'1986-4-11');

INSERT INTO user_details
VALUES
(2223, 'vamsi', 'krishna', 'vamsi@gmail.com', '9854261463', 1, '1990-04-11');

insert into user_details values(3333,'naveen','reddy','naveen@gmail.com','9854261496',4,'1985-3-14');

insert into user_details values(4444,'raghava','rao','raghava@gmail.com','9854261412',4,'1985-9-21');

insert into user_details values(5555,'harsha','vardhan','harsha@gmail.com','9854261445',4,'1992-10-11');



insert into ref_policy_types values('58934','car');

insert into ref_policy_types values('58539','home');

insert into ref_policy_types values('58683','life');

insert into policy_sub_types values('6893','58934','theft',1,5000,null,200000,1);
insert into policy_sub_types values('6894','58934','accident',1,20000,null,200000,3);

insert into policy_sub_types values('6895','58539','fire',1,50000,null,500000,3);

insert into policy_sub_types values('6896','58683','anandhlife',7,50000,15,1500000,null);

insert into policy_sub_types values('6897','58683','sukhlife',10,5000,13,300000,null);


insert into policy_payments values(121,4444,'689420','2012-4-09',50000,null);
insert into policy_payments values(345,4444,'689420','2013-4-09',50000,null);
insert into policy_payments values(300,1111,'689317','2012-6-20',20000,null);
insert into policy_payments values(225,1111,'689316','2012-5-18',20000,null);
insert into policy_payments values(227,1111,'689314','1994-4-18',50000,null);
insert into policy_payments values(100,1111,'689314','1995-4-10',50000,null);

insert into policy_payments values(128,1111,'689314','1996-4-11',50000,null);
insert into policy_payments values(96,1111,'689314','1997-4-18',50000,200);
insert into policy_payments values(101,1111,'689314','1998-4-09',50000,null);
insert into policy_payments values(105,1111,'689314','1999-4-08',50000,null);
insert into policy_payments values(120,1111,'689314','2000-4-05',50000,null);
insert into policy_payments values(367,2222,'689318','2012-6-21',20000,null);
insert into policy_payments values(298,3333,'689320','2012-6-18',20000,null);


SELECT DISTINCT user_id
FROM policy_payments
WHERE user_id NOT IN (SELECT user_id FROM user_details);

SELECT pst.policy_type_id,
       rpt.policy_type_name,
       pst.description
FROM policy_sub_types pst
JOIN ref_policy_types rpt
     ON pst.policy_type_code = rpt.policy_type_code
WHERE rpt.policy_type_name = 'Car';


SELECT pst.policy_type_id,
       rpt.policy_type_name,
       pst.description
FROM policy_sub_types pst
JOIN ref_policy_types rpt
     ON pst.policy_type_code = rpt.policy_type_code
JOIN user_policies up
     ON pst.policy_type_id = up.policy_type_id
WHERE rpt.policy_type_name = 'Car';


SELECT * FROM INFORMATION_SCHEMA.COLUMNS
WHERE TABLE_NAME = 'user_policies';


SELECT pst.policy_type_id,
       rpt.policy_type_name,
       pst.description
FROM policy_sub_types pst
JOIN ref_policy_types rpt
     ON pst.policy_type_code = rpt.policy_type_code
JOIN user_policies up
     ON pst.policy_type_id = up.policy_type_id
WHERE rpt.policy_type_name = 'Car';


SELECT DISTINCT
       u.user_id,
       u.firstname + ' ' + u.lastname AS USER_NAME,
       u.email,
       u.mobileno
FROM user_details u
JOIN user_policies up 
     ON u.user_id = up.user_id
JOIN policy_sub_types pst 
     ON up.policy_type_id = pst.policy_type_id
JOIN ref_policy_types rpt 
     ON pst.policy_type_code = rpt.policy_type_code
WHERE rpt.policy_type_name = 'Car';



SELECT DISTINCT 
       u.user_id,
       u.firstname,
       u.lastname
FROM user_details u
JOIN user_policies up 
     ON u.user_id = up.user_id
JOIN policy_sub_types pst 
     ON up.policy_type_id = pst.policy_type_id
JOIN ref_policy_types rpt 
     ON pst.policy_type_code = rpt.policy_type_code
WHERE rpt.policy_type_name = 'Car'
AND u.user_id NOT IN
(
    SELECT u2.user_id
    FROM user_details u2
    JOIN user_policies up2 
         ON u2.user_id = up2.user_id
    JOIN policy_sub_types pst2 
         ON up2.policy_type_id = pst2.policy_type_id
    JOIN ref_policy_types rpt2 
         ON pst2.policy_type_code = rpt2.policy_type_code
    WHERE rpt2.policy_type_name = 'Home'
);

ALTER DATABASE [Handson-Queries] SET SINGLE_USER WITH ROLLBACK IMMEDIATE;

ALTER DATABASE [Handson-Queries] MODIFY NAME = Insurancedb;

ALTER DATABASE Insurancedb SET MULTI_USER;
GO
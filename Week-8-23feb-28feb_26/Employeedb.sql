use EmployeeDB;

SET ANSI_NULLS ON
go

set quoted_identifier on
go

create table[dbo].[Address](
[AddressID][int] IDENTITY (1,1) NOT NULL,
[Street][varchar](255) NULL,
[City][varchar] (100) NULL,
[State][varchar](100) NULL,
[postalCode][varchar](20) NULL,

Primary key CLUSTERED(
[AddressID] asc
)
);
create table[dbo].[Employee](
[EmployeeID][int] IDENTITY (1,1) NOT NULL,
[FirstName][varchar](100) NULL,
[LatName][varchar] (100) NULL,
[Email][varchar](100) NULL,
[AddressID][int] NULL,

Primary key CLUSTERED(
[EmployeeID] asc
)
)ON [PRIMARY];
GO

SELECT TOP(1000)[AddressID]
 ,[Street]
 ,[City]
 ,[State]
 ,[postalCode]
 from[EmployeeDB].[dbo].[Address]

INSERT INTO [EmployeeDB].[dbo].[Address]
([Street], [City], [State], [postalCode])
VALUES
('Park Street', 'Kolkata', 'West Bengal', '700016'),

('Salt Lake Sector V', 'Kolkata', 'West Bengal', '700091'),

('Anna Salai', 'Chennai', 'Tamil Nadu', '600002');


SELECT TOP(1000)[EmployeeID]
 ,[FirstName]
 ,[LatName]
 ,[Email]
 ,[AddressID]
 from[EmployeeDB].[dbo].[Employee]

INSERT INTO [EmployeeDB].[dbo].[Employee]
([FirstName], [LatName], [Email], [AddressID])
VALUES
('Rahul', 'Sharma', 'rahul.sharma@gmail.com', 1),

('Priya', 'Verma', 'priya.verma@gmail.com', 2),

('Amit', 'Kumar', 'amit.kumar@gmail.com', 3);

SELECT * 
FROM [EmployeeDB].[dbo].[Employee];

SELECT *
FROM [EmployeeDB].[dbo].[Address];


USE EmployeeDB
GO

DROP TABLE IF EXISTS Address
DROP TABLE IF EXISTS Employee
GO

CREATE TABLE [dbo].[Address](
    [AddressID] INT IDENTITY(1,1) NOT NULL,
    [Street] VARCHAR(255) NULL,
    [City] VARCHAR(100) NULL,
    [State] VARCHAR(100) NULL,
    [PostalCode] VARCHAR(20) NULL,
    PRIMARY KEY CLUSTERED ([AddressID] ASC)
)

CREATE TABLE [dbo].[Employee](
    [EmployeeID] INT IDENTITY(1,1) NOT NULL,
    [FirstName] VARCHAR(100) NULL,
    [LastName] VARCHAR(100) NULL,
    [Email] VARCHAR(100) NULL,
    [AddressID] INT NULL,
    PRIMARY KEY CLUSTERED ([EmployeeID] ASC)
)


USE EmployeeDB
GO

DROP TABLE IF EXISTS Employee
DROP TABLE IF EXISTS Address
GO

CREATE TABLE Address(
    AddressID INT IDENTITY(1,1) PRIMARY KEY,
    Street VARCHAR(255),
    City VARCHAR(100),
    State VARCHAR(100),
    PostalCode VARCHAR(20)
)

CREATE TABLE Employee(
    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
    FirstName VARCHAR(100),
    LastName VARCHAR(100),
    Email VARCHAR(100),
    AddressID INT
)


USE EmployeeDB
GO

INSERT INTO Address (Street, City, State, PostalCode)
VALUES
('Park Street','Kolkata','West Bengal','700016'),
('Salt Lake Sector V','Kolkata','West Bengal','700091'),
('Anna Salai','Chennai','Tamil Nadu','600002');

INSERT INTO Employee (FirstName, LastName, Email, AddressID)
VALUES
('Rahul','Sharma','rahul.sharma@gmail.com',1),
('Priya','Verma','priya.verma@gmail.com',2),
('Amit','Kumar','amit.kumar@gmail.com',3);

SELECT * FROM Employee;
SELECT * FROM Address;
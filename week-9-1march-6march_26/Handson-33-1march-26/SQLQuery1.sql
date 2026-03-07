CREATE DATABASE CompanyDB;
GO

USE CompanyDB;
GO


---Department Table
CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY IDENTITY(1,1),
    DepartmentName NVARCHAR(100) NOT NULL
);

---Employee Table---
CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY IDENTITY(1,1),
    Name NVARCHAR(100) NOT NULL,
    Email NVARCHAR(100) NOT NULL,
    DepartmentID INT,
    Salary DECIMAL(10,2),
    FOREIGN KEY (DepartmentID)
        REFERENCES Departments(DepartmentID)
);

----Project Table(child emolpyee)--
CREATE TABLE Projects (
    ProjectID INT PRIMARY KEY IDENTITY(1,1),
    ProjectName NVARCHAR(100) NOT NULL,
    EmployeeID INT,
    FOREIGN KEY (EmployeeID)
        REFERENCES Employees(EmployeeID)
);

INSERT INTO Departments (DepartmentName)
VALUES ('HR'), ('IT'), ('Finance');


INSERT INTO Employees (Name, Email, DepartmentID, Salary)
VALUES 
('Alice', 'alice@example.com', 1, 50000),
('Bob', 'bob@example.com', 2, 60000),
('Charlie', 'charlie@example.com', 3, 55000);


INSERT INTO Projects (ProjectName, EmployeeID)
VALUES 
('Website Redesign', 2),
('Payroll System', 3);



SELECT * FROM Departments;
SELECT * FROM Employees;
SELECT * FROM Projects;



---stroed procedure----
go
CREATE PROCEDURE AddEmployee
    @Name NVARCHAR(100),
    @Email NVARCHAR(100),
    @DepartmentID INT,
    @Salary DECIMAL(10,2)
AS
BEGIN
    INSERT INTO Employees (Name, Email, DepartmentID, Salary)
    VALUES (@Name, @Email, @DepartmentID, @Salary);
END;


go
CREATE PROCEDURE GetEmployees
AS
BEGIN
    SELECT E.EmployeeID, E.Name, E.Email,
           D.DepartmentName, E.Salary
    FROM Employees E
    JOIN Departments D
        ON E.DepartmentID = D.DepartmentID;
END;


---update Employee---
go
CREATE PROCEDURE UpdateEmployee
    @EmployeeID INT,
    @Name NVARCHAR(100),
    @Email NVARCHAR(100),
    @DepartmentID INT,
    @Salary DECIMAL(10,2)
AS
BEGIN
    UPDATE Employees
    SET Name = @Name,
        Email = @Email,
        DepartmentID = @DepartmentID,
        Salary = @Salary
    WHERE EmployeeID = @EmployeeID;
END;

---DElete Employee----

go
CREATE PROCEDURE DeleteEmployee
    @EmployeeID INT
AS
BEGIN
    DELETE FROM Employees
    WHERE EmployeeID = @EmployeeID;
END;

----search employee--
go
CREATE PROCEDURE SearchEmployee
    @Keyword NVARCHAR(100)
AS
BEGIN
    SELECT *
    FROM Employees
    WHERE Name LIKE '%' + @Keyword + '%'
       OR Email LIKE '%' + @Keyword + '%';
END;

EXEC GetEmployees;
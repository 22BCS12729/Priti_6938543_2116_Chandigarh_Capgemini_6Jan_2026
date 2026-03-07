USE FunctionStoredProceduredb;
GO

-- Drop function if already exists
IF OBJECT_ID('dbo.SumTwoNumbers') IS NOT NULL
    DROP FUNCTION dbo.SumTwoNumbers;
GO

-- Scalar function - Add two numbers
CREATE FUNCTION dbo.SumTwoNumbers()
RETURNS INT
AS
BEGIN
    DECLARE @A INT = 10,
            @B INT = 20;

    RETURN @A + @B;
END;
GO

-- Call the function
SELECT dbo.SumTwoNumbers() AS Result;

----Function to Generate New Department Number

CREATE FUNCTION dbo.NewDno()
RETURNS INT
AS
BEGIN
    DECLARE @NDno INT;

    -- If no rows, return 10
    SELECT @NDno = ISNULL(MAX(deptno), 0) + 10
    FROM dept;

    RETURN @NDno;
END;

-- Function to add three numbers
-- Drop function if already exists
IF OBJECT_ID('dbo.Total') IS NOT NULL
    DROP FUNCTION dbo.Total;
GO

-- Function to add three numbers
CREATE FUNCTION dbo.Total
(
    @A INT,
    @B INT,
    @C INT
)
RETURNS INT
AS
BEGIN
    RETURN @A + @B + @C;
END;
GO

-- Call the function
SELECT dbo.Total(3,5,4) AS Result;


-- Procedure to add up to 5 numbers
CREATE PROCEDURE dbo.MySum
    @A INT,
    @B INT,
    @C INT = 0,
    @D INT = 0,
    @E INT = 0
AS
BEGIN
    PRINT @A + @B + @C + @D + @E;
END;

-- Execute procedure
EXEC MySum 10,20;
EXEC MySum 10,20,30;
EXEC MySum 10,20,30,40;
EXEC MySum 10,20,30,40,50;

-- Drop if already exists
IF OBJECT_ID('dbo.Multiply') IS NOT NULL
    DROP FUNCTION dbo.Multiply;
GO

-- Create function
CREATE FUNCTION dbo.Multiply
(
    @Num1 INT,
    @Num2 INT
)
RETURNS INT
AS
BEGIN
    RETURN @Num1 * @Num2;
END;
GO

-- Call function
SELECT dbo.Multiply(3,4) AS MultiplyResult;



-- Procedure that calls Multiply function
CREATE PROCEDURE dbo.CallingFunc
(
    @FirstNum INT,
    @SecNum INT
)
AS
BEGIN
    DECLARE @Result INT;

    SET @Result = dbo.Multiply(@FirstNum, @SecNum);

    PRINT @Result;
END;

EXEC CallingFunc 3,4;

USE KK;
GO

-- Create table
CREATE TABLE Employee
(
    EmpID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Salary INT,
    Address VARCHAR(100)
);
GO

-- Insert records
INSERT INTO Employee VALUES (1,'Mohan','Chauhan',22000,'Delhi');
INSERT INTO Employee VALUES (2,'Asif','Khan',15000,'Delhi');
GO

-- Now create function (must be new batch)
CREATE FUNCTION dbo.fnGetEmpFullName
(
    @FirstName VARCHAR(50),
    @LastName VARCHAR(50)
)
RETURNS VARCHAR(101)
AS
BEGIN
    RETURN @FirstName + ' ' + @LastName;
END;
GO


-- If already exists, drop it
IF OBJECT_ID('dbo.fnGetEmployee') IS NOT NULL
    DROP FUNCTION dbo.fnGetEmployee;
GO

-- Inline Table-Valued Function
CREATE FUNCTION dbo.fnGetEmployee()
RETURNS TABLE
AS
RETURN
(
    SELECT * FROM Employee
);
GO

-- Call function
SELECT * FROM dbo.fnGetEmployee();



-- Drop function if already exists
IF OBJECT_ID('dbo.fnGetMulEmployee') IS NOT NULL
    DROP FUNCTION dbo.fnGetMulEmployee;
GO

-- Multi-statement Table-Valued Function
CREATE FUNCTION dbo.fnGetMulEmployee()
RETURNS @Emp TABLE
(
    EmpID INT,
    FirstName VARCHAR(50),
    Salary INT
)
AS
BEGIN

    -- Insert data into table variable
    INSERT INTO @Emp
    SELECT EmpID, FirstName, Salary
    FROM Employee;

    -- Update only table variable (not original table)
    UPDATE @Emp
    SET Salary = 25000
    WHERE EmpID = 1;

    RETURN;
END;
GO

-- Call the function
SELECT * FROM dbo.fnGetMulEmployee();


-- Swap two numbers using OUTPUT parameters
CREATE PROCEDURE dbo.Swap
    @X INT OUTPUT,
    @Y INT OUTPUT
AS
BEGIN
    DECLARE @Temp INT;

    SET @Temp = @X;
    SET @X = @Y;
    SET @Y = @Temp;
END;

-- Execute swap
DECLARE @A INT = 20,
        @B INT = 10;

EXEC Swap @A OUTPUT, @B OUTPUT;

PRINT 'After Swap A = ' + CAST(@A AS VARCHAR) + 
      ' B = ' + CAST(@B AS VARCHAR);




      -- Create table
CREATE TABLE dbo.EmployeeCursor
(
    EmpID INT PRIMARY KEY,
    EmpName VARCHAR(50) NOT NULL,
    Salary INT NOT NULL,
    Address VARCHAR(200) NOT NULL
);

-- Insert records
INSERT INTO dbo.EmployeeCursor (EmpID,EmpName,Salary,Address)
VALUES (1,'Mohan',12000,'Noida');

INSERT INTO dbo.EmployeeCursor (EmpID,EmpName,Salary,Address)
VALUES (2,'Pavan',25000,'Delhi');

INSERT INTO dbo.EmployeeCursor (EmpID,EmpName,Salary,Address)
VALUES (3,'Amit',22000,'Dehradun');

INSERT INTO dbo.EmployeeCursor (EmpID,EmpName,Salary,Address)
VALUES (4,'Sonu',22000,'Noida');

INSERT INTO dbo.EmployeeCursor (EmpID,EmpName,Salary,Address)
VALUES (5,'Deepak',28000,'Gurgaon');

-- View data
SELECT * FROM dbo.EmployeeCursor;



---Correct static cursor code----


-- Static Cursor Example
SET NOCOUNT ON;

DECLARE @Id INT,
        @Name VARCHAR(50),
        @Salary INT;

-- Declare Static Cursor
SET NOCOUNT ON;

-- Declare variables FIRST
DECLARE @Id INT,
        @Name VARCHAR(50),
        @Salary INT;

-- Declare cursor
DECLARE cur_emp CURSOR STATIC
FOR
SELECT EmpID, EmpName, Salary
FROM dbo.EmployeeCursor;

-- Open cursor
OPEN cur_emp;

-- Fetch first row
FETCH NEXT FROM cur_emp INTO @Id, @Name, @Salary;

-- Loop
WHILE @@FETCH_STATUS = 0
BEGIN
    PRINT 'ID : ' + CONVERT(VARCHAR(20), @Id) +
          ', Name : ' + @Name +
          ', Salary : ' + CONVERT(VARCHAR(20), @Salary);

    FETCH NEXT FROM cur_emp INTO @Id, @Name, @Salary;
END;

-- Close and deallocate
CLOSE cur_emp;
DEALLOCATE cur_emp;

SET NOCOUNT OFF;
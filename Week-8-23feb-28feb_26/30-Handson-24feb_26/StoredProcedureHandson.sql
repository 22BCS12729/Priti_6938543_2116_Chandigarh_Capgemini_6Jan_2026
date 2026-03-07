--Create Tables-----



---Customer Table

CREATE TABLE Customers
(
    CustomerID INT PRIMARY KEY,
    Name VARCHAR(100),
    Email VARCHAR(100)
);

----Departments----
CREATE TABLE Departments
(
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100)
);


-----Employees---
CREATE TABLE Employees
(
    EmployeeID INT PRIMARY KEY,
    Name VARCHAR(100),
    DepartmentID INT,
    FOREIGN KEY (DepartmentID) REFERENCES Departments(DepartmentID)
);

----Orders table
CREATE TABLE Orders
(
    OrderID INT PRIMARY KEY,
    CustomerID INT,
    EmployeeID INT,
    OrderDate DATE,
    TotalAmount DECIMAL(18,2),
    FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID),
    FOREIGN KEY (EmployeeID) REFERENCES Employees(EmployeeID)
);

------OrderDetails----
CREATE TABLE OrderDetails
(
    OrderDetailID INT PRIMARY KEY,
    OrderID INT,
    ProductID INT,
    Quantity INT,
    Price DECIMAL(18,2),
    FOREIGN KEY (OrderID) REFERENCES Orders(OrderID)
);


---INSERT SAMPLE DATA----
-- Customers
INSERT INTO Customers VALUES
(101, 'Alice', 'alice@gmail.com'),
(102, 'Bob', 'bob@gmail.com');


-- Departments
INSERT INTO Departments VALUES
(1, 'HR'),
(2, 'Sales');

-- Employees
INSERT INTO Employees VALUES
(1, 'John', 2),
(2, 'David', 2),
(3, 'Emma', 1);

-- Orders
INSERT INTO Orders VALUES
(1001, 101, 1, '2025-01-10', 500),
(1002, 101, 2, '2025-02-15', 800),
(1003, 102, 1, '2025-03-05', 300);

-- OrderDetails
INSERT INTO OrderDetails VALUES
(1, 1001, 1, 2, 200),
(2, 1001, 2, 1, 100),
(3, 1002, 1, 4, 200),
(4, 1003, 3, 3, 100);



------EXERCISE 1---
GO

CREATE PROCEDURE GetCustomerOrderSummary
    @CustomerID INT
AS
BEGIN
    SELECT 
        c.Name,
        o.OrderID,
        o.OrderDate,
        SUM(od.Quantity * od.Price) AS OrderTotal
    FROM Customers c
    JOIN Orders o ON c.CustomerID = o.CustomerID
    JOIN OrderDetails od ON o.OrderID = od.OrderID
    WHERE c.CustomerID = @CustomerID
    GROUP BY c.Name, o.OrderID, o.OrderDate
END

---TEST---
EXEC GetCustomerOrderSummary @CustomerID = 101;


------------EXERCISE 2
GO
CREATE PROCEDURE GetEmployeeSalesReport
    @DepartmentID INT,
    @StartDate DATE,
    @EndDate DATE
AS
BEGIN
    SELECT 
        e.EmployeeID,
        e.Name,
        SUM(o.TotalAmount) AS TotalSales
    FROM Employees e
    JOIN Orders o ON e.EmployeeID = o.EmployeeID
    WHERE e.DepartmentID = @DepartmentID
      AND o.OrderDate BETWEEN @StartDate AND @EndDate
    GROUP BY e.EmployeeID, e.Name
END

---TEST---
EXEC GetEmployeeSalesReport 
    @DepartmentID = 2, 
    @StartDate = '2025-01-01', 
    @EndDate = '2025-12-31';


    -----EXERCISE-3---
    GO
    CREATE PROCEDURE GetCustomerOrderCount
    @CustomerID INT,
    @OrderCount INT OUTPUT
AS
BEGIN
    SELECT @OrderCount = COUNT(*)
    FROM Orders
    WHERE CustomerID = @CustomerID
END


---TEST--
DECLARE @Count INT;

EXEC GetCustomerOrderCount 
    @CustomerID = 101, 
    @OrderCount = @Count OUTPUT;

PRINT 'Total Orders: ' + CAST(@Count AS VARCHAR);


-----EXERCISE -4

GO

CREATE PROCEDURE GetDepartmentSalesTotal
    @DepartmentID INT,
    @StartDate DATE,
    @EndDate DATE,
    @TotalSales DECIMAL(18,2) OUTPUT
AS
BEGIN
    SELECT @TotalSales = SUM(o.TotalAmount)
    FROM Employees e
    JOIN Orders o ON e.EmployeeID = o.EmployeeID
    WHERE e.DepartmentID = @DepartmentID
      AND o.OrderDate BETWEEN @StartDate AND @EndDate
END

---TEST-----
DECLARE @Sales DECIMAL(18,2);

EXEC GetDepartmentSalesTotal 
    @DepartmentID = 2, 
    @StartDate = '2025-01-01', 
    @EndDate = '2025-12-31',
    @TotalSales = @Sales OUTPUT;

PRINT 'Total Department Sales: ' + CAST(@Sales AS VARCHAR);

------EXERCISE -5----

GO
CREATE PROCEDURE GetCustomerOrderStats
    @CustomerID INT,
    @OrderCount INT OUTPUT,
    @TotalSpent DECIMAL(18,2) OUTPUT,
    @AvgOrderValue DECIMAL(18,2) OUTPUT
AS
BEGIN
    SELECT 
        @OrderCount = COUNT(*),
        @TotalSpent = SUM(TotalAmount),
        @AvgOrderValue = AVG(TotalAmount)
    FROM Orders
    WHERE CustomerID = @CustomerID
END

---TEST----

DECLARE @Count INT, 
        @Spent DECIMAL(18,2), 
        @Avg DECIMAL(18,2);

EXEC GetCustomerOrderStats 
    @CustomerID = 101, 
    @OrderCount = @Count OUTPUT,
    @TotalSpent = @Spent OUTPUT,
    @AvgOrderValue = @Avg OUTPUT;

PRINT 'Orders: ' + CAST(@Count AS VARCHAR);
PRINT 'Total Spent: ' + CAST(@Spent AS VARCHAR);
PRINT 'Average Order Value: ' + CAST(@Avg AS VARCHAR);



---EXERCISE-6---
GO
CREATE PROCEDURE GetDepartmentSalesMetrics
    @DepartmentID INT,
    @StartDate DATE,
    @EndDate DATE,
    @TotalSales DECIMAL(18,2) OUTPUT,
    @AvgSales DECIMAL(18,2) OUTPUT,
    @EmployeeCount INT OUTPUT
AS
BEGIN
    SELECT @EmployeeCount = COUNT(*)
    FROM Employees
    WHERE DepartmentID = @DepartmentID;

    SELECT @TotalSales = SUM(o.TotalAmount)
    FROM Employees e
    JOIN Orders o ON e.EmployeeID = o.EmployeeID
    WHERE e.DepartmentID = @DepartmentID
      AND o.OrderDate BETWEEN @StartDate AND @EndDate;

    IF @EmployeeCount > 0
        SET @AvgSales = @TotalSales / @EmployeeCount;
    ELSE
        SET @AvgSales = 0;
END


---TEST----

DECLARE @Total DECIMAL(18,2), 
        @Avg DECIMAL(18,2), 
        @EmpCount INT;

EXEC GetDepartmentSalesMetrics 
    @DepartmentID = 2,
    @StartDate = '2025-01-01',
    @EndDate = '2025-12-31',
    @TotalSales = @Total OUTPUT,
    @AvgSales = @Avg OUTPUT,
    @EmployeeCount = @EmpCount OUTPUT;

PRINT 'Total Sales: ' + CAST(@Total AS VARCHAR);
PRINT 'Average Sales per Employee: ' + CAST(@Avg AS VARCHAR);
PRINT 'Employee Count: ' + CAST(@EmpCount AS VARCHAR);
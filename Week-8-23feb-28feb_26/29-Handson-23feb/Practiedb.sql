use PractiseSP;

--Implementation of the stored procedure
CREATE TABLE Employees
(
    EmpId INT PRIMARY KEY,
    EmpName VARCHAR(50),
    Salary INT
);

-----Stored Procedure (DML + Transaction + TRY CATCH + Output)

CREATE PROCEDURE SP_UpdateSalary
    @EmpId INT,
    @NewSalary INT,
    @Result VARCHAR(50) OUTPUT
AS
BEGIN
    BEGIN TRY
        BEGIN TRANSACTION

        UPDATE Employees
        SET Salary = @NewSalary
        WHERE EmpId = @EmpId

        SET @Result = 'Salary Updated Successfully'

        COMMIT TRANSACTION
    END TRY
    BEGIN CATCH
        ROLLBACK TRANSACTION
        SET @Result = 'Error Occurred'
    END CATCH
END
GO


----Execute Procedure------

declare @OutputMsg varchar(50)
exec SP_UpdateSalary 1,50000,@OutputMsg OUTPUT

select @OutputMsg



----Scalar Function (Return single value)

create function fn_GetAnnualSalary
(
@monthsalary int
)
returns int
as 
begin
return (@monthsalary *12)
end
go

--using select  execute

select dbo.fn_GetAnnualSalary(5000)as annualsalary



----Table valued function--

create function fn_GettingSalEmployees(
@minsal int)
returns table
as return
(select * from Employees
where Salary>=@minsal
)
go


---use select and join---

select* from dbo.fn_GettingSalEmployees(3000)



---Inline Table Valued function (Parameterized view)

CREATE FUNCTION fn_getemployeeId
(
    @empId INT
)
RETURNS TABLE
AS
RETURN
(
    SELECT EmpId, EmpName, Salary
    FROM Employees
    WHERE EmpId = @empId
);
GO

SELECT EmpName, dbo.FN_GetAnnualSalary(Salary) AS AnnualSalary
FROM Employees
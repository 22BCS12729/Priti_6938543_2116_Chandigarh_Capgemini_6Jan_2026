USE UniversityDB;

--Tables---

create table Deparments(
DeptId int primary key identity(1,1),
DeptName nvarchar(100) not null
);


create table Courses(
courseId int primary key Identity(1,1),
courseName nvarchar(100) not null,
DeptId int foreign key references Deparments(DeptId)
);

create table Students(
StudId int primary key Identity(1,1),
FirstName nvarchar (50),
LatName nvarchar(50),
Email nvarchar(100),
DeptId int foreign key references Deparments(DeptId)
);


create table Enrollments(
enrollmentId int primary key Identity(1,1),
StudentId int foreign key references Students(StudId),
CourseId int foreign key references  Courses(courseId),
Grade char(2)
);

INSERT INTO Deparments (DeptName)
VALUES 
('Computer Science'),
('Mathematics'),
('Physics');


-- Insert into Courses
INSERT INTO Courses (courseName, DeptId)
VALUES
('Data Structures', 1),
('Algorithms', 1),
('Linear Algebra', 2),
('Quantum Mechanics', 3);


-- Insert into Students
INSERT INTO Students (FirstName, LatName, Email, DeptId)
VALUES
('Alice', 'Johnson', 'alice@uni.com', 1),
('Bob', 'Smith', 'bob@uni.com', 2),
('Charlie', 'Brown', 'charlie@uni.com', 3);



-- Insert into Enrollments
INSERT INTO Enrollments (StudentId, CourseId, Grade)
VALUES
(1, 1, 'A'),
(1, 2, 'B'),
(2, 3, 'A'),
(3, 4, 'C');


SELECT * FROM Deparments;
SELECT * FROM Courses;
SELECT * FROM Students;
SELECT * FROM Enrollments;



----STORED PROCEDURE FOR STUDENTS----
go
CREATE OR ALTER PROCEDURE sp_InsertStudent
    @FirstName NVARCHAR(50),
    @LatName NVARCHAR(50),
    @Email NVARCHAR(100),
    @DeptId INT
AS
BEGIN
    SET NOCOUNT ON;

    INSERT INTO Students (FirstName, LatName, Email, DeptId)
    VALUES (@FirstName, @LatName, @Email, @DeptId);
END
GO


-----SELECT ALL STUDENTS----
CREATE OR ALTER PROCEDURE sp_GetAllStudents
AS
BEGIN
    SET NOCOUNT ON;

    SELECT 
        s.StudId,
        s.FirstName,
        s.LatName,
        s.Email,
        d.DeptName
    FROM Students s
    INNER JOIN Deparments d
        ON s.DeptId = d.DeptId;
END
GO

-----Update students--
CREATE OR ALTER PROCEDURE sp_UpdateStudent
    @StudId INT,
    @FirstName NVARCHAR(50),
    @LatName NVARCHAR(50),
    @Email NVARCHAR(100),
    @DeptId INT
AS
BEGIN
    SET NOCOUNT ON;

    UPDATE Students
    SET FirstName = @FirstName,
        LatName = @LatName,
        Email = @Email,
        DeptId = @DeptId
    WHERE StudId = @StudId;
END
GO

------delete students---
CREATE OR ALTER PROCEDURE sp_DeleteStudent
    @StudId INT
AS
BEGIN
    SET NOCOUNT ON;

    DELETE FROM Students
    WHERE StudId = @StudId;
END
GO

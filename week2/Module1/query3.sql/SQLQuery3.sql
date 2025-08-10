USE db1;
GO


IF OBJECT_ID('Employees', 'U') IS NOT NULL DROP TABLE Employees;
IF OBJECT_ID('Departments', 'U') IS NOT NULL DROP TABLE Departments;
GO


CREATE TABLE Departments (
    DepartmentID INT PRIMARY KEY,
    DepartmentName VARCHAR(100)
);
GO


CREATE TABLE Employees (
    EmployeeID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    DepartmentID INT FOREIGN KEY REFERENCES Departments(DepartmentID),
    Salary DECIMAL(10,2),
    JoinDate DATE
);
GO


INSERT INTO Departments (DepartmentID, DepartmentName) VALUES
(1, 'HR'),
(2, 'Finance'),
(3, 'IT'),
(4, 'Marketing');

INSERT INTO Employees (EmployeeID, FirstName, LastName, DepartmentID, Salary, JoinDate) VALUES
(1, 'John', 'Doe', 1, 5000.00, '2020-01-15'),
(2, 'Jane', 'Smith', 2, 6000.00, '2019-03-22'),
(3, 'Michael', 'Johnson', 3, 7000.00, '2018-07-30'),
(4, 'Emily', 'Davis', 4, 5500.00, '2021-11-05');
GO


CREATE OR ALTER PROCEDURE sp_GetEmployeeCountByDepartment
    @DeptID INT
AS
BEGIN
    SELECT 
        D.DepartmentName,
        COUNT(E.EmployeeID) AS TotalEmployees
    FROM Employees E
    INNER JOIN Departments D ON E.DepartmentID = D.DepartmentID
    WHERE E.DepartmentID = @DeptID
    GROUP BY D.DepartmentName;
END;
GO


EXEC sp_GetEmployeeCountByDepartment @DeptID = 2;

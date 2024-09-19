--CREATE TABLE Orders (
--    OrderID INT PRIMARY KEY IDENTITY(1,1),
--    PurchaseAmount DECIMAL(10, 2),
--    Discount DECIMAL(10, 2) 
--);
--INSERT INTO Orders (PurchaseAmount) VALUES (1200), (600), (400);
--UPDATE Orders
--SET Discount = dbo.CalculateDiscount(PurchaseAmount);
--SELECT * FROM Orders;


--CREATE TABLE Employees (
--    EmployeeID INT IDENTITY(1,1) PRIMARY KEY,
--    FirstName NVARCHAR(50) NOT NULL,
--    LastName NVARCHAR(50) NOT NULL,
--    Position NVARCHAR(50) NOT NULL,
--    Salary DECIMAL(10, 2) NOT NULL
--);
--EXEC AddNewEmployee 
--    @FirstName = N'Олег', 
--    @LastName = N'Іванов', 
--    @Position = N'Менеджер', 
--    @Salary = 50000.00;
--SELECT * FROM Employees
--Не понимаю почему вот тут @FirstName = N'Олег', и ниже без N не работает если я итак создал таблицу через NVARCHAR



--CREATE TABLE Inventory (
--    ProductID INT PRIMARY KEY,
--    ProductName NVARCHAR(100),
--    Quantity INT NOT NULL CHECK (Quantity >= 0)
--);
--CREATE TABLE Transactions (
--    TransactionID INT PRIMARY KEY IDENTITY(1,1),
--    ProductID INT,
--    Quantity INT,
--    FOREIGN KEY (ProductID) REFERENCES Inventory(ProductID)
--);
--INSERT INTO Inventory (ProductID, Quantity) VALUES (1, 5);
--DECLARE @ProductID INT = 1;
--BEGIN TRY
--    BEGIN TRANSACTION;

--    UPDATE Inventory
--    SET Quantity = Quantity - 1
--    WHERE ProductID = @ProductID AND Quantity > 0;

--    INSERT INTO Transactions (ProductID, Quantity)
--    VALUES (@ProductID, 1);

--    COMMIT;
--END TRY
--BEGIN CATCH
--    ROLLBACK;

--    DECLARE @ErrorMessage NVARCHAR(4000);
--    SET @ErrorMessage = ERROR_MESSAGE();
--    PRINT @ErrorMessage;
--END CATCH;
--SELECT * FROM Inventory;
--SELECT * FROM Transactions;


--CREATE TABLE Students (
--    StudentID INT PRIMARY KEY,
--    StudentName VARCHAR(100)
--);

--CREATE TABLE Courses (
--    CourseID INT PRIMARY KEY,
--    CourseName VARCHAR(100),
--    InstructorName VARCHAR(100)
--);

--CREATE TABLE Enrollments (
--    EnrollmentID INT PRIMARY KEY,
--    StudentID INT,
--    CourseID INT,
--    FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
--    FOREIGN KEY (CourseID) REFERENCES Courses(CourseID)
--);
--INSERT INTO Students (StudentID, StudentName) VALUES
--(1, 'John Doe'),
--(2, 'Jane Smith'),
--(3, 'Alice Johnson');
--INSERT INTO Courses (CourseID, CourseName, InstructorName) VALUES
--(101, 'Mathematics', 'Ms.A'),
--(102, 'Physics', 'Mr.B'),
--(103, 'Chemistry', 'Mr.C');
--INSERT INTO Enrollments (EnrollmentID, StudentID, CourseID) VALUES
--(1, 1, 101),
--(2, 1, 102),
--(3, 2, 101),
--(4, 3, 103);
SELECT 
    s.StudentName,
    c.CourseName,
    c.InstructorName
FROM 
    Enrollments e
JOIN 
    Students s ON e.StudentID = s.StudentID
JOIN 
    Courses c ON e.CourseID = c.CourseID;

CREATE PROCEDURE AddNewEmployee
    @FirstName NVARCHAR(50),
    @LastName NVARCHAR(50),
    @Position NVARCHAR(50),
    @Salary DECIMAL(10, 2)
AS
BEGIN
    INSERT INTO Employees (FirstName, LastName, Position, Salary)
    VALUES (@FirstName, @LastName, @Position, @Salary);
END;
--CREATE TABLE Students (
    --StudentID INT PRIMARY KEY,
    --FirstName VARCHAR(50),
    --LastName VARCHAR(50),
    --BirthDate DATE,
    --EnrollmentDate DATE,
    --IsActive BIT
--);

--CREATE TABLE Enrollments (
    --EnrollmentID INT PRIMARY KEY,
    --StudentID INT,
    --CourseID INT,
    --FOREIGN KEY (StudentID) REFERENCES Students(StudentID) ON DELETE CASCADE,
    --FOREIGN KEY (CourseID) REFERENCES Courses(CourseID) ON DELETE CASCADE
--);


--INSERT INTO Courses (CourseID, CourseName, Credits)
--VALUES
--(1, 'Physics', 4),
--(2, 'Mathematics', 3),
--(3, 'Chemistry', 4);

--INSERT INTO Enrollments (EnrollmentID, StudentID, CourseID)
--VALUES
--(1,1,1) и тд

--CREATE NONCLUSTERED INDEX Тут имя
--ON Students (LastName);

--CREATE CLUSTERED INDEX Тоже самое
--ON Students (EnrollmentDate);

--DELETE FROM Students
--WHERE StudentID = и тут просто айди;

UPDATE Courses
SET Credits = 5
WHERE CourseName = 'Mathematics';

SELECT s.* FROM Students s
JOIN Enrollments e ON s.StudentID = e.StudentID
JOIN Courses c ON e.CourseID = c.CourseID
WHERE c.CourseName = 'Physics';
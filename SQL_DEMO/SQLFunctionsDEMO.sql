CREATE DATABASE NFSDB;
USE NFSDB;
CREATE TABLE Employees
(
    EmpID INT PRIMARY KEY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Department VARCHAR(50),
    Salary INT
);
INSERT INTO Employees VALUES (1, 'John', 'Doe', 'IT', 50000);
INSERT INTO Employees VALUES (2, 'Jane', 'Smith', 'HR', 60000);
INSERT INTO Employees VALUES (3, 'Amit', 'Sharma', 'IT', 80000);
INSERT INTO Employees VALUES (4, 'Sara', 'Khan', 'Finance', 75000);

SELECT * FROM Employees;

DELIMITER $$
CREATE FUNCTION GetAnnualSalary(Salary INT)
RETURNS INT
deterministic
BEGIN
    RETURN Salary * 12;
END $$
DELIMITER ;

SELECT FirstName, GetAnnualSalary(Salary) AS AnnualSalary FROM Employees;


DELIMITER $$
CREATE FUNCTION CalculateBonus(Salary INT, Department VARCHAR(50))
RETURNS INT
DETERMINISTIC
BEGIN
	DECLARE bonus INT;
	IF Department = "IT" THEN
	SET bonus = salary*0.15;
    ELSEIF Department = "HR" THEN
	SET bonus = salary*0.12;
    ELSE
    SET bonus = salary*0.1;
    END IF;
    RETURN bonus;
END $$
DELIMITER ;
DROP Function CalculateBonus;
SELECT FirstName, Department, CalculateBonus(Salary, Department) AS Bonus FROM Employees;


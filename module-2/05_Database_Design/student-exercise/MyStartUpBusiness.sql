USE master;
GO

IF EXISTS (SELECT * FROM sys.databases WHERE name='MyStartUpBusiness')
DROP DATABASE MyStartUpBusiness;
GO

CREATE DATABASE MyStartUpBusiness;
GO

USE MyStartUpBusiness;
GO

BEGIN TRANSACTION;

CREATE TABLE Employee (
	EmployeeID INT IDENTITY PRIMARY KEY,
	Job_Title NVARCHAR(64) NOT NULL,
	First_Name NVARCHAR(42) NOT NULL,
	Last_Name NVARCHAR(42) NOT NULL,
	Gender NVARCHAR(42) NOT NULL,
	Birth_Date DATE NOT NULL,
	Hire_Date DATE NOT NULL,
	Hiring_Department NVARCHAR(42) NOT NULL,
	Current_Department NVARCHAR(42) NOT NULL
	);

	-- IT/Engineering, Sales, Marketing, Analytics/Customer Relations

INSERT INTO Employee (Job_Title, First_Name, Last_Name, Gender, Birth_Date, Hire_Date, Hiring_Department,Current_Department)
VALUES ('Chief Technology Officer','Matt','ELand','Male',1984-06-18, 2019-8-15, 'IT/Engineering','IT/Engineering');
--
INSERT INTO Employee (Job_Title, First_Name, Last_Name, Gender, Birth_Date, Hire_Date, Hiring_Department,Current_Department)
VALUES ('Chief Executive Officer','Joel','Birdsall','Male',1988-08-18, 2019-8-02, 'IT/Engineering','IT/Engineering');
--
INSERT INTO Employee (Job_Title, First_Name, Last_Name, Gender, Birth_Date, Hire_Date, Hiring_Department,Current_Department)
VALUES ('Chief Operations Officer','Katie','Detore','Female',1985-02-01, 2019-08-15, 'IT/Engineering','IT/Engineering');
--
INSERT INTO Employee (Job_Title, First_Name, Last_Name, Gender, Birth_Date, Hire_Date, Hiring_Department,Current_Department)
VALUES ('IT Department Head','Grace','Hopper','Female',1906-12-09, 2019-09-02, 'IT/Engineering','IT/Engineering');
--
INSERT INTO Employee (Job_Title, First_Name, Last_Name, Gender, Birth_Date, Hire_Date, Hiring_Department,Current_Department)
VALUES ('Sales Department Head','Vinny','Something_Italian','Male',1986-04-01, 2019-09-02, 'IT/Engineering','Sales');
--
INSERT INTO Employee (Job_Title, First_Name, Last_Name, Gender, Birth_Date, Hire_Date, Hiring_Department,Current_Department)
VALUES ('Marketing Department Head','Maddy','Miller?','Female',1995-05-01, 2019-09-15, 'IT/Engineering','Marketing');
--
INSERT INTO Employee (Job_Title, First_Name, Last_Name, Gender, Birth_Date, Hire_Date, Hiring_Department,Current_Department)
VALUES ('Analytics/Customer Relations Department Head','Bob','Ross','Male',1942-10-29, 2019-09-15, 'IT/Engineering','Analytics/Customer Relations');
--
INSERT INTO Employee (Job_Title, First_Name, Last_Name, Gender, Birth_Date, Hire_Date, Hiring_Department,Current_Department)
VALUES ('Lonely Programmer in the Basement that does all the work','John','Fulton','Male',1970-01-01, 2019-09-28, 'IT/Engineering','IT/Engineering');
--

CREATE TABLE Department (
	DepartmentID INT IDENTITY PRIMARY KEY,
	Department_Name NVARCHAR(64) NOT NULL,
	);

INSERT INTO Department (Department_Name) VALUES ('IT/Engineering', 'Sales', 'Marketing', 'Analytics/Customer Relations')

CREATE TABLE Department_Employee (
	DepartmentID INT PRIMARY KEY,
	EmployeeID INT NOT NULL
	);


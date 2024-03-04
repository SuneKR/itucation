-- Exercise 1

CREATE DATABASE TestDB;

USE TestDB;

CREATE TABLE dbo.Persons(Id int identity primary key, Name nvarchar(50) NOT NULL, Phone int, Email varchar(45));
-- DROP TABLE dbo.Persons;

INSERT dbo.Persons(Name,Phone,Email)
VALUES
('Melisa', 71432957, 'dbzkiax797@couldmail.com'),
('Victor', 26108068, 'yago.jarad@farmoaks.com'),
('Damian', 48188264, 'fdd5e6b95cf3d197@gmail.com'),
('Zuri', 37408509, '4d0c340de00eedd8@gmail.com'),
('Zebadiah', 67834127, '76eaaa776696120b@gmail.com');

SELECT * FROM dbo.Persons;

-- Excercise 2
USE VoresDB;

CREATE TABLE dbo.Departments(dID int identity primary key, dName nvarchar(50) NOT NULL, Location nvarchar(50));
CREATE TABLE dbo.Employess(eID int identity primary key, eName nvarchar(50) NOT NULL, dID int foreign key references dbo.Departments(dID), Salary int);

INSERT dbo.Departments(dName, Location) VALUES
('IT', 'Aarhus'),
('Sales', 'Nordpolen');

INSERT dbo.Employess(eName, dID, Salary) VALUES
('Briant' , 1, 56000),
('Dave' , 1, 54000),
('Zuri' , 1, 51000),
('Trinity' , 2, 51000),
('Sid' , 2, 55000);

SELECT eName, Salary FROM dbo.Employess;

SELECT Employess.eName, Employess.Salary, Departments.Location FROM dbo.Employess JOIN dbo.Departments ON Employess.dID = Departments.dID;
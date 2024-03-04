--CREATE DATABASE VoresDB
--USE VoresDB

CREATE TABLE Customers(
cID int identity primary key,
cName nvarchar (50) NOT NULL,
cEmail varchar(45) default 'bla@bla.dk',
cPhone int default 12345678
);

SELECT * FROM dbo.Customers;

INSERT dbo.Customers(cName, cEmail, cPhone)
VALUES('Mark', 'mark@mail.dk', 12344455),('Charlotte', 'CMM@mail.dk', 87654321);

-- Keyword aren't case sensitive at all, but convention writes 
inSeRt dbo.Customers(cname) values('Lisa'),('Lars'), ('Marie'),('Ole')


SELECT * FROM dbo.Customers WHERE cID > 2;


CREATE TABLE Products(
pID int identity primary key,
pNAme nvarchar(50) NOT NULL,
pPrice int default 100
);

INSERT dbo.Products(pName, pPrice)
VALUES('TV', 5000), ('Smartphone', 7000), ('Laptop', 6000);

INSERT dbo.Products(pName) VALUES('Drikkedunk');

SELECT * FROM dbo.Products;

CREATE TABLE Orders(
oID int identity primary key,
cID int foreign key references dbo.Customers(cID),
pID int foreign key references dbo.Products(pID),
orderDate DateTime default current_timestamp
);

INSERT dbo.Orders(cID, pID)
VALUES (2,3), (1,4), (3,2), (4,4);

SELECT * FROM dbo.Orders;

-- Joins ---

SELECT c.cName, o.orderDate, p.pName, p.pPrice 'Unit Price'
FROM dbo.Orders as o
JOIN dbo.Customers as c ON o.cID = c.cID
JOIN dbo.Products as p ON o.pID = p.pID;


-- Alter --
ALTER TABLE dbo.Orders ADD paymentStatus bit default 0; --database pandang to boolean
ALTER TABLE dbo.ORders ADD quantity int default 1;
SELECT * FROM dbo.Orders;

-- Update --
UPDATE dbo.Orders SET paymentStatus = 1;
UPDATE dbo.Orders SET paymentStatus = 0 WHERE oID = 4;
SELECT * FROM dbo.Orders;

UPDATE dbo.Orders SET quantity = 1;
UPDATE dbo.Orders SET quantity = 3 WHERE oID = 4;
SELECT * FROM dbo.Orders;

-- Join again --
SELECT c.cName, o.orderDate, p.pName, p.pPrice 'Unit Price',
		(o.quantity * p.pPrice) as 'Total Amount'
FROM dbo.Orders as o
JOIN dbo.Customers as c ON o.cID = c.cID
JOIN dbo.Products as p ON o.pID = p.pID;

-- Case --
SELECT c.cName, o.orderDate, p.pName, p.pPrice 'Unit Price',
		(o.quantity * p.pPrice) as 'Total Amount',
		CASE
			WHEN o.paymentStatus = 0 THEN 'NOT paid'
			WHEN o.paymentStatus = 1 THEN 'Paid'
			ELSE 'Contact SysAdmin'
		END as 'Payment Status'
FROM dbo.Orders as o
JOIN dbo.Customers as c ON o.cID = c.cID
JOIN dbo.Products as p ON o.pID = p.pID;

-- UDF (User defined function) --
CREATE FUNCTION  Betalingsstatus(@n int)
RETURNS nvarchar(20)
BEGIN
	RETURN
	CASE
		WHEN @n = 0 THEN 'NOT Paid'
		WHEN @n = 1 THEN 'Paid'
		ELSE 'Contact SysAdmin'
	END
END

SELECT dbo.Betalingsstatus(1) -- Paid
SELECT dbo.Betalingsstatus(0) -- Not Paid
SELECT dbo.Betalingsstatus(99) -- Contact SysAdmin

SELECT c.cName, o.orderDate, p.pName, p.pPrice 'Unit Price',
		(o.quantity * p.pPrice) as 'Total Amount',
		dbo.Betalingsstatus(o.paymentSTatus) as 'Payment Status'
FROM dbo.Orders as o
JOIN dbo.Customers as c ON o.cID = c.cID
JOIN dbo.Products as p ON o.pID = p.pID;

-- View (kan gemme queries)
CREATE VIEW SalesView
as
SELECT c.cName, o.orderDate, p.pName, p.pPrice 'Unit Price',
		(o.quantity * p.pPrice) as 'Total Amount',
		dbo.Betalingsstatus(o.paymentSTatus) as 'Payment Status'
FROM dbo.Orders as o
JOIN dbo.Customers as c ON o.cID = c.cID
JOIN dbo.Products as p ON o.pID = p.pID;

SELECT * FROM SalesView;

-- XML
SELECT * FROM dbo.Customers
FOR XML raw;

SELECT * FROM dbo.Customers
FOR XML raw('Customer');

SELECT * FROM dbo.Customers
FOR XML Auto;

SELECT * FROM dbo.Customers
FOR XML Auto, ELements

SELECT * FROM dbo.Customers
FOR XML Path('Customer'), Root('Customers')

SELECT * FROM dbo.Customers
FOR JSON Auto;
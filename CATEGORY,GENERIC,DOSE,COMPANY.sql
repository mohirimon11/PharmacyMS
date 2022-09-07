use PharmacyMS;
--For Category
CREATE TABLE Category(
ID INT IDENTITY(1,1) ,
Code INT,
Name VARCHAR(20),
Detail VARCHAR(150)
)
INSERT INTO Category (Code,Name,Detail) VALUES (1111,'Tablate','Tablet for ..........')
INSERT INTO Category (Code,Name,Detail) VALUES (1112,'Capsul','Capsul for ..........')
SELECT * FROM Category
 

--For Generic Name
CREATE TABLE GenericName(
ID INT IDENTITY(1,1) ,
Code INT,
Name VARCHAR(20),
Detail VARCHAR(150)
)
SELECT * FROM GenericName
INSERT INTO GenericName (Code,Name,Detail) VALUES (1111,'Agritromicin','Agritromicin for ..........')
INSERT INTO GenericName (Code,Name,Detail) VALUES (1112,'Omiprajol','Omiprajol for ..........')

--For Dose
CREATE TABLE Dose(
ID INT IDENTITY(1,1) ,
Name VARCHAR(20),
)

INSERT INTO Dose (Name) VALUES ('10mg')
INSERT INTO Dose (Name) VALUES ('20mg')
SELECT * FROM Dose

--For Company
CREATE TABLE Company(
ID INT IDENTITY(1,1) ,
Code INT,
Name VARCHAR(20),
Detail VARCHAR(150)
)
INSERT INTO Company (Code,Name,Detail) VALUES (1111,'Squre','Squre for ..........')
INSERT INTO Company (Code,Name,Detail) VALUES (1112,'Baximco','Baximco for ..........')


--For Supplier
Drop table Supplier
CREATE TABLE Supplier(
ID INT IDENTITY (1,1) ,
Code INT,
Name VARCHAR(20),
Address VARCHAR(30),
Contact VARCHAR(20),
Email VARCHAR(30),
ContactPerson VARCHAR(20),
CompanyId INT,
Detail VARCHAR(150),
DateIntroduce DATE
)
SELECT * FROM Supplier
INSERT INTO Supplier (Code,Name,Address,Contact,Email,ContactPerson,CompanyId,Detail,DateIntroduce) VALUES (1111,'Rahim','7/a',01744775516,'rahim@c.com','Rimon',1,'Rahim is a Medicine seller','11-05-21')
INSERT INTO Supplier (Code,Name,Address,Contact,Email,ContactPerson,CompanyId,Detail,DateIntroduce) VALUES (1111,'Karim','Mirpur',01744775517,'karim@c.com','Limon',2,'Karim is a Medicine seller','11-06-21')

--For Seller
--Drop table Seller
CREATE TABLE Seller(
ID INT IDENTITY (1,1) ,
Code INT,
Name VARCHAR(20),
Passwoed VARCHAR(30),
contact VARCHAR(20),
WorkingHoure time,
WorkIn time,
WorkOut time,
NID VARCHAR(30),
Detail VARCHAR(150)
)

INSERT INTO Seller(Code,Name,Passwoed,Contact,WorkingHoure,WorkIn,WorkOut,NID,Detail) VALUES (1111,'Raju','123abc78','01744775516','10:00:00','06:15:00','04:15:00','9223421345674','Raju is a Medicine seller')
INSERT INTO Seller(Code,Name,Passwoed,Contact,WorkingHoure,WorkIn,WorkOut,NID,Detail) VALUES (1112,'rakib','123abc79','01744775519','10:00:00','06:15:00','04:15:00','9223421345674','Rakib is a Medicine seller')

--For Medicine
CREATE TABLE Medicine(
ID INT IDENTITY (1,1) ,
Code INT,
Name VARCHAR(20),
CategoryId INT,
CompanyId INT,
GenericNameId INT,
DoseId INT,
ReorderLavel INT,
AgeLimite VARCHAR(20),
Country VARCHAR(20),
Detail VARCHAR(150),
Instruction VARCHAR(150)
)
INSERT INTO Medicine(Code,Name,CategoryId,CompanyId,GenericNameId,DoseId,ReorderLavel,AgeLimite,Country,Detail,Instruction) VALUES (1111,'saclo',1,1,2,1,10,'5-10','Bangladesh','Omiprajol for ..........Gase','Its for Adult keep it safe')
INSERT INTO Medicine(Code,Name,CategoryId,CompanyId,GenericNameId,DoseId,ReorderLavel,AgeLimite,Country,Detail,Instruction) VALUES (1111,'GMax',2,2,1,2,20,'11-30','USA','Agritromicin for ..........Antibody','Its for Adult keep it safe')

select m.ID Code,m.Name,ca.Name,co.Name,ge.Name,do.Name,ReorderLavel,AgeLimite,Country,m.Detail,Instruction from Medicine as m 
left join Category as ca on ca.ID = m.CategoryId 
left join Company as co on co.ID = m.CompanyId 
left join GenericName as ge on ge.ID = m.GenericNameId
left join Dose as do on do.ID = m.DoseId

--For Purchase
drop table Purchase
CREATE TABLE Purchase(
ID INT IDENTITY (1,1) ,
Code INT,
Date Date,
InvoiceNo VARCHAR(20),
SupplierId INT
)
INSERT INTO Purchase(Code,Date,InvoiceNo,SupplierId)values(1111,'2021-06-27','10001',1)
INSERT INTO Purchase(Code,Date,InvoiceNo,SupplierId)values(1112,'2021-06-27','10002',2)

select p.ID,p.Code,Date,InvoiceNo,s.Name from Purchase as p left join Supplier as s on s.ID = p.SupplierId


--For Purchase Details
CREATE TABLE PurchaseDetails(
ID INT IDENTITY (1,1) ,
PurchaseId INT,
MedicineId INT,
ManufactureDate DATE,
ExpiredDate DATE,
Quantity INT,
UnitPrice FLOAT,
MRP FLOAT,
Remark VARCHAR(150)
)
INSERT INTO PurchaseDetails(PurchaseId,MedicineId,ManufactureDate,ExpiredDate,Quantity,UnitPrice,MRP,Remark) VALUES
(1,1,'2021-06-27','2022-06-27',50,50.00,55.22,'Its from -------')
INSERT INTO PurchaseDetails(PurchaseId,MedicineId,ManufactureDate,ExpiredDate,Quantity,UnitPrice,MRP,Remark) VALUES
(2,2,'2021-06-27','2022-06-27',120,30.55,34.20,'Its from -------')

SELECT pud.ID,pu.InvoiceNo,me.Name,ManufactureDate,ExpiredDate,Quantity,UnitPrice,MRP,Remark FROM 
PurchaseDetails as pud left join Purchase as pu on pu.ID = pud.PurchaseId
left join Medicine as me on me.ID = pud.MedicineId 

--For Sale Detail
CREATE TABLE Sale(
ID INT IDENTITY (1,1) ,
Code INT,
Date Date,
InvoiceNo VARCHAR(20),
SellerId INT
)
INSERT INTO Sale(Code,Date,InvoiceNo,SellerId)values(1111,'2021-06-27','10001',1)
INSERT INTO Sale(Code,Date,InvoiceNo,SellerId)values(1112,'2021-06-27','10001',2)

SELECT s.ID,s.Code,Date,InvoiceNo,se.Name FROM Sale as s left join Seller as se on se.ID = s.SellerId

--For SaleDetail
CREATE TABLE SaleDetail(
ID INT IDENTITY (1,1) ,
SaleId INT,
MedicineId INT,
Quantity INT,
MRP float,
PayableAmount float
)
INSERT INTO SaleDetail(SaleId,MedicineId,Quantity,MRP,PayableAmount) VALUES
(1,1,5,55.22,56.12)
INSERT INTO SaleDetail(SaleId,MedicineId,Quantity,MRP,PayableAmount) VALUES
(2,2,20,34.20,35.22)
SELECT sd.ID,se.Name,m.Name,Quantity,MRP,PayableAmount FROM SaleDetail as sd left join Sale as s on s.ID=sd.SaleId
left join Medicine as m on m.ID = sd.MedicineId
left join Seller as se on se.ID = SaleId;

SELECT * FROM SaleDetail
SELECT * FROM Sale
SELECT * FROM PurchaseDetails
SELECT * FROM Purchase
SELECT * FROM Medicine
SELECT * FROM Seller
SELECT * FROM Company
SELECT * FROM Category
SELECT * FROM Dose
SELECT * FROM Supplier
SELECT * FROM GenericName





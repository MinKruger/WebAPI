------------------------------------------------------------------------------------------------------------------------------------
--															INSTRUCTIONS
------------------------------------------------------------------------------------------------------------------------------------

-- First, you need to create a Multinational database
-- Then you have to create each table separately
-- And finishing with the user, if it's not created previously

------------------------------------------------------------------------------------------------------------------------------------

CREATE DATABASE Multinational
USE Multinational

------------------------------------------------------------------------------------------------------------------------------------
--															Tables
------------------------------------------------------------------------------------------------------------------------------------

IF OBJECT_ID('dbo.HeadOffice', 'U') IS NOT NULL DROP TABLE HeadOffice;
CREATE TABLE HeadOffice (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(200) NOT NULL
)

IF OBJECT_ID('dbo.Client', 'U') IS NOT NULL DROP TABLE Client;
CREATE TABLE Client (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Name NVARCHAR(200) NOT NULL,
    HeadOfficeId INT NOT NULL FOREIGN KEY REFERENCES HeadOffice(Id),

    INDEX IndexHeadOfficeId NONCLUSTERED(HeadOfficeId)
)

IF OBJECT_ID('dbo.Product', 'U') IS NOT NULL DROP TABLE Product;
CREATE TABLE Product (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Description VARCHAR(200),
    Value DECIMAL(7,2) NOT NULL
)

IF OBJECT_ID('dbo.Sale', 'U') IS NOT NULL DROP TABLE Sale;
CREATE TABLE Sale (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    TotalValue DECIMAL(10,2) NOT NULL,
    ClientId INT NOT NULL FOREIGN KEY REFERENCES Client(Id),
    HeadOfficeId INT NOT NULL FOREIGN KEY REFERENCES HeadOffice(Id),

    INDEX IndexClientId NONCLUSTERED(ClientId),
    INDEX IndexHeadOfficeId NONCLUSTERED(HeadOfficeId)
)

IF OBJECT_ID('dbo.Item', 'U') IS NOT NULL DROP TABLE Item;
CREATE TABLE Item (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    Quantity INT NOT NULL,
    SaleId INT NOT NULL FOREIGN KEY REFERENCES Sale(Id),
    ProductId INT NOT NULL FOREIGN KEY REFERENCES Product(Id),

    INDEX IndexSaleId NONCLUSTERED(SaleId),
    INDEX IndexProductId NONCLUSTERED(ProductId)
)

------------------------------------------------------------------------------------------------------------------------------------
--															LOGIN AND USER
------------------------------------------------------------------------------------------------------------------------------------

CREATE LOGIN [admin] WITH PASSWORD=N'1234', DEFAULT_DATABASE=[Multinational], DEFAULT_LANGUAGE=[us_english]
CREATE USER [admin] FOR LOGIN [admin] WITH DEFAULT_SCHEMA=[dbo]

-- After creation, the connection via login and machine must be enabled:
-- Right click and "Properties" your connection in "Object Explorer"
-- "Safety"
-- Check "SQL Server and Windows authentication mode" in "Server authentication"
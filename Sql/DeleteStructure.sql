------------------------------------------------------------------------------------------------------------------------------------
--															INSTRUCTIONS
------------------------------------------------------------------------------------------------------------------------------------

-- This script should only be executed if you want to delete all tables and all types of data created.
-- When deleting, all data will be lost.
-- Make sure you are on the correct base before running

------------------------------------------------------------------------------------------------------------------------------------

USE Multinational

-----------------------------------------------------------------------------------------------------------------------------------
--															DROP ALL CONSTRAINTS
------------------------------------------------------------------------------------------------------------------------------------

while(exists(select 1 from INFORMATION_SCHEMA.TABLE_CONSTRAINTS where CONSTRAINT_TYPE='FOREIGN KEY'))
begin
	declare @sql nvarchar(2000)
	SELECT TOP 1 @sql=('ALTER TABLE ' + TABLE_SCHEMA + '.[' + TABLE_NAME
	+ '] DROP CONSTRAINT [' + CONSTRAINT_NAME + ']')
	FROM information_schema.table_constraints
	WHERE CONSTRAINT_TYPE = 'FOREIGN KEY'
	exec (@sql)
end

------------------------------------------------------------------------------------------------------------------------------------
--															DROP ALL TABLES
------------------------------------------------------------------------------------------------------------------------------------

IF OBJECT_ID('dbo.Client', 'U') IS NOT NULL DROP TABLE Client;
IF OBJECT_ID('dbo.Product', 'U') IS NOT NULL DROP TABLE Product;
IF OBJECT_ID('dbo.HeadOffice', 'U') IS NOT NULL DROP TABLE HeadOffice;
IF OBJECT_ID('dbo.Sale', 'U') IS NOT NULL DROP TABLE Sale;
IF OBJECT_ID('dbo.Item', 'U') IS NOT NULL DROP TABLE Item;

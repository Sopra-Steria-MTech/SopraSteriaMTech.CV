-- SQL Server init script

-- Create the AddressBook database
IF NOT EXISTS (SELECT * FROM sys.databases WHERE name = N'sqldb')
BEGIN
  CREATE DATABASE sqldb;
END;
GO
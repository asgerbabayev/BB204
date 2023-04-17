

-- DDL --

--CREATE DATABASE BB204
--USE BB204


--DROP DATABASE BB204

--CREATE TABLE Students(
--Id INT IDENTITY(0,1) PRIMARY KEY,
--[Name] NVARCHAR(50) NOT NULL,
--Surname NVARCHAR(100) DEFAULT('XXX'),
--Age INT	NOT NULL CHECK (Age > 0 AND Age < 100),
--Email varchar(255) NOT NULL UNIQUE
--)

--ALTER TABLE Students
--ALTER COLUMN [Name] nvarchar(50)

--ALTER TABLE Students
--ADD Email VARCHAR(MAX)

--DROP TABLE Students

-- DML --

--INSERT INTO Students ( Age, Email)
--VALUES 
--( 18, 'elvin1.qasimov@code.edu.az'),
--( 19, 'arzu2@code.edu.az')


--UPDATE Students 
--SET Surname = NULL
--WHERE Id = 3

--DELETE FROM Students
--WHERE Id = 4



--UPDATE Students SET Age = 22
--WHERE Id = 3

--SELECT * FROM Students
--WHERE Age > 18











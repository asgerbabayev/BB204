

CREATE TABLE Country(
Id INT PRIMARY KEY IDENTITY(1,1),
[Name] NVARCHAR(255) NOT NULL
)
CREATE TABLE City(
Id INT PRIMARY KEY IDENTITY(1,1),
[Name] NVARCHAR(255) NOT NULL,
CountryId INT REFERENCES Country(Id)
)

--SELECT City.Name, Country.Name FROM City, Country Where City.CountryId = Country.Id

SELECT City.Name, Country.Name FROM City
JOIN 
Country
ON
City.CountryId = Country.Id


SELECT City.Name, Country.Name FROM City
LEFT JOIN 
Country
ON
City.CountryId = Country.Id


SELECT City.Name, Country.Name FROM City
RIGHT JOIN 
Country
ON
City.CountryId = Country.Id


SELECT City.Name, Country.Name FROM City
FULL OUTER JOIN 
Country
ON
City.CountryId = Country.Id
WHERE City.CountryId IS NULL 


CREATE TABLE Products
(
Id INT PRIMARY KEY IDENTITY(1,1),
[Name] NVARCHAR(255) NOT NULL
)

CREATE TABLE Sizes
(
Id INT PRIMARY KEY IDENTITY(1,1),
Size nvarchar(10)
)


--SELECT p.Name, s.Size FROM Products p
--CROSS JOIN Sizes s


--SELECT s.Name FROM Students AS s WHERE s.Age IN (18, 95)

--SELECT s.Name, s.Age FROM Students AS s 
--ORDER BY s.Name DESC
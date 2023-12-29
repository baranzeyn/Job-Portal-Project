-- Kullanýcýlar tablosu
USE [Jobportal-Db]
CREATE TABLE Users(
    UserID INT PRIMARY KEY IDENTITY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Email VARCHAR(100) UNIQUE,
    Password VARCHAR(255),
	UserType NVARCHAR(5) DEFAULT 'user' CHECK (UserType IN ('user', 'admin'))
);

--Varsayýlan kullanýcýlar
INSERT INTO Users (FirstName, LastName, Email, Password)
VALUES ('Sariye', 'Yaman', 'yamansare@gmail.com', HASHBYTES('SHA2_256', 'hello1'));
INSERT INTO Users (FirstName, LastName, Email, Password)
VALUES ('Zeynep', 'Baran', 'baranzeynep@gmail.com', HASHBYTES('SHA2_256', 'hello2'));
INSERT INTO Users (FirstName, LastName, Email, Password)
VALUES ('Taha', 'Koçer', 'kocertaha@gmail.com', HASHBYTES('SHA2_256', 'hello3'));
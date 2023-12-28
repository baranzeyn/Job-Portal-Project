-- Adminler tablosu
CREATE TABLE Admins (
    AdminID INT PRIMARY KEY IDENTITY,
    FirstName VARCHAR(50),
    LastName VARCHAR(50),
    Email VARCHAR(100) UNIQUE,
    Password VARCHAR(255),
     UserType NVARCHAR(5) DEFAULT 'admin' CHECK (UserType = 'admin')
);



--Varsay�lan Adminler
--HASHBYTES fonksiyonu password u oldu�u gibi de�il de �ifrelenmi� bir �ekilde depolar
INSERT INTO Admins (FirstName, LastName, Email, Password)
VALUES ('Sare ', 'Yaman', 'ymnsare@gmail.com', HASHBYTES('SHA2_256', 'hello4'));
INSERT INTO Admins (FirstName, LastName, Email, Password)
VALUES ('taha', 'kocerr', 'kcrtaha@gmail.com', HASHBYTES('SHA2_256', 'hello5'));
INSERT INTO Admins (FirstName, LastName, Email, Password)
VALUES ('sevval', 'baran', 'baransevval@gmail.com', HASHBYTES('SHA2_256', 'hello6'));
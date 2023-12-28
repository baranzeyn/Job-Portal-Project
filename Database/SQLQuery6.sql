-- Baþvurular tablosu
CREATE TABLE Applications (
    ApplicationID INT PRIMARY KEY IDENTITY(1,1),
    JobID INT FOREIGN KEY REFERENCES Jobs(JobID),
    ApplicantID INT FOREIGN KEY REFERENCES Users(UserID),
    ApplicationDate DATETIME DEFAULT GETDATE(),
    Status NVARCHAR(20) DEFAULT 'pending' CHECK (Status IN ('pending', 'accepted', 'rejected')),
    CONSTRAINT UC_ApplicantJob UNIQUE (JobID, ApplicantID)
);
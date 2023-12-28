-- Ýþ Baþvurularý Onayý tablosu
CREATE TABLE JobApplicationsApproval (
    ApplicationApprovalID INT PRIMARY KEY IDENTITY(1,1),
    JobID INT FOREIGN KEY REFERENCES Jobs(JobID),
    AdminID INT FOREIGN KEY REFERENCES Admins(AdminID),
    ApplicantID INT FOREIGN KEY REFERENCES Users(UserID),
    Status NVARCHAR(20) DEFAULT 'pending' CHECK (Status IN ('pending', 'accepted', 'rejected')),
    ApplicationDate DATETIME,
    ApprovalDate DATETIME,
    CONSTRAINT UC_JobApplication UNIQUE (JobID, ApplicantID),
    FOREIGN KEY (JobID, ApplicantID) REFERENCES Applications(JobID, ApplicantID)
);
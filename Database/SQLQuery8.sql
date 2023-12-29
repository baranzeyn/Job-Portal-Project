-- Offers tablosu
CREATE TABLE Offers (
    OfferID INT PRIMARY KEY IDENTITY(1,1),
    JobID INT FOREIGN KEY REFERENCES Jobs(JobID),
    ApplicantID INT FOREIGN KEY REFERENCES Users(UserID),
    OfferAmount DECIMAL(18, 2) NOT NULL,
    OfferDuration INT NOT NULL,
    OfferDate DATETIME DEFAULT GETDATE(),
    Status NVARCHAR(20) DEFAULT 'pending' CHECK (Status IN ('pending', 'accepted', 'rejected')),
    CONSTRAINT UC_JobApplicantOffer UNIQUE (JobID, ApplicantID),
    FOREIGN KEY (JobID, ApplicantID) REFERENCES Applications(JobID, ApplicantID)
);


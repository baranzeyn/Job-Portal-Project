CREATE TABLE Jobs (
    JobID INT PRIMARY KEY IDENTITY(1,1),
    JobTitle NVARCHAR(100) NOT NULL,
    CompanyName NVARCHAR(100) NOT NULL,
    Location NVARCHAR(100) NOT NULL,
    SalaryRange NVARCHAR(20) NOT NULL,
    JobType NVARCHAR(20) NOT NULL,
    Deadline NVARCHAR(20) NOT NULL,
    Requirements NVARCHAR(255) NOT NULL,
    Skills NVARCHAR(255) NOT NULL,
    Description NVARCHAR(MAX) NOT NULL,
    DatePosted DATETIME DEFAULT GETDATE(),
    NumberOfVacancies INT NOT NULL
);
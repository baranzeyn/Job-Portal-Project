using System;
using System.Collections.Generic;

namespace Job_Portal_Project.Models;

public partial class Job
{
    public int JobId { get; set; }

    public string JobTitle { get; set; } = null!;

    public string CompanyName { get; set; } = null!;

    public string Location { get; set; } = null!;

    public string SalaryRange { get; set; } = null!;

    public string JobType { get; set; } = null!;

    public string Deadline { get; set; } = null!;

    public string Requirements { get; set; } = null!;

    public string Skills { get; set; } = null!;

    public string Description { get; set; } = null!;

    public DateTime? DatePosted { get; set; }

    public int NumberOfVacancies { get; set; }

    public virtual ICollection<Application> Applications { get; } = new List<Application>();

    public virtual ICollection<JobApplicationsApproval> JobApplicationsApprovals { get; } = new List<JobApplicationsApproval>();

    public virtual ICollection<Offer> Offers { get; } = new List<Offer>();
}

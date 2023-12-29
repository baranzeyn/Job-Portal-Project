using System;
using System.Collections.Generic;

namespace Job_Portal_Project.Models;

public partial class User
{
    public int UserId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? UserType { get; set; }

    public virtual ICollection<Application> Applications { get; } = new List<Application>();

    public virtual ICollection<JobApplicationsApproval> JobApplicationsApprovals { get; } = new List<JobApplicationsApproval>();

    public virtual ICollection<Offer> Offers { get; } = new List<Offer>();
}

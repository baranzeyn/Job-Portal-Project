using System;
using System.Collections.Generic;

namespace Job_Portal_Project.Models;

public partial class Admin
{
    public int AdminId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? UserType { get; set; }

    public virtual ICollection<JobApplicationsApproval> JobApplicationsApprovals { get; } = new List<JobApplicationsApproval>();
}

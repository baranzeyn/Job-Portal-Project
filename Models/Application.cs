using System;
using System.Collections.Generic;

namespace Job_Portal_Project.Models;

public partial class Application
{
    public int ApplicationId { get; set; }

    public int? JobId { get; set; }

    public string? ApplicantId { get; set; }

    public DateTime? ApplicationDate { get; set; }

    public string? Status { get; set; }

    public virtual User? Applicant { get; set; }

    public virtual Job? Job { get; set; }

    public virtual JobApplicationsApproval? JobApplicationsApproval { get; set; }

    public virtual Offer? Offer { get; set; }
}

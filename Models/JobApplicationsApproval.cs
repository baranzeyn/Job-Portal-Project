using System;
using System.Collections.Generic;

namespace Job_Portal_Project.Models;

public partial class JobApplicationsApproval
{
    public int ApplicationApprovalId { get; set; }
    public int? JobId { get; set; }
    public int? AdminId { get; set; } // Eksik olan özellik
    public int? ApplicantId { get; set; }
    public string? Status { get; set; }
    public DateTime? ApplicationDate { get; set; }
    public DateTime? ApprovalDate { get; set; }
    public virtual Admin? Admin { get; set; }
    public virtual User? Applicant { get; set; }
    public virtual Application? Application { get; set; }
    public virtual Job? Job { get; set; }
}

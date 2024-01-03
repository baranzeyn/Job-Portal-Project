using System;
using System.Collections.Generic;

namespace Job_Portal_Project.Models;

public partial class JobApplicationsApproval
{
    public int ApplicationApprovalId { get; set; }
    public int? JobId { get; set; }
    public string? UserId { get; set; } // Eksik olan özellik
    public string? ApplicantId { get; set; }
    public string? Status { get; set; }
    public DateTime? ApplicationDate { get; set; }
    public DateTime? ApprovalDate { get; set; }
    public virtual Application? Application { get; set; }
    public virtual Job? Job { get; set; }
}

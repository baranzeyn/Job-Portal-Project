using Job_Portal_Project.Models;
using Microsoft.AspNetCore.Identity;

public class UserWithApplicationsViewModel
{
    public IdentityUser User { get; set; }
    public List<Application> AppliedJobs { get; set; }
}
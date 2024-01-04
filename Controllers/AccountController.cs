using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Job_Portal_Project.Models;
using Job_Portal_Project.Repositories;
using Microsoft.AspNetCore.Identity;
using Job_Portal_Project.Services;

namespace Job_Portal_Project.Controllers;

public class AccountController : Controller
{
    private readonly UserManager<IdentityUser> _userManager;
    private readonly IServiceManager _serviceManager;

    public AccountController(UserManager<IdentityUser> userManager, IServiceManager serviceManager)
    {
        _userManager = userManager;
        _serviceManager = serviceManager;
    }

    public async Task<IActionResult> Index()
    {
        var userr = await _userManager.GetUserAsync(User);
        var applications =  _serviceManager.ApplicationService.GetApplicationsByUserID(userr.Id, false).ToList();

        var model = new UserWithApplicationsViewModel
        {
            User = userr,
            AppliedJobs = applications
        };
        return View(model);
    }

}

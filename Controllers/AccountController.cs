using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Job_Portal_Project.Models;
using Job_Portal_Project.Repositories;
using Microsoft.AspNetCore.Identity;

namespace Job_Portal_Project.Controllers;

public class AccountController : Controller
{
    private readonly UserManager<IdentityUser> _userManager;

    public AccountController(UserManager<IdentityUser> userManager)
    {
        _userManager = userManager;
    }

    public async Task<IActionResult> Index()
    {
        var model = await _userManager.GetUserAsync(User);
        return View(model);
    }

}

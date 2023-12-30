using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Job_Portal_Project.Models;
using Job_Portal_Project.Repositories;

namespace Job_Portal_Project.Controllers;

public class AccountController : Controller
{

    private IAdminRepository _adminRepository;

    public AccountController(IAdminRepository adminRepository)
    {
        _adminRepository = adminRepository;
    }

    public IActionResult Index()
    {
        return View();
    }

}

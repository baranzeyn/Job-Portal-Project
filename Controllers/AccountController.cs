using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Job_Portal_Project.Models;
using Job_Portal_Project.Repositories;

namespace Job_Portal_Project.Controllers;

public class AccountController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

}

using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Job_Portal_Project.Models;

namespace Job_Portal_Project.Controllers;

public class LoginController : Controller {
    public IActionResult Login()
    {
        return View("Login");
    }
    public IActionResult Register()
    {
        return View("Register");
    }
}

    
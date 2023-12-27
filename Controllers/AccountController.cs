using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Job_Portal_Project.Models;

namespace Job_Portal_Project.Controllers;

public class AccountController : Controller {
    public IActionResult Index()
    {
        return View("Login");
    }
    public IActionResult Register() 
    {
        return View("Register");
    }
}

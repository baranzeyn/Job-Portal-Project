using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Job_Portal_Project.Models;

namespace Job_Portal_Project.Controllers;

public class AboutController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    
}
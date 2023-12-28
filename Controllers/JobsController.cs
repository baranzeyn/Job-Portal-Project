using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Job_Portal_Project.Models;

namespace Job_Portal_Project.Controllers;

public class JobsController : Controller {
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult GetJob()
    {
        return View("GetJob");
    }
     public IActionResult PostJob()
    {
        return View("PostJob");
    }

    public IActionResult Offer() {
        return View("Offer");
    }
}

    
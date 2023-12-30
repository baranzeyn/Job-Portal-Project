using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Job_Portal_Project.Models;
using Job_Portal_Project.Services;

namespace Job_Portal_Project.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;
    private readonly IServiceManager _manager;

    public HomeController(ILogger<HomeController> logger, IServiceManager manager)
    {
        _logger = logger;
        _manager = manager;
    }

    public IActionResult Index()
    {
        var list = _manager.JobsService.GetAllJobs(false).ToList();
        return View(list);
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}

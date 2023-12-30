using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Job_Portal_Project.Models;
using Job_Portal_Project.Services;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Job_Portal_Project.Controllers;

public class JobsController : Controller
{
    private readonly IServiceManager _manager;

    public JobsController(IServiceManager manager)
    {
        _manager = manager;
    }

    [HttpGet]
    [Route("Index")]
    public IActionResult Index()
    {
        var list = _manager.JobsService.GetAllJobs(false).ToList();
        return View(list);
    }

    [HttpGet]
    [Route("GetJob")]
    public IActionResult GetJob(int id)
    {
        var job = _manager.JobsService.GetOneJob(id, false);
        return View("GetJob", job);
    }

    [HttpGet]
    public IActionResult PostJob()
    {
        return View("PostJob");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public IActionResult PostJob([FromForm] Job job)
    {
        if (ModelState.IsValid)
        {
            job.DatePosted = DateTime.Now;
            _manager.JobsService.CreateJob(job);
            return RedirectToAction("Index");
        }
        return View();
    }

    public IActionResult Offer()
    {
        return View("Offer");
    }
}


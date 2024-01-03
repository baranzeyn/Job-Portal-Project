using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Job_Portal_Project.Models;
using Job_Portal_Project.Services;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.Linq.Expressions;
using Job_Portal_Project.RequestParameters;
using Microsoft.AspNetCore.Identity;

namespace Job_Portal_Project.Controllers;

public class JobsController : Controller
{
    private readonly IServiceManager _manager;
    private readonly SignInManager<IdentityUser> _signInManager;
    private readonly UserManager<IdentityUser> _userManager;

    public JobsController(IServiceManager manager, UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
    {
        _manager = manager;
        _userManager = userManager;
        _signInManager = signInManager;
    }

    [HttpGet]
    [Route("Index")]
    public IActionResult Index(JobRequestParameters p)
    {
        TempData["SearchTerm"] = p.SearchTerm;
        var list = _manager.JobsService.GetAllJobsWithDetails(p).ToList();
        return View(list);
    }

    [HttpGet]
    [Route("GetJob")]
    public IActionResult GetJob(int id)
    {
        var job = _manager.JobsService.GetOneJob(id, false);
        return View("GetJob", job);
    }
    [HttpPost]
    public async Task<IActionResult> ApplyJobAsync(Job job)
    {
        IdentityUser user = await _userManager.GetUserAsync(User);
        if (user is not null)
        {
            var _applicantID = await _userManager.GetUserNameAsync(user);
        }
        return View();
    }

    [HttpGet]
    public IActionResult PostJob()
    {
        return View("PostJob");
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> PostJob([FromForm] Job job)
    {
        if (ModelState.IsValid)
        {
            IdentityUser user = await _userManager.GetUserAsync(User);
            if (user != null)
            {
            }
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


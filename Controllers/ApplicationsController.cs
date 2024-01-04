using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Job_Portal_Project.Models;
using Job_Portal_Project.Services;
using Microsoft.AspNetCore.Identity;

namespace Job_Portal_Project.Controllers;

public class ApplicationsController : Controller
{

    private readonly IServiceManager _serviceManager;
    private readonly UserManager<IdentityUser> _userManager;

    public ApplicationsController(IServiceManager serviceManager, UserManager<IdentityUser> userManager)
    {
        _serviceManager = serviceManager;
        _userManager = userManager;
    }

    [HttpGet]
    public IActionResult Index()
    {
        var offerList = _serviceManager.OfferService.GetAllOffers(false).ToList();
        var jobList = new List<Job>();
        var userList = new List<IdentityUser>();

        foreach (var offer in offerList)
        {
            var job = _serviceManager.JobsService.GetOneJob((int)offer.JobId, false);
            if (job != null)
            {
                jobList.Add(job);
            }
            // IdentityUser'ı bul ve listeye ekle
            var identityUser = _userManager.FindByIdAsync(offer.ApplicantId).Result;
            if (identityUser != null)
            {
                userList.Add(identityUser);
            }
        }
        
        var model = new OfferWithUserAndJobViewModel
        {
            Offer = offerList,
            Job = jobList,
            User = userList
        };
        return View(model);
    }

    [HttpPost]
    public IActionResult Index(int id)
    {
        return View();
    }
}


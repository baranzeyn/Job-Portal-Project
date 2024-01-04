using Job_Portal_Project.Models;
using Job_Portal_Project.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Python.Runtime;
using Job_Portal_Project.Scripts;

namespace Job_Portal_Project.Controllers
{
    public class CheckApplicationsController : Controller
    {
        private readonly IServiceManager _serviceManager;
        private readonly UserManager<IdentityUser> _userManager;

        public CheckApplicationsController(IServiceManager serviceManager, UserManager<IdentityUser> userManager)
        {
            _serviceManager = serviceManager;
            _userManager = userManager;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var offerList = _serviceManager.OfferService.GetAllOffers(false).ToList();
            var offerPendingList = new List<Offer>();
            var jobList = new List<Job>();
            var userList = new List<IdentityUser>();

            foreach (var offer in offerList)
            {
                if (offer.Status == "accepted")
                {
                    offerPendingList.Add(offer);

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

            }

            var model = new OfferWithUserAndJobViewModel
            {
                Offer = offerPendingList,
                Job = jobList,
                User = userList
            };

            return View(model);
        }

        [HttpPost]
        public IActionResult Check([FromForm] IdentityUser user)
        {
            RunScript.Run();
            return RedirectToAction("Index");
        }

        public IActionResult Done([FromForm] Offer offer)
        {
            return RedirectToAction("Index");
        }

        public IActionResult Decline(Offer offerr)
        {
            var offer = _serviceManager.OfferService.GetOneOfferByID(offerr.OfferId, false);
            offer.Status = "rejected";
            _serviceManager.OfferService.UpdateOneOffer(offer);
            return RedirectToAction("Index");
        }

    }
}
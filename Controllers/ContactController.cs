using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Job_Portal_Project.Models;
using Job_Portal_Project.Services;

namespace Job_Portal_Project.Controllers;

public class ContactController : Controller {

    private readonly IServiceManager _manager;

    public ContactController(IServiceManager manager)
    {
        _manager = manager;
    }

    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult PostMessage(Message message) {
        message.Timestamp = DateTime.Now;
        _manager.ContactService.PostMessage(message);
        return RedirectToAction("Index");
    }
}

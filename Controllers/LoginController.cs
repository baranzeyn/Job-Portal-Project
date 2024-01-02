using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Job_Portal_Project.Models;
using Microsoft.AspNetCore.Identity;

namespace Job_Portal_Project.Controllers;

public class LoginController : Controller {

    private readonly UserManager<IdentityUser> _userManager;
    private readonly SignInManager<IdentityUser> _signInManager;

    public LoginController(UserManager<IdentityUser> userManager, SignInManager<IdentityUser> signInManager)
    {
        _userManager = userManager;
        _signInManager = signInManager;
    }

    [HttpGet]
    public IActionResult Login()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> Login([FromForm] LoginModel model)
    {
        if(ModelState.IsValid)
        {
            IdentityUser user = await _userManager.FindByNameAsync(model.Name);
            if(user is not null)
            {
                await _signInManager.SignOutAsync();
                if((await _signInManager.PasswordSignInAsync(user,model.Password,false,false)).Succeeded)
                {
                    return Redirect(model?.ReturnUrl ?? "/");
                }
                ModelState.AddModelError("Error", "Invalid username or password");

            }
        }
        return View();
    }
    public IActionResult Register()
    {
        return View("Register");
    }
}

    
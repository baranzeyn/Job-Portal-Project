using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Job_Portal_Project.Models;
using Microsoft.AspNetCore.Identity;
using Job_Portal_Project.Dtos;

namespace Job_Portal_Project.Controllers;

public class LoginController : Controller
{

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
        if (ModelState.IsValid)
        {
            IdentityUser user = await _userManager.FindByNameAsync(model.Name);
            if (user is not null)
            {
                await _signInManager.SignOutAsync();
                if ((await _signInManager.PasswordSignInAsync(user, model.Password, false, false)).Succeeded)
                {
                    return Redirect(model?.ReturnUrl ?? "/");
                }
                ModelState.AddModelError("Error", "Invalid username or password");

            }
        }
        return View();
    }

    public async Task<IActionResult> Logout([FromQuery(Name = "ReturnUrl")] string ReturnUrl = "/")
    {
        await _signInManager.SignOutAsync();
        return Redirect(ReturnUrl);

    }
    [HttpGet]
    public IActionResult Register()
    {
        return View("Register");
    }
    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Register([FromForm] RegisterDto model)
    {
        var user = new IdentityUser
        {
            UserName = model.UserName,
            Email = model.Email,
            
        };

        var result = await _userManager.CreateAsync(user,model.Password);
        if(result.Succeeded)
        {
            var roleResult = await _userManager.AddToRoleAsync(user,model.Role);
            if(roleResult.Succeeded)
                return RedirectToAction("Login", new {ReturnUrl = "/"});
        }
        else
        {
            foreach(var err in result.Errors)
            {
                ModelState.AddModelError("",err.Description);
            }
        }
        return View("Register");
    }
}


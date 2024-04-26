using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Owler.Models;

namespace Owler.Pages;

public class LoginModel : PageModel
{

    private readonly SignInManager<User> _signInManager;
    private readonly UserManager<User> _userManager;

    public LoginModel(SignInManager<User> signInManager, UserManager<User> userManager)
    {
        _signInManager = signInManager;
        _userManager = userManager;
    }

    [BindProperty]
    public required UserLoginModel UserLoginModel { get; set; }
    public async Task<IActionResult> OnPostAsync(string? returnUrl = null)
    {
        returnUrl ??= Url.Content("~/Home");


        if (!ModelState.IsValid) return Page();

        if (UserLoginModel.Email.Contains('@'))
        {
            var username = _userManager.Users.FirstOrDefault(u => u.Email == UserLoginModel.Email)?.UserName
                           ?? UserLoginModel.Email[..UserLoginModel.Email.IndexOf('@')];
            UserLoginModel.Email = username;
        }

        var result = await _signInManager.PasswordSignInAsync(UserLoginModel.Email, UserLoginModel.Password, UserLoginModel.RememberMe, lockoutOnFailure: false);
        if (result.Succeeded)
        {
            return LocalRedirect("/Home");
        }
        else
        {
            ModelState.AddModelError(string.Empty, "Invalid login attempt.");
            return Page();
        }

        // If we got this far, something failed, redisplay form
    }
}
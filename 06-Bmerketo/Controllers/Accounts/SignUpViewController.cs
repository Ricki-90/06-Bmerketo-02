using _06_Bmerketo.Accounts.Models.Identity;
using _06_Bmerketo.Accounts.ViewModels;
using _06_Bmerketo.Constructs.Helpers.Services;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace _06_Bmerketo.Controllers.Accounts;

public class SignUpViewController : Controller
{
    #region construkt & private fields
    private readonly UserManager<AppUser> _userManager;
    private readonly AuthService _authService;

    public SignUpViewController(UserManager<AppUser> userManager, AuthService authService)
    {
        _userManager = userManager;
        _authService = authService;
    }
    #endregion

    public IActionResult SignUp()
    {
        return View();
    }

    [HttpPost]
    public async Task<IActionResult> SignUp(UserSignUpViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            if (!await _userManager.Users.AnyAsync(x => x.Email == viewModel.Email))
            {
                if (await _authService.RegisterAsync(viewModel))
					    return RedirectToAction("SignIn", "SignInView");
				}

				ModelState.AddModelError("", "A user with the same email already exists");
			}

        return View(viewModel);
    }
}

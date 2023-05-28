using _06_Bmerketo.Accounts.Helpers.Services;
using _06_Bmerketo.Accounts.ViewModels;
using _06_Bmerketo.Constructs.Helpers.Services;
using Microsoft.AspNetCore.Mvc;

namespace _06_Bmerketo.Controllers.Accounts
{
    public class SignInViewController : Controller
    {
        #region construkt & private fields
        private readonly AuthService _auth;

        public SignInViewController(AuthService auth)
        {
            _auth = auth;
        }
        #endregion


        public IActionResult SignIn()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SignIn(UserSignInViewModel viewModel)
        {
            if (ModelState.IsValid)
            {
                if (await _auth.LoginAsync(viewModel))
                    return RedirectToAction("Index", "HomeView");


                ModelState.AddModelError("", "Incorrect e-mail or password");
            }

            return View(viewModel);
        }
    }
}

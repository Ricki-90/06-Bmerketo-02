using _06_Bmerketo.Accounts.Models.Identity;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace _06_Bmerketo.Controllers.Accounts
{
    public class SignOutViewController : Controller
    {
        #region construkt & private fields
        private readonly SignInManager<AppUser> _signInManager;

        public SignOutViewController(SignInManager<AppUser> signInManager)
        {
            _signInManager = signInManager;
        }
        #endregion

        public async Task<IActionResult> Index()
        {
            if (_signInManager.IsSignedIn(User))
                await _signInManager.SignOutAsync();

            return LocalRedirect("/");
        }
    }
}

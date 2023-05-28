using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace _06_Bmerketo.Controllers.Accounts
{
    public class AccountViewController : Controller
    {
        [Authorize]
        public IActionResult Account()
        {
            return View();
        }
    }
}

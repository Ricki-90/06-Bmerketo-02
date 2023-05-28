using Microsoft.AspNetCore.Mvc;

namespace _06_Bmerketo.Controllers
{
    public class HomeViewController : Controller
    {
        public IActionResult Index()
        {
            ViewData["Title"] = "Home";

            return View();
        }
    }
}

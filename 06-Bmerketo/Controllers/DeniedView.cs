using Microsoft.AspNetCore.Mvc;

namespace _06_Bmerketo.Controllers
{
	public class DeniedView : Controller
	{
		public IActionResult Denied()
		{
			return View();
		}
	}
}

using Microsoft.AspNetCore.Mvc;

namespace _06_Bmerketo.Controllers.Items
{
	public class ItemsView : Controller
	{
		public IActionResult Items()
		{
			return View();
		}
	}
}

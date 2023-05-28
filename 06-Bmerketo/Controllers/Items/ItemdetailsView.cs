using Microsoft.AspNetCore.Mvc;

namespace _06_Bmerketo.Controllers.Items
{
	public class ItemdetailsView : Controller
	{
		public IActionResult Details(int id)
		{
			return View(id);
		}
	}
}

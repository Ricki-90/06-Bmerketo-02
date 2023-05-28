using _06_Bmerketo.Constructs.Helpers.Repositories;
using _06_Bmerketo.Constructs.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace Project_Bmerketo.Controllers
{
    public class ContactViewController : Controller
    {
        #region construkt & private fields
        private readonly ContactFormRepository _formRepository;

        public ContactViewController(ContactFormRepository formRepository)
        {
            _formRepository = formRepository;
        }
        #endregion

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
		public async Task<IActionResult> Index(ContactFormViewModel viewModel)
		{
            if (ModelState.IsValid)
            {
				await _formRepository.AddAsync(viewModel);
				return RedirectToAction("Index");
            }

			return View(viewModel);
		}
	}
}

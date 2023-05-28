using _06_Bmerketo.Databases;
using _06_Bmerketo.Items.Models.ItemsEntites;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;


namespace _06_Bmerketo.Controllers.Accounts
{
    [Authorize(Roles = "Admin")]
    public class AdminViewController : Controller
    {
        #region construkt & private fields
        private readonly IWebHostEnvironment env;
        private readonly ItemsDB dbContext;

        public AdminViewController(ItemsDB dbContext, IWebHostEnvironment env)
        {
            this.dbContext = dbContext;
            this.env = env;
        }
        #endregion

        public IActionResult Admin()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> SaveImage(ItemEntity item, IFormFile imageFile)
        {
            try
            {
                if (imageFile != null && imageFile.Length > 0)
                {
                    string uniqueFileName = Guid.NewGuid().ToString() + Path.GetExtension(imageFile.FileName);
                    string imagePath = Path.Combine(env.WebRootPath, "items", "itemImage", uniqueFileName);

                    using (var fileStream = new FileStream(imagePath, FileMode.Create))
                    {
                        await imageFile.CopyToAsync(fileStream);
                    }


                    item.ImageUrl = "/items/itemImage/" + uniqueFileName;
                }


                dbContext.Item.Add(item);
                dbContext.SaveChanges();

                return RedirectToAction("Admin");
            }
            catch
            {
                ModelState.AddModelError("", "An error occurred during the image upload.");
            }

            return View(item);
        }
    }
}

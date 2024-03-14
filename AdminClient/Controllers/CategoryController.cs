using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult CreateCategory()
        {
            return View();
        }
        public IActionResult CategoryList()
        {
            return View();
        }
        public IActionResult CategoryEdit(int CategoryId)
        {
            ViewBag.CategoryId = CategoryId;
            return View();
        }
    }
}

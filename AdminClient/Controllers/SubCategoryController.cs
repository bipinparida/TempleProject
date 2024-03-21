using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class SubCategoryController : Controller
    {
        public IActionResult CreateSubCategory()
        {
            return View();
        }
        public IActionResult SubCategoryList()
        {
            return View();
        }
        public IActionResult SubCategoryEdit(int SubCategoryId)
        {
            ViewBag.SubCategoryId = SubCategoryId;
            return View();
        }
    }
}

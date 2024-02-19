using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class TemplePoojaCategoryController : Controller
    {
        public IActionResult CreateTemplePoojaCategory()
        {
            return View();
        }
        public IActionResult TemplePoojaCategoryList()
        {
            return View();
        }
        public IActionResult TemplePoojaCategoryEdit(int TemplePoojaCategoryId)
        {
            ViewBag.TemplePoojaCategoryId = TemplePoojaCategoryId;
            return View();
        }
    }
}

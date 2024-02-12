using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class PoojaCategoryController : Controller
    {
        public IActionResult CreatePoojaCategory()
        {
            return View();
        }
        public IActionResult PoojaCategoryList()
        {
            return View();
        }
        public IActionResult PoojaCategoryEdit(int PoojaCategoryId)
        {
            ViewBag.PoojaCategoryId = PoojaCategoryId;
            return View();
        }
    }
}

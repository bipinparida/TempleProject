using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class PoojaCategoryItemController : Controller
    {
        public IActionResult CreatePoojaCategoryItem()
        {
            return View();
        }
        public IActionResult PoojaCategoryItemList()
        {
            return View();
        }
        public IActionResult PoojaCategoryItemEdit(int PoojaCategoryItemId)
        {
            ViewBag.PoojaCategoryItemId = PoojaCategoryItemId;
            return View();
        }
    }
}

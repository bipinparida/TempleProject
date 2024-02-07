using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class TempleController : Controller
    {
        public IActionResult CreateTemple()
        {
            return View();
        }
        public IActionResult TempleList()
        {
            return View();
        }
        public IActionResult TempleEdit(int TempleId)
        {
            ViewBag.TempleId = TempleId;
            return View();
        }
    }
}

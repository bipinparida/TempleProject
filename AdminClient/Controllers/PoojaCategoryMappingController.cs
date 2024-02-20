using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class PoojaCategoryMappingController : Controller
    {
        public IActionResult CreatePoojaCategoryMapping()
        {
            return View();
        }
        public IActionResult PoojaCategoryMappingList()
        {
            return View();
        }
        public IActionResult PoojaCategoryMappingEdit(int PoojaCategoryMappingId)
        {
            ViewBag.PoojaCategoryMappingId = PoojaCategoryMappingId;
            return View();
        }
    }
}

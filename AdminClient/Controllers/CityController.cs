using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class CityController : Controller
    {
        public IActionResult CreateCity()
        {
            return View();
        }
        public IActionResult CityList()
        {
            return View();
        }
        public IActionResult CityEdit(int CityId)
        {
            ViewBag.CityId = CityId;
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class HoroscopeController : Controller
    {
        public IActionResult CreateHoroscope()
        {
            return View();
        }
        public IActionResult HoroscopeList()
        {
            return View();
        }
        public IActionResult HoroscopeEdit(int HoroscopeId)
        {
            ViewBag.HoroscopeId = HoroscopeId;
            return View();
        }
    }
}

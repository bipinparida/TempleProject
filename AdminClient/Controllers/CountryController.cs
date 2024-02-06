using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class CountryController : Controller
    {
        public IActionResult CreateCountry()
        {
            return View();
        }
        public IActionResult CountryList()
        {
            return View();
        }
        public IActionResult CountryEdit(int CountryId)
        {
            ViewBag.CountryId = CountryId;
            return View();
        }
    }
}

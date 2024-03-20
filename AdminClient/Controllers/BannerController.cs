using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class BannerController : Controller
    {
        public IActionResult CreateBanner()
        {
            return View();
        }
        public IActionResult BannerList()
        {
            return View();
        }
        public IActionResult BannerEdit(int BannerId)
        {
            ViewBag.BannerId = BannerId;
            return View();
        }
    }
}

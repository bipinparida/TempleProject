using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class LiveTestController : Controller
    {
        public IActionResult CreateLiveTest()
        {
            return View();
        }
        public IActionResult LiveTestList()
        {
            return View();
        }
        public IActionResult LiveTestEdit(int LiveTestId)
        {
            ViewBag.LiveTestId = LiveTestId;
            return View();
        }
    }
}

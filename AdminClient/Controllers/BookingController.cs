using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class BookingController : Controller
    {
        public IActionResult CreateBooking()
        {
            return View();
        }
        public IActionResult BookingList()
        {
            return View();
        }
        public IActionResult BookingEdit(int BookingId)
        {
            ViewBag.BookingId = BookingId;
            return View();
        }
    }
}

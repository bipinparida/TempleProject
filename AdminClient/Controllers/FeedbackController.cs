using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class FeedbackController : Controller
    {
        public IActionResult CreateFeedback()
        {
            return View();
        }
        public IActionResult FeedbackList()
        {
            return View();
        }
        public IActionResult FeedbackEdit(int FeedbackId)
        {
            ViewBag.FeedbackId = FeedbackId;
            return View();
        }
    }
}

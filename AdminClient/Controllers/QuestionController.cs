using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class QuestionController : Controller
    {
        public IActionResult CreateQuestion()
        {
            return View();
        }
        public IActionResult QuestionList()
        {
            return View();
        }
        public IActionResult QuestionEdit(int QuestionId)
        {
            ViewBag.QuestionId = QuestionId;
            return View();
        }
    }
}

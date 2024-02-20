using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class QuestionMappingController : Controller
    {
        public IActionResult CreateQuestionMapping()
        {
            return View();
        }
        public IActionResult QuestionMappingList()
        {
            return View();
        }
        public IActionResult QuestionMappingEdit(int QuestionMappingId)
        {
            ViewBag.QuestionMappingId = QuestionMappingId;
            return View();
        }
    }
}

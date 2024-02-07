using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class BhaktaController : Controller
    {
        public IActionResult CreateBhakta()
        {
            return View();
        }
        public IActionResult BhaktaList()
        {
            return View();
        }
        public IActionResult BhaktaEdit(int BhaktaId)
        {
            ViewBag.BhaktaId = BhaktaId;
            return View();
        }
    }
}

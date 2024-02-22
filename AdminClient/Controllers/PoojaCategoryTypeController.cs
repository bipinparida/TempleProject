using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class PoojaCategoryTypeController : Controller
    {
        public IActionResult CreatePoojaCategoryType()
        {
            return View();
        }
        public IActionResult PoojaCategoryTypeList()
        {
            return View();
        }
        public IActionResult PoojaCategoryTypeEdit(int PoojaCategoryTypeId)
        {
            ViewBag.PoojaCategoryTypeId = PoojaCategoryTypeId;
            return View();
        }
    }
}

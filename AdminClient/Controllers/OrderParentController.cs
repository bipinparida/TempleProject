using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class OrderParentController : Controller
    {
        public IActionResult OrderParentList()
        {
            return View();
        }
    }
}

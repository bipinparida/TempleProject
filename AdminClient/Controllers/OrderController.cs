using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class OrderController : Controller
    {
        
        public IActionResult OrderList()
        {
            return View();
        }
    }
}

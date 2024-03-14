using Microsoft.AspNetCore.Mvc;

namespace AdminClient.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult CreateProduct()
        {
            return View();
        }
        public IActionResult ProductList()
        {
            return View();
        }
        public IActionResult ProductEdit(int ProductId)
        {
            ViewBag.ProductId = ProductId;
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Test_Product.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Test_Product.Controllers
{
    public class RegisterController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

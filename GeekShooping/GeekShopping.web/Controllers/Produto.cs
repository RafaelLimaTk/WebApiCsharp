using Microsoft.AspNetCore.Mvc;

namespace GeekShopping.web.Controllers
{
    public class Produto : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

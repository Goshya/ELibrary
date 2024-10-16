using Microsoft.AspNetCore.Mvc;

namespace Elibrary.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

using Microsoft.AspNetCore.Mvc;

namespace Anipat.Controllers {
    public class BlogController : Controller {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Single()
        {
            return View();
        }
    }
}

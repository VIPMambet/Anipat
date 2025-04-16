using Microsoft.AspNetCore.Mvc;

namespace Anipat.Controllers {
    public class AboutController : Controller {
        public IActionResult Index()
        {
            return View();
        }
    }
}

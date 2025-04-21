using Microsoft.AspNetCore.Mvc;

namespace Anipat.Controllers {
    public class PagesController : Controller {
        public IActionResult Elements()
        {
            return View();
        }
    }
}

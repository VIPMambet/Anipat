using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Anipat.Controllers {
    public class TeamController : Controller {

        [Authorize]
        public IActionResult Index()
        {
            return View();
        }
    }
}

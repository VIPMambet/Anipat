using System.Diagnostics;
using Anipat.Models;
using Microsoft.AspNetCore.Mvc;

namespace Anipat.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Contact()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Contact(Message usermessage)
        {
            //if (string.IsNullOrWhiteSpace(usermessage.name))
            //{
            //    ModelState.AddModelError("name", "Поля обязательно для заполнение ");
            //}

            if (ModelState.IsValid)
            {
                return View();
            }

            else
            {
                return View("Contact", usermessage);
            }
        }

    }
}

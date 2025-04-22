using System.Diagnostics;
using Anipat.Models;
using Microsoft.AspNetCore.Mvc;

namespace Anipat.Controllers {
    public class HomeController : Controller {
        private readonly ILogger<HomeController> _logger;
        private readonly IEmailSender _sender;

        public HomeController(ILogger<HomeController> logger, IEmailSender sender)
        {
            _logger = logger;
            _sender = sender;
        }

        public IActionResult Index()
        {
            _sender.SendEmail("","","");

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


        public JsonResult SetCity(string city)
        {
            CookieOptions options = new CookieOptions();    
            options.Expires = DateTime.Now.AddMinutes(1);    
            try
            {
                Response.Cookies.Append("city",  city, options);
                return Json(city);
            }
            catch (Exception ex)
            {
                return Json(ex.Message);
            }   
        }


    }
}

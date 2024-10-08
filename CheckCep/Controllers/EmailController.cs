using CheckCep.Models;
using Microsoft.AspNetCore.Mvc;

namespace CheckCep.Controllers
{
    public class EmailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View("HomeSite");
        }

        [HttpPost]
        [ActionName("MethodEmail")]
        public IActionResult MethodEmail(string email)
        {
            email.ToString();
            User user = new User();
            user.Email = email;

            ViewBag.email = email;

            return Ok();
        }   
    }
}

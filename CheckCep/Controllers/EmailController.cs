using CheckCep.Models;
using Microsoft.AspNetCore.Mvc;

namespace CheckCep.Controllers
{
    public class EmailController : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View("Index", "Address");
        }

        [HttpPost]
        public IActionResult Index (string email,string name)
        {
            User user = new User();

            user.Email = email;
            user.Name = name;

            ViewBag.email = email;

            return RedirectToAction("Index" , "Thanks");

        }   
    }
        
}

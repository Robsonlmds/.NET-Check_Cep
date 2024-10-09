using Microsoft.AspNetCore.Mvc;

namespace CheckCep.Controllers
{
    public class ThanksController : Controller
    {

        [HttpGet]
        public IActionResult Index()
        {
            return View("thanksSite");
        }


        [HttpPost]
        public IActionResult IndexII()
        {
            return View();
        }
    }
}

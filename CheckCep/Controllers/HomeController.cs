using CheckCep.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CheckCep.Controllers
{
    public class HomeController : Controller
    {
        private readonly IEmailSender _emailSender;
        private readonly ILogger<HomeController> _logger;


        public HomeController(EmailSender emailSender)
        {
            this._emailSender = emailSender;
        }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var receiver = "Robsonlmdsgoo@gmial.com";
            var subject = "Test";
            var message = "Hello";

            await _emailSender.SendEmailAsync(receiver, subject, message);

            return View();
        }

        public IActionResult README()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}

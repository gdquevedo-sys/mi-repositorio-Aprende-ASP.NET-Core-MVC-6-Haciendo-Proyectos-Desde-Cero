using IntroducciónABootstrapUdemy.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace IntroducciónABootstrapUdemy.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {            
            ViewBag.Edad = 78;
            return View("Index", "Gustavo Delgado");
        }

        public IActionResult Privacy()
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
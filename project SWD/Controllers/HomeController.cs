using Microsoft.AspNetCore.Mvc;
using project_SWD.Models;
using System.Diagnostics;

namespace project_SWD.Controllers
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
            return View();
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
        public IActionResult Accessories()
        {
            return View();
        }
        public IActionResult crochet()
        {
            return View();
        }
        public IActionResult Earthenware()
        {
            return View();
        }
        public IActionResult Tapestry()
        {
            return View();
        }
        public IActionResult macrame()
        {
            return View();
        }
    }
}
using Microsoft.AspNetCore.Mvc;

namespace MeuSite2.Controllers
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
        public IActionResult CustomerMovements()

        {
            return View();
        }
        public IActionResult Create()

        {
            return View();
        }



    }
}
using Microsoft.AspNetCore.Mvc;
using ModelBinding_hw.Models;
using System.Diagnostics;

namespace ModelBinding_hw.Controllers
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
        [HttpPost]
        public IActionResult Index(BindingModel model)
        {
            Debug.WriteLine($"{nameof(model.First)}: {model.First}");
            Debug.WriteLine($"Second: {model.Second}");
            Debug.WriteLine($"Count: {model.Count}");
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
    }
}

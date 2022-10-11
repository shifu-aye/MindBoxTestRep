using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Diagnostics;
using WebApplication1.Models;
using SquareLib;

namespace WebApplication1.Controllers
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
        public IActionResult Index(double RadiusTB)
        {
            return View("Index", $"Площадь окружности = {Convert.ToString(new Circle(RadiusTB).Area())}");
        }

        [HttpPost]
        public IActionResult Index2(double Side1TB, double Side2TB, double Side3TB)
        {
            return View("Index", $"Площадь треугольника = {Convert.ToString(new Triangle(Side1TB, Side2TB, Side3TB).Area())}. {(new Triangle(Side1TB, Side2TB, Side3TB).IsRectangularTriangle())}");
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
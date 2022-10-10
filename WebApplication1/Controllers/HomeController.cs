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
        public IActionResult Index2()
        {
            return View();
        }
        
        [HttpPost]
        public IActionResult Index(double RadiusTB)
        {
            try
            {
                Area area = new Area();
                ViewBag.CircleArea = area.CircleАrea(RadiusTB);
                return View(area);
            }
            catch (Exception ex)
            {
                ex.ToString();
                return View();
            }
            
        }
        [HttpPost]
        public IActionResult Index2(double Side1TB, double Side2TB, double Side3TB)
        {
            try
            {
                Area area = new Area();
                ViewBag.TriangleArea = area.TriangleАrea(Side1TB, Side2TB, Side3TB);
                return View(area);
            }
            catch (Exception ex)
            {
                ex.ToString();
                return View();
            }    
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
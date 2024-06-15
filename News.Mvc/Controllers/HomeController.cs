using Microsoft.AspNetCore.Mvc;
using News.Models;
using News.Services.Abstract;
using System.Diagnostics;

namespace News.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly INewsService _newService;
        public HomeController(ILogger<HomeController> logger, INewsService newService)
        {
            _logger = logger;
            _newService = newService;
        }

        public async Task<IActionResult> Index()
        {
            var response = await _newService.GetAllAsync();
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

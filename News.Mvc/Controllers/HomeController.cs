using Microsoft.AspNetCore.Mvc;
using News.Services.Abstract;

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
        [HttpGet]
        public async Task<IActionResult> Index(int pageNumber)
        {
            var response = await _newService.GetAllAsync(null, null, pageNumber, 5);
            return View(response);
        }
        [HttpGet]
        public async Task<IActionResult> GetItems(string query, string category, int pageNumber = 1)
        {
            var response = await _newService.GetAllAsync(query, category, pageNumber, 5);
            return Json(response);
        }

        [HttpGet]
        public async Task<IActionResult> Detail(int itemId)
        {
            var response = await _newService.GetDetailAsync(itemId);
            return View(response);
        }
    }
}

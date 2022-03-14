using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WWW.Models;
using WWW.DAL;

namespace WWW.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            APIManager apiManager = new APIManager();
            await apiManager.GetPlanets();
            await apiManager.GetTranslation();

            return View(Tuple.Create(await apiManager.GetPlanets(), await apiManager.GetTranslation()));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
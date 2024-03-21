using GunsOfTheOldWest.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Reflection;

namespace GunsOfTheOldWest.Controllers
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

        [HttpPost]
        public IActionResult Winner(SubmissionModel model)
        {
            
            model.SubmittedDate = DateTime.Now;
            return RedirectToAction("Summary", model);
           
        }

        [HttpGet]
        public IActionResult Winner()
        {
            return View();
        }

        public IActionResult Summary()
        {
            SubmissionModel model = new SubmissionModel();
            model.SubmittedDate = DateTime.Now;
            return View(model);
        }

        public IActionResult Reload()
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

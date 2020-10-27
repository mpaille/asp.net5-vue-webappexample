using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Mpaille.AspNet5VueWebAppExample.Services.Core;
using Mpaille.AspNet5VueWebAppExample.ViewModels;
using Mpaille.AspNet5VueWebAppExample.Webapp.Core;
using System.Diagnostics;

namespace Mpaille.AspNet5VueWebAppExample.Webapp.Controllers
{
    public class HomeController : BaseController<HomeController>
    {
        public HomeController(ILogger<HomeController> logger, IServices services) : base(logger, services) { }

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
    }
}

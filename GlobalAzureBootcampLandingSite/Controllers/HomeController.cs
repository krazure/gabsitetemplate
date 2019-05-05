using GlobalAzureBootcampLandingSite.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Diagnostics;
using System.Text;

namespace GlobalAzureBootcampLandingSite.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View(JsonConvert.DeserializeObject<ConferenceInfo>(
                System.IO.File.ReadAllText("data.json", new UTF8Encoding(false))
            ));
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

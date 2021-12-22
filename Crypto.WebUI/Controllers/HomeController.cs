using Crypto.WebUI.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using RestSharp;
using System.Diagnostics;
using System.Net.WebSockets;
using System.Text;
using System.Text.Json;

namespace Crypto.WebUI.Controllers
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
            var clientUrl = "https://min-api.cryptocompare.com/data/generateAvg?fsym=BTC&tsym=TRY&e=BTCTurk";
            IRestApi restApi = new RestApiModel(url: clientUrl, Method.GET);
            var response = restApi.GetRestResponse();
            var content = JsonConvert.DeserializeObject<CoinJsonModel>(response.Content);
            var info = content?.Raw;
            return View(model: info);
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
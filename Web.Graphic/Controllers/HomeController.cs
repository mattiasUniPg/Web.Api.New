using Microsoft.AspNetCore.Mvc;
using Product.Api.SQL;
using Product.Api.Models;
using System.Diagnostics;
using Web.Graphic.Models;
using System.Text.Json;

namespace Web.Graphic.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IHttpClientFactory _client;
        public string Message { get; set; }


        public HomeController(ILogger<HomeController> logger, IHttpClientFactory client)
        {
            _logger = logger;
            _client = client;
        }

        [HttpGet]
        public async Task<IActionResult> IndexAsync()
        {
            var client = _client.CreateClient("ProductApi");
            Message = await client.GetStringAsync("Product/List");
            var M= JsonSerializer.Deserialize<IEnumerable<ProductDto>>(Message);
            return View(M);
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
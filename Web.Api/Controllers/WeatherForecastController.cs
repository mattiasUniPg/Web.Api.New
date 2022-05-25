using Microsoft.AspNetCore.Mvc;

namespace Web.Api.Controllers
{
    [ApiController]
    [Route(template:"api/test")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name ="Paperino")]
        public bool Paperino()
        {
            return true;
        }

        [HttpGet(template: "CheckStatus")]
        public bool CheckStatus()
        {

            return true;
        }

        [HttpPost(template: "Hello/{name}")]
        public string Hello(string name) {


            return $"Hello {name}";
        }


    }

}
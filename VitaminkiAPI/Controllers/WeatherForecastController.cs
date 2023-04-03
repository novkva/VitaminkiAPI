using Microsoft.AspNetCore.Mvc;

namespace VitaminkiAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public void GetProduct(int id)
        {

        }

        [HttpGet]
        public void GetVitamin(int id)
        {

        }

        [HttpPost]
        public void AddProduct()
        {

        }
    }
}
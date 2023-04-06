using Microsoft.AspNetCore.Mvc;

namespace VitaminkiAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly ILogger<ProductController> _logger;

        public ProductController(ILogger<ProductController> logger)
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
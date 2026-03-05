using FundamentalsOfNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace FundamentalsOfNet.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _service;

        public ProductController(IProductService service)
        {
            _service = service;
        }

        [HttpGet]
        public IEnumerable<string> GetProducts()
        {
            return _service.GetProducts();
        }
    }
}
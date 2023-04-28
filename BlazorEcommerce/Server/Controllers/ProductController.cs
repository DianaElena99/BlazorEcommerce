using BlazorEcommerce.Server.Data;
using BlazorEcommerce.Server.Migrations;
using BlazorEcommerce.Server.Services.ProductService;
using BlazorEcommerce.Shared.Models;
using BlazorEcommerce.Shared.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Reflection.Metadata.Ecma335;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<Product>>>> GetAllProducts()
        {
            var response = await _productService.GetAllProducts();
            return Ok(response);
        }

        [HttpGet("{productId}")]
        public async Task<ActionResult<ServiceResponse<Product>>> GetProductById(int productId)
        {
            var response = await _productService.GetProductById(productId);
            return Ok(response);
        }
    }
}

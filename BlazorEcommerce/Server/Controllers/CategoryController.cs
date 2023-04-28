using BlazorEcommerce.Server.Services.CategoryService;
using BlazorEcommerce.Shared.Models;
using BlazorEcommerce.Shared.Utils;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazorEcommerce.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<ProductCategory>>>> GetCategories()
        {
            var response = await _categoryService.GetAllCategories();
            return Ok(response);
        }

        [HttpGet("{categoryId}")]
        public async Task<ActionResult<ServiceResponse<ProductCategory>>> GetCategoryById(int categoryId)
        {
            var result = await _categoryService.GetCategory(categoryId);
            return Ok(result);
        }
    }
}

using BlazorEcommerce.Shared.Models;
using BlazorEcommerce.Shared.Utils;

namespace BlazorEcommerce.Server.Services.CategoryService
{
    public interface ICategoryService
    {
        Task<ServiceResponse<List<ProductCategory>>> GetAllCategories();
        Task<ServiceResponse<ProductCategory>> GetCategory(int id);
    }
}

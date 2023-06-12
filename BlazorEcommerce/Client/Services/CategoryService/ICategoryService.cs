using BlazorEcommerce.Shared.Models;
using BlazorEcommerce.Shared.Utils;

namespace BlazorEcommerce.Client.Services.CategoryServices
{
    public interface ICategoryService
    {
        List<ProductCategory> productCategories { get; set; }
        Task GetAllCategories();
        Task<ServiceResponse<ProductCategory>> GetCategoryById(int id);
    }
}

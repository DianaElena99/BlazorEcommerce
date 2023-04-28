using BlazorEcommerce.Shared.Models;
using BlazorEcommerce.Shared.Utils;

namespace BlazorEcommerce.Client.Services.ProductServices
{
    public interface IProductService
    {
        List<Product> Products { get; set; }
        Task GetProducts();
        Task<ServiceResponse<Product>> GetProductById(int productId);
        Task<List<String>> GetProductSearchSuggestions(string searchString);
    }
}

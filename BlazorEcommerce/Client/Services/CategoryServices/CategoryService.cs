using BlazorEcommerce.Shared.Models;
using BlazorEcommerce.Shared.Utils;
using System.Net.Http.Json;

namespace BlazorEcommerce.Client.Services.CategoryServices
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _httpClient;
        
        public CategoryService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public List<ProductCategory> productCategories { get ; set ; }

        public async Task GetAllCategories()
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<ProductCategory>>>("/api/ProductCategory");
            if (result.Data != null)
            {
                productCategories = result.Data;
            }
        }

        public async Task<ServiceResponse<ProductCategory>> GetCategoryById(int id)
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<ProductCategory>>($"/api/ProductCategory/{id}");
            return result;
        }
    }
}

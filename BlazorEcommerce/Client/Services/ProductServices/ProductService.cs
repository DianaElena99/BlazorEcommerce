using BlazorEcommerce.Shared.Models;
using BlazorEcommerce.Shared.Utils;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace BlazorEcommerce.Client.Services.ProductServices
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _httpClient;
        public ProductService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }
        public List<Product> Products { get; set; } = new List<Product>();

        public async Task<ServiceResponse<Product>> GetProductById(int productId)
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<Product>>($"/api/Product/{productId}");
            return result;
        }

        public async Task GetProducts()
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<List<Product>>>("api/Product/");
            if (result.Data != null)
            {
                Products = result.Data;
            }
        }

        
    }
}

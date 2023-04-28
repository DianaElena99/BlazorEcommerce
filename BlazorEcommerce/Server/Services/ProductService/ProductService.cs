using BlazorEcommerce.Server.Data;
using BlazorEcommerce.Shared.Models;
using BlazorEcommerce.Shared.Utils;

namespace BlazorEcommerce.Server.Services.ProductService
{
    public class ProductService : IProductService
    {
        private readonly DataContext _dataContext;

        public ProductService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<ServiceResponse<Product>> CreateProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<bool>> DeleteProduct(int productId)
        {
            throw new NotImplementedException();
        }

        public async Task<ServiceResponse<List<Product>>> GetAllProducts()
        {
            var response = new ServiceResponse<List<Product>> 
                { 
                    Data = await _dataContext.Products.ToListAsync(), 
                };  
            return response; 
        }

        public async Task<ServiceResponse<Product>> GetProductById(int productId)
        {
            var response = new ServiceResponse<Product>
            {
                Data = await _dataContext.Products.FirstOrDefaultAsync(p => p.Id == productId),
            };
            return response;
        }

        public async Task<ServiceResponse<Product>> UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}

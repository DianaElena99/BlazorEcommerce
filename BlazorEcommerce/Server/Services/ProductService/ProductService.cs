using BlazorEcommerce.Server.Data;
using BlazorEcommerce.Shared.Models;
using BlazorEcommerce.Shared.Utils;
using Microsoft.EntityFrameworkCore;

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
            _dataContext.Products.Add(product);
            await _dataContext.SaveChangesAsync();
            return new ServiceResponse<Product> { Data = product };
        }

        public async Task<ServiceResponse<bool>> DeleteProduct(int productId)
        {
            var dbProduct = await _dataContext.Products.FindAsync(productId);
            if (dbProduct != null)
            {
                return new ServiceResponse<bool>
                {
                    Success = true,
                    Data = false,
                    Message = "Product not found"
                };
            }

            _dataContext.Products.Remove(dbProduct);
            await _dataContext.SaveChangesAsync();
            return new ServiceResponse<bool> { Data = true };
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

        //TODO
        public async Task<ServiceResponse<Product>> UpdateProduct(Product product)
        {
            throw new NotImplementedException();
        }
    }
}

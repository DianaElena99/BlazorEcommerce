using BlazorEcommerce.Shared.Models;
using BlazorEcommerce.Shared.Utils;

namespace BlazorEcommerce.Server.Services.CategoryService
{
    public class CategoryService : ICategoryService
    {
        private readonly DataContext _dataContext;

        public CategoryService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<ServiceResponse<List<ProductCategory>>> GetAllCategories()
        {
            return new ServiceResponse<List<ProductCategory>> { Data = await _dataContext.ProductCategories.ToListAsync() };
        }

        public async Task<ServiceResponse<ProductCategory>> GetCategory(int id)
        {
            return new ServiceResponse<ProductCategory> { Data = await _dataContext.ProductCategories.FirstOrDefaultAsync(c => c.Id == id) };
        }
    }
}

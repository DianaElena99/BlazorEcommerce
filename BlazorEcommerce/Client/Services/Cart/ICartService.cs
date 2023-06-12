using BlazorEcommerce.Shared.Models;

namespace BlazorEcommerce.Client.Services.Cart
{
    public interface ICartService
    {
        public Task AddProductToCart(Product product);
        public Task RemoveProductFromCart(int productId);
        public Task UpdateQuantity(Product product);
        public Task<List<Product>> LoadCart();
        public Task PlaceOrder();
    }
}

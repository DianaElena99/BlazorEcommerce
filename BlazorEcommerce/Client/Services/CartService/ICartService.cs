using BlazorEcommerce.Shared.Models;

namespace BlazorEcommerce.Client.Services.Cart
{
    public interface ICartService
    {
        public Task AddProductToCart(CartProduct product);
        public Task RemoveProductFromCart(int productId);
        public Task UpdateQuantity(CartProduct product);
        public Task<List<Product>> LoadCart();
        public Task PlaceOrder();
    }
}

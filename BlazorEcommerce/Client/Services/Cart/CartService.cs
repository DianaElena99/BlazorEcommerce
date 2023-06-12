using BlazorEcommerce.Shared.Models;

namespace BlazorEcommerce.Client.Services.Cart
{
    public class CartService : ICartService
    {
        public Task AddProductToCart(Product product)
        {
            throw new NotImplementedException();
        }

        public Task<List<Product>> LoadCart()
        {
            throw new NotImplementedException();
        }

        public Task PlaceOrder()
        {
            throw new NotImplementedException();
        }

        public Task RemoveProductFromCart(int productId)
        {
            throw new NotImplementedException();
        }

        public Task UpdateQuantity(Product product)
        {
            throw new NotImplementedException();
        }
    }
}

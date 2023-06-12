using BlazorEcommerce.Shared.Models;
using BlazorEcommerce.Shared.Utils;

namespace BlazorEcommerce.Server.Services.CartService
{
    public interface ICartService
    {
        Task<ServiceResponse<List<CartProductResponse>>> GetCartProducts(List<CartProduct> cartItems);
        Task<ServiceResponse<List<CartProductResponse>>> StoreCartItems(List<CartProduct> cartItems);
        Task<ServiceResponse<int>> GetCartItemsCount();
        Task<ServiceResponse<List<CartProductResponse>>> GetDbCartProducts(int? userId = null);
        Task<ServiceResponse<bool>> AddToCart(CartProduct cartItem);
        Task<ServiceResponse<bool>> UpdateQuantity(CartProduct cartItem);
        Task<ServiceResponse<bool>> RemoveItemFromCart(int productId, int productTypeId);
    }
}

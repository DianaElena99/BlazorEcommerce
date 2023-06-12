using BlazorEcommerce.Shared.Models;
using BlazorEcommerce.Shared.Utils;
using Blazored.LocalStorage;
using System.Net.Http.Json;
using static System.Net.WebRequestMethods;

namespace BlazorEcommerce.Client.Services.Cart
{
    public class CartService : ICartService
    {
        private readonly HttpClient _httpClient;
        private readonly ILocalStorageService _localStorage;

        public CartService(HttpClient httpClient, ILocalStorageService localStorage)
        {
            _httpClient = httpClient;
            _localStorage = localStorage;
        }

        public event Action OnChange;

        public async Task AddProductToCart(CartProduct product)
        {
            await _httpClient.PostAsJsonAsync<CartProduct>("/api/cart/add", product);

            var cart = await _localStorage.GetItemAsync<List<CartProduct>>("cart");
            if (cart == null)
            {
                cart = new List<CartProduct>();
            }

            var sameItem = cart.Find(x => x.ProductId == product.ProductId);
            if (sameItem == null)
            {
                cart.Add(product);
            }
            else
            {
                sameItem.Quantity += product.Quantity;
            }
            await GetCartItemsCount();
        }

        private async Task GetCartItemsCount()
        {
            var result = await _httpClient.GetFromJsonAsync<ServiceResponse<int>>("api/cart/count");
            var count = result.Data;

            await _localStorage.SetItemAsync<int>("cartItemsCount", count);
            OnChange?.Invoke();
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

        public Task UpdateQuantity(CartProduct product)
        {
            throw new NotImplementedException();
        }
    }
}

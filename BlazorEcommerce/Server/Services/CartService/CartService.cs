using BlazorEcommerce.Shared.Models;
using BlazorEcommerce.Shared.Utils;
using Microsoft.EntityFrameworkCore;
using Stripe;

namespace BlazorEcommerce.Server.Services.CartService
{
    public class CartService : ICartService
    {
        private readonly DataContext _dataContext;

        public CartService(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public async Task<ServiceResponse<bool>> AddToCart(CartProduct cartItem)
        {
            var product = await _dataContext.CartProducts.Where(cp => cp.ProductId == cartItem.ProductId).FirstOrDefaultAsync();

            if (product == null) 
            {
                _dataContext.CartProducts.Add(cartItem);               
            }
            else
            {
                product.Quantity += cartItem.Quantity;
            }

            await _dataContext.SaveChangesAsync();

            return new ServiceResponse<bool> { Success = true };
        }

        public async Task<ServiceResponse<int>> GetCartItemsCount()
        {
            var count = (await _dataContext.CartProducts.Where(cp => cp.UserId == 1).ToListAsync()).Count();
            return new ServiceResponse<int> { Data = count };
        }

        public async Task<ServiceResponse<List<CartProductResponse>>> GetDbCartProducts(int? userId = null)
        {
            return await GetCartProducts(await _dataContext.CartProducts
                .Where(ci => ci.UserId == userId).ToListAsync());
        }

        public async Task<ServiceResponse<List<CartProductResponse>>> GetCartProducts(List<CartProduct> cartItems)
        {
            var result = new ServiceResponse<List<CartProductResponse>>
            {
                Data = new List<CartProductResponse>()
            };

            foreach (var cartItem in cartItems)
            {
                var product = await _dataContext.Products.Where(p => p.Id == cartItem.ProductId).FirstOrDefaultAsync();

                if (product == null)
                {
                    continue;
                }

                var productVariant = await _dataContext.ProductVariants
                    .Where(pv => pv.ProductId == cartItem.ProductId 
                        && pv.ProductTypeId == cartItem.ProductTypeId)
                    .FirstOrDefaultAsync();

                if (productVariant == null)
                {
                    continue;
                }

                var responseProduct = new CartProductResponse
                {
                    ProductId = product.Id,
                    ProductTypeId = productVariant.ProductTypeId,
                    ProductType = productVariant.ProductType.Name,
                    Title = product.Name,
                    Quantity = cartItem.Quantity,
                    ImageUrl = product.ImageURL,
                    Price = productVariant.Price
                };
                result.Data.Add(responseProduct);
            }
            return result;
        }

        public async Task<ServiceResponse<bool>> RemoveItemFromCart(int productId, int productTypeId)
        {
            var response = new ServiceResponse<bool>();
            var product = await _dataContext.CartProducts.Where(cp => cp.ProductId == productId && cp.ProductTypeId == productTypeId).FirstOrDefaultAsync();
            if (product !=null)
            {
                _dataContext.CartProducts.Remove(product);
                await _dataContext.SaveChangesAsync();
                response.Data = true;
            }
            else
            {
                response.Data = false;
                response.Message = "Cart product doesn't exist";
            }
            return response;
        }

        public async Task<ServiceResponse<List<CartProductResponse>>> StoreCartItems(List<CartProduct> cartItems)
        {
            _dataContext.CartProducts.AddRange(cartItems);
            await _dataContext.SaveChangesAsync();
            return await GetDbCartProducts();
        }

        public async Task<ServiceResponse<bool>> UpdateQuantity(CartProduct cartItem)
        {
            var response = new ServiceResponse<bool>();
            var product = await _dataContext.CartProducts.Where(p => p.ProductId == cartItem.ProductId).FirstOrDefaultAsync(); 
            if (product != null)
            {
                product.Quantity = cartItem.Quantity;
                response.Success = true;
                response.Data = true;

                await _dataContext.SaveChangesAsync();
            }
            else
            {
                response.Data = false;
                response.Message = "Cart product doesn't exist";
            }
            return response;
        }
    }
}

using BlazorEcommerce.Server.Services.CartService;
using BlazorEcommerce.Shared.Models;
using BlazorEcommerce.Shared.Utils;
using Microsoft.EntityFrameworkCore;

namespace BlazorEcommerce.Server.Services.OrderService
{
    public class OrderService : IOrderService
    {
        private readonly DataContext _dataContext;
        private readonly ICartService _cartService;

        public OrderService(DataContext context, ICartService cartService)
        {
            _dataContext = context;
            _cartService = cartService;
        }   

        public async Task<ServiceResponse<OrderDetailsResponse>> GetOrderDetails(int orderId)
        {
            var response = new ServiceResponse<OrderDetailsResponse>();



            return response;
        }

        public async Task<ServiceResponse<List<OrderOverviewResponse>>> GetOrders()
        {
            var response = new ServiceResponse<List<OrderOverviewResponse>>();

            var orders = await _dataContext.Orders
                .Include(o => o.OrderProducts)
                .ThenInclude(op => op.Product)
                .OrderByDescending(o => o.OrderDate)
                .ToListAsync();

            var orderOverview = new List<OrderOverviewResponse>();

            orders.ForEach(o => orderOverview.Add(new OrderOverviewResponse
            {
                Id = o.Id,
                OrderDate = o.OrderDate,
                TotalPrice = o.TotalPrice,
                Product = o.OrderProducts.Count() > 1 ? $"{o.OrderProducts.First().Product.Name} and others..." : $"{o.OrderProducts.First().Product.Name}",
                ProductImageUrl = o.OrderProducts.First().Product.ImageURL
            })) ;

            response.Data = orderOverview;

            return response;
        }

        public async Task<ServiceResponse<bool>> PlaceOrder(int userId)
        {
            var products = (await _cartService.GetDbCartProducts(userId)).Data;
            decimal totalPrice = 0;
            products.ForEach(product => totalPrice += product.Price * product.Quantity);

            var orderProducts = new List<OrderProduct>();
            products.ForEach(product => orderProducts.Add(
                new OrderProduct
                {
                    ProductId = product.ProductId,
                    ProductTypeId = product.ProductTypeId,
                    Quantity = product.Quantity,
                    TotalPrice = product.Price * product.Quantity
                }
            ));

            var order = new Order
            {
                UserId = userId,
                OrderDate = DateTime.Now,
                TotalPrice = totalPrice,
                OrderProducts = orderProducts
            };
            _dataContext.Orders.Add(order);
            _dataContext.CartProducts.RemoveRange(_dataContext.CartProducts
                .Where(ci => ci.UserId == userId));

            await _dataContext.SaveChangesAsync();

            return new ServiceResponse<bool> { Data = true };
        }
    }
}

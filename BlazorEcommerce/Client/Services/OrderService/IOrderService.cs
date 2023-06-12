using BlazorEcommerce.Shared.Models;
using BlazorEcommerce.Shared.Utils;

namespace BlazorEcommerce.Client.Services.OrderService
{
    public interface IOrderService
    {
        public Task<string> PlaceOrder();
        public Task<List<OrderOverviewResponse>> GetOrders();
        public Task<OrderDetailsResponse> GetOrderDetails(int orderId);

    }
}
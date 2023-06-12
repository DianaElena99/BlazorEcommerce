using BlazorEcommerce.Server.Services.CartService;
using BlazorEcommerce.Server.Services.OrderService;
using BlazorEcommerce.Shared.Utils;
using Stripe;
using Stripe.Checkout;

namespace BlazorEcommerce.Server.Services.PaymentService
{
    public class PaymentService : IPaymentService
    {
        private readonly IOrderService orderService;
        private readonly ICartService cartService;

        public PaymentService(IOrderService _orderService, ICartService _cartService)
        {
            orderService = _orderService;
            cartService = _cartService;

            StripeConfiguration.ApiKey = "";
        }
        public async Task<Session> CreateCheckoutSession()
        {
            var lineItems = new List<SessionLineItemOptions>();

            var options = new SessionCreateOptions
            {
                CustomerEmail = "",
                ShippingAddressCollection = new SessionShippingAddressCollectionOptions
                {
                    AllowedCountries = new List<string> { "US", "EUR", "RON" }
                },
                PaymentMethodTypes = new List<string>
                {
                    "card"
                },
                LineItems = lineItems,
                Mode = "payment",
                SuccessUrl = "https://localhost:7226/order-success",
                CancelUrl = "https://localhost:7226/cart"
            };

            var service = new SessionService();
            Session session = service.Create(options);
            return session;
        }

        public Task<ServiceResponse<bool>> FulfillOrder(HttpRequest request)
        {
            throw new NotImplementedException();
        }
    }
}

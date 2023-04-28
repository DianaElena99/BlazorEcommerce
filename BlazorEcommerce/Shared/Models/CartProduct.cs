using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorEcommerce.Shared.Models
{
    public class CartProduct
    {
        public int ProductId { get; set; }
        public int UserId { get; set; }
        public int Quantity { get; set; } = 1;
    }
}

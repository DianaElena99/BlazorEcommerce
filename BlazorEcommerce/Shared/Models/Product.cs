using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorEcommerce.Shared.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public string ImageURL { get; set; } = string.Empty;

        [Column(TypeName="decimal(18,2)")]
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public ProductCategory? Category { get; set; }
    }
}

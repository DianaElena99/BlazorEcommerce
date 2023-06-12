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

        public int CategoryId { get; set; }
        public ProductCategory? Category { get; set; }
        public List<ProductVariant> Variants { get; set; } = new List<ProductVariant>(); 
    }
}

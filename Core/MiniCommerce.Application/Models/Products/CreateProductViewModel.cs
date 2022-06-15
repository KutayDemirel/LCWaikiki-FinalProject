using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Application.Models.Products
{
    public class CreateProductViewModel
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public string Color { get; set; }
        public string ImageUrl { get; set; }
        public bool IsOfferable { get; set; }
        public bool IsSold { get; set; }
    }
}

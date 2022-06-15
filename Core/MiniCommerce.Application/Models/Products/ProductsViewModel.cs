using MiniCommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Application.Models.Products
{
    public class ProductsViewModel
    {
        public int Id{ get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public string Color { get; set; }
        public string Category { get; set; }
        public string Brand { get; set; }
        public string Usage { get; set; }
        public string ImageUrl { get; set; }
        public bool IsSold { get; set; }
        public bool IsOfferable { get; set; }

        //public Category Category { get; set; }
    }
}

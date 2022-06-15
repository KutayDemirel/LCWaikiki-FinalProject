using Microsoft.AspNetCore.Http;

namespace MiniCommerce.UI.Models
{
    public class ProductModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string Description{ get; set; }
        public string Category{ get; set; }
        public string Color{ get; set; }
        public string Brand{ get; set; }
        public string Usage{ get; set; }
        public int CategoryId { get; set; }
        //public int UserId { get; set; }
        public int? ColorId { get; set; }
        public int UsageId { get; set; }
        public int? BrandId { get; set; }
        public bool IsOfferable { get; set; }
        public bool IsSold{ get; set; }

    }
}

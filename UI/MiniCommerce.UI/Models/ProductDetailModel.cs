namespace MiniCommerce.UI.Models
{
    public class ProductDetailModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
        public string ColorName { get; set; }
        public string BrandName { get; set; }
        public string UsageName { get; set; }
        public int CategoryId { get; set; }
        public int? ColorId { get; set; }
        public int UsageId { get; set; }
        public int? BrandId { get; set; }
        public bool IsOfferable { get; set; }
        public bool IsSold { get; set; }
    }
}

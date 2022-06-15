using MiniCommerce.UI.Models;

namespace MiniCommerce.UI.ViewModels
{
    public class ProductOfferViewModel
    {
        public ProductModel Product { get; set; }
        public AddOfferModel Offer { get; set; }

        public decimal OfferOption(decimal offerPercentage)
        {
            decimal price = (offerPercentage * Product.Price) /100;
            return price;
        }
    }
}

using MiniCommerce.UI.Models;
using System.Collections.Generic;

namespace MiniCommerce.UI.ViewModels
{
    public class ApproveOfferViewModel
    {
        public IReadOnlyList<ProductModel> Products { get; set; }
        public ApproveOfferModel Offer { get; set; }
        public IEnumerable<GetOffersModel> GetOffers { get; set; }
    }
}

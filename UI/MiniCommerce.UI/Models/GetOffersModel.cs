using System.ComponentModel;

namespace MiniCommerce.UI.Models
{
    public class GetOffersModel
    {
        public int Id { get; set; }
        public int ProductId { get; set; }
        [DisplayName("Offer Price")]
        public decimal Price { get; set; }
        public bool IsApproved { get; set; }

    }
}

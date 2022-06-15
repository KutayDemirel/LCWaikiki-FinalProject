using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Application.Models.Offers
{
    public class CreateOfferViewModel
    {
        public decimal Price { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
    }
}

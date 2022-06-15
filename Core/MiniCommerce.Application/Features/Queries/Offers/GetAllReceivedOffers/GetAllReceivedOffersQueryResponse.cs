using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Application.Features.Queries.Offers.GetAllReceivedOffers
{
    public class GetAllReceivedOffersQueryResponse
    {
        public int Id { get; set; }
        public decimal Price { get; set; }
        public bool IsApproved { get; set; }
        public int ProductId { get; set; }
        public int UserId { get; set; }
    }
}

using MediatR;
using MiniCommerce.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Application.Features.Queries.Offers.GetAllReceivedOffers
{
    public class GetAllReceivedOffersQuery : IRequest<ServiceResponse<IReadOnlyList<GetAllReceivedOffersQueryResponse>>>
    {
        public int UserId { get; set; }
    }
}

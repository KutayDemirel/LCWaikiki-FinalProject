using MediatR;
using MiniCommerce.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Application.Features.Commands.Offers.Adds
{
    public class AddOfferCommand : IRequest<ServiceResponse<bool>>
    {
        public decimal Price { get; set; }
        public int UserId { get; set; }
        public int ProductId { get; set; }
    }
}

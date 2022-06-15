using MediatR;
using MiniCommerce.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Application.Features.Commands.Offers.Updates.ApproveOffer
{
    public class ApproveOfferCommand : IRequest<ServiceResponse<bool>>
    {
        public int Id { get; set; }
        //public decimal Price { get; set; }
        //public int ProductId { get; set; }
        //public int UserId { get; set; }
        //public bool IsApproved { get; set; }
    }
}

using MediatR;
using MiniCommerce.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Application.Features.Commands.Offers.Deletes
{
    public class DeleteOfferCommand : IRequest<ServiceResponse<bool>>
    {
        public int Id { get; set; }
    }
}

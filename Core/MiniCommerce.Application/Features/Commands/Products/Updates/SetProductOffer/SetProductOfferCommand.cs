using MediatR;
using MiniCommerce.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Application.Features.Commands.Products.Updates.SetProductOffer
{
    public class SetProductOfferCommand : IRequest<ServiceResponse<bool>>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public int ColorId { get; set; }
        public int BrandId { get; set; }
        public int UsageId { get; set; }
        public int CategoryId { get; set; }
        public bool IsSold { get; set; }
        public bool IsOfferable { get; set; }
    }
}

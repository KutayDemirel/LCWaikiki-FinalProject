using MediatR;
using MiniCommerce.Application.Models;
using MiniCommerce.Application.Models.Products;
using System;
using System.Text.Json.Serialization;

namespace MiniCommerce.Application.Features.Commands.Products.Adds
{
    public class AddProductCommand : IRequest<ServiceResponse<bool>>
    {
        public string Name { get; set; }
        [JsonIgnore]
        public int UserId{ get; set; }
        public int CategoryId { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public int? ColorId { get; set; }
        public int UsageId { get; set; }
        public int? BrandId { get; set; }
        public string ImageUrl { get; set; }
        public bool IsOfferable { get; set; }
    
        public DateTime CreatedDate { get; set; }
    }
}

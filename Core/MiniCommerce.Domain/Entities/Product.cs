using Microsoft.AspNetCore.Http;
using MiniCommerce.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Domain.Entities
{
    public class Product : BaseEntity
    {
        public string Name { get; set; }
        public int Stock { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public bool IsOfferable { get; set; }
        public bool IsSold { get; set; }
        public ICollection<Offer> Offers { get; set; }
        public int UserId { get; set; }
        public User User { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public int? BrandId { get; set; }
        public Brand Brand{ get; set; }
        public int UsageId { get; set; }
        public Usage Usage { get; set; }
        public int? ColorId { get; set; }
        public Color Color { get; set; }

        [NotMapped]
        [Display(Name = "Image")]
        //[Required(ErrorMessage = "Please choose image to upload.")]
        public IFormFile Image { get; set; }

    }

}

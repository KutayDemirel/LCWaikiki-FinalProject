using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MiniCommerce.UI.Models
{
    public class AddProductModel
    {
        //[Required]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public string ImageUrl { get; set; }
        public string Description { get; set; }
        public int CategoryId { get; set; }
        public int Stock { get; set; }
        public int? ColorId { get; set; }
        public int UsageId { get; set; }
        public int? BrandId { get; set; }
        //public IEnumerable<SelectListItem> Category { get; set; }
        //public IEnumerable<SelectListItem> Brand { get; set; }
        //public IEnumerable<SelectListItem> Color { get; set; }
        //public IEnumerable<SelectListItem> Usage { get; set; }
        public bool IsOfferable { get; set; }
        public bool IsSold { get; set; }
        [NotMapped]
        [Display(Name = "Image")]
        //[Required(ErrorMessage = "Please choose image to upload.")]
        public IFormFile Image { get; set; }
    }
}

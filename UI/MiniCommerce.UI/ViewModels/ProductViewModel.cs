using MiniCommerce.UI.Models;
using System.Collections.Generic;

namespace MiniCommerce.UI.ViewModels
{
    public class ProductViewModel
    {
        public IReadOnlyList<ProductModel> Products { get; set; }
        public IReadOnlyList<CategoryModel> Categories { get; set; }
    }
}

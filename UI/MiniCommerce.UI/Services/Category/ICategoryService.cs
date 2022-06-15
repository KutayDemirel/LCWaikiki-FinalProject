using MiniCommerce.UI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiniCommerce.UI.Services.Category
{
    public interface ICategoryService
    {
        Task<ServiceResponse<List<CategoryModel>>> GetAllCategories();
    }
}

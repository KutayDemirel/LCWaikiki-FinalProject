using MiniCommerce.UI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiniCommerce.UI.Services.Brand
{
    public interface IBrandService
    {
        Task<ServiceResponse<IReadOnlyList<BrandModel>>> GetAllBrands();
    }
}

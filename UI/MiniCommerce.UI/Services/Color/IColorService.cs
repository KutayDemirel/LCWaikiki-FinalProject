using MiniCommerce.UI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiniCommerce.UI.Services.Color
{
    public interface IColorService
    {
        Task<ServiceResponse<IReadOnlyList<ColorModel>>> GetAllColors();
    }
}

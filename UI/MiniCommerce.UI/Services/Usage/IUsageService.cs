using MiniCommerce.UI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiniCommerce.UI.Services.Usage
{
    public interface IUsageService
    {
        Task<ServiceResponse<IReadOnlyList<UsageModel>>> GetAllUsages();
    }
}

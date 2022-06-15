using MediatR;
using MiniCommerce.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Application.Features.Queries.Usages.GetUsages
{
    public class GetAllUsagesQuery : IRequest<ServiceResponse<IReadOnlyList<GetAllUsagesQueryResponse>>>
    {
    }
}

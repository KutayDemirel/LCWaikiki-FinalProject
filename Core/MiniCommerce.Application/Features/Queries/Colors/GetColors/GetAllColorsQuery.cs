using MediatR;
using MiniCommerce.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Application.Features.Queries.Colors.GetColors
{
    public class GetAllColorsQuery : IRequest<ServiceResponse<IReadOnlyList<GetAllColorsQueryResponse>>>
    {
    }
}

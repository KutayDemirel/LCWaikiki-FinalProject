using MediatR;
using MiniCommerce.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Application.Features.Queries.Brands.GetBrands
{
    public class GetAllBrandsQuery : IRequest<ServiceResponse<IReadOnlyList<GetAllBrandsQueryResponse>>>
    {

    }
}

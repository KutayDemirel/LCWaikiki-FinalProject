using MediatR;
using MiniCommerce.Application.Models;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Application.Features.Queries.Products.GetProductList
{
    public class GetAllProductsQuery : IRequest<ServiceResponse<IReadOnlyList<GetAllProductsQueryResponse>>>
    {

    }
}

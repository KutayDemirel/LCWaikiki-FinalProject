using MediatR;
using MiniCommerce.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Application.Features.Queries.Products.GetProductsByUserId
{
    public class GetProductsByUserQuery : IRequest<ServiceResponse<IReadOnlyList<GetProductsByUserQueryResponse>>>
    {
        public int Id { get; set; }
    }
}

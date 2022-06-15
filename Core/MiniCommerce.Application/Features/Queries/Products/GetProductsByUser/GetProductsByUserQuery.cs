using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Application.Features.Queries.Products.GetProductsByUser
{
    public class GetProductsByUserQuery : IRequest<IReadOnlyList<GetProductsByUserQueryResponse>>
    {
        public int Id { get; set; }
    }
}

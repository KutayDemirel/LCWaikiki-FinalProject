using MediatR;
using MiniCommerce.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Application.Features.Queries.Products.GetProductsByCategoryId
{
    public class GetProductsByCategoryIdQuery : IRequest<ServiceResponse<IReadOnlyList<GetProductsByCategoryIdQueryResponse>>>
	{
		public int Id { get; set; }
	}
}

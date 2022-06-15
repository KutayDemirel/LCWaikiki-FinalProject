using MediatR;
using MiniCommerce.Application.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Application.Features.Queries.Products.GetProductById
{
    public class GetProductByIdQuery : IRequest<ServiceResponse<GetProductByIdQueryResponse>>
	{
		public int Id { get; set; }
	}
}

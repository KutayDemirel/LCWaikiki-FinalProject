using AutoMapper;
using MediatR;
using MiniCommerce.Application.Models;
using MiniCommerce.Application.Services.ProductService;
using MiniCommerce.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MiniCommerce.Application.Features.Queries.Products.GetProductsByCategoryId
{
    public class GetProductsByCategoryIdQueryHandler : IRequestHandler<GetProductsByCategoryIdQuery, ServiceResponse<IReadOnlyList<GetProductsByCategoryIdQueryResponse>>>
	{
		private readonly IProductService _productService;
		private readonly IMapper _mapper;

		public GetProductsByCategoryIdQueryHandler(IProductService productService, IMapper mapper)
		{
			_productService = productService;
			_mapper = mapper;
		}

        public async Task<ServiceResponse<IReadOnlyList<GetProductsByCategoryIdQueryResponse>>> Handle(GetProductsByCategoryIdQuery request, CancellationToken cancellationToken)
        {
			var products = _productService.GetWhere(products => products.CategoryId == request.Id, false);
			var result = _mapper.Map<IReadOnlyList<GetProductsByCategoryIdQueryResponse>>(products);
			var response = new ServiceResponse<IReadOnlyList<GetProductsByCategoryIdQueryResponse>>(ResultTypeEnum.Success, "", result);
			return response;
		}
    }
}

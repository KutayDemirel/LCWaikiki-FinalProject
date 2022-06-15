using AutoMapper;
using MediatR;
using MiniCommerce.Application.Models;
using MiniCommerce.Application.Services.ProductService;
using MiniCommerce.Domain.Enum;
using System.Threading;
using System.Threading.Tasks;

namespace MiniCommerce.Application.Features.Queries.Products.GetProductById
{
	public class GetProductByIdQueryHandler : IRequestHandler<GetProductByIdQuery, ServiceResponse<GetProductByIdQueryResponse>>
	{
		private readonly IProductService _productService;
		private readonly IMapper _mapper;

		public GetProductByIdQueryHandler(IProductService productService, IMapper mapper)
		{
			_productService = productService;
			_mapper = mapper;
		}

        public async Task<ServiceResponse<GetProductByIdQueryResponse>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
			var products = await _productService.GetByIdAsync(request.Id);
			//var validator = new GetProductQueryValidator();
			//var validationResult = await validator.ValidateAsync(request);

			//if (!validationResult.IsValid)
			//{
			//var response = new ServiceResponse<GetProductByIdQueryResponse>(ResultTypeEnum.Error, "Product Eklendi", null));
			//return response;
			//}

			var result = _mapper.Map<GetProductByIdQueryResponse>(products);
			var response = new ServiceResponse<GetProductByIdQueryResponse>(ResultTypeEnum.Success, "", result);
			return response;
		}
    }
}

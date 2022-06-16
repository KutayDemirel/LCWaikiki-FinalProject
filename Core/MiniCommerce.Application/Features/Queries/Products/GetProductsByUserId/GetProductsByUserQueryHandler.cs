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

namespace MiniCommerce.Application.Features.Queries.Products.GetProductsByUserId
{
    public class GetProductsByUserQueryHandler : IRequestHandler<GetProductsByUserQuery, ServiceResponse<IReadOnlyList<GetProductsByUserQueryResponse>>>
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;


        public GetProductsByUserQueryHandler(IProductService ProductReadRepository, IMapper mapper)
        {
            _productService = ProductReadRepository;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<IReadOnlyList<GetProductsByUserQueryResponse>>> Handle(GetProductsByUserQuery request, CancellationToken cancellationToken)
        {
            var userProducts = _productService.GetWhere(x => x.UserId == request.Id, false);
            var result = _mapper.Map<IReadOnlyList<GetProductsByUserQueryResponse>>(userProducts);
            var response = new ServiceResponse<IReadOnlyList<GetProductsByUserQueryResponse>>(ResultTypeEnum.Success, "", result);
            return response;
        }
    }
}

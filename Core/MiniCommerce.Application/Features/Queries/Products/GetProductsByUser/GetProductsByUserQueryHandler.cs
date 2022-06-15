using AutoMapper;
using MediatR;
using MiniCommerce.Application.Services.ProductService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MiniCommerce.Application.Features.Queries.Products.GetProductsByUser
{
    public class GetProductsByUserQueryHandler : IRequestHandler<GetProductsByUserQuery, IReadOnlyList<GetProductsByUserQueryResponse>>
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;


        public GetProductsByUserQueryHandler(IProductService ProductReadRepository, IMapper mapper)
        {
            _productService = ProductReadRepository;
            _mapper = mapper;
        }

        public async Task<IReadOnlyList<GetProductsByUserQueryResponse>> Handle(GetProductsByUserQuery request, CancellationToken cancellationToken)
        {
            var userProducts = _productService.GetWhere(x => x.UserId == request.Id,false);
            return _mapper.Map<IReadOnlyList<GetProductsByUserQueryResponse>>(userProducts);
        }
    }
}

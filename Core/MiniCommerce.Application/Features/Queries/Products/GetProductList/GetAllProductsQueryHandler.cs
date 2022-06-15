using AutoMapper;
using MediatR;
using MiniCommerce.Application.Models;
using MiniCommerce.Application.Models.Products;
using MiniCommerce.Application.Services.ProductService;
using MiniCommerce.Domain.Entities.Common;
using MiniCommerce.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MiniCommerce.Application.Features.Queries.Products.GetProductList
{
    public class GetAllProductsQueryHandler : IRequestHandler<GetAllProductsQuery, ServiceResponse<IReadOnlyList<GetAllProductsQueryResponse>>>
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        //protected IReadOnlyList<BaseEntity> _baseEntities { get; set; }

        public GetAllProductsQueryHandler(IMapper mapper, IProductService productService) 
        {
            _productService = productService;
            _mapper = mapper;
        }

        public virtual async Task<ServiceResponse<IReadOnlyList<GetAllProductsQueryResponse>>> Handle(GetAllProductsQuery request, CancellationToken cancellationToken)
        {
            var productList = _productService.GetAll(false);

            IReadOnlyList<GetAllProductsQueryResponse> vm =  _mapper.Map<IReadOnlyList<GetAllProductsQueryResponse>>(productList);
            return new ServiceResponse<IReadOnlyList<GetAllProductsQueryResponse>> (ResultTypeEnum.Success, "Product Eklendi", vm);
            //return ResponseViewModelBase<IReadOnlyList<GetAllProductsQueryResponse>>.Success(vm,ResultTypeEnum.Success);
        }
    }
}

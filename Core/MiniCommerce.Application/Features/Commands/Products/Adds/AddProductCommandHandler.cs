using AutoMapper;
using MediatR;
using MiniCommerce.Application.Features.Commands.Products.Adds;
using MiniCommerce.Application.Models;
using MiniCommerce.Application.Services.ProductService;
using MiniCommerce.Domain.Entities;
using MiniCommerce.Domain.Enum;
using System.Threading;
using System.Threading.Tasks;

namespace MiniCommerce.Application.Features.Commands.Categories.Adds
{
    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, ServiceResponse<bool>>

    {
        private readonly IMapper _mapper;
        private readonly IProductService _productService;


        public AddProductCommandHandler(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }
        public async Task<ServiceResponse<bool>> Handle(AddProductCommand request, CancellationToken cancellationToken)
        {
            var productEntity = _mapper.Map<Product>(request);


            var newProductEntity = await _productService.AddAsync(productEntity);
            await _productService.SaveAsync();

            return new ServiceResponse<bool>(ResultTypeEnum.Success, "Product Eklendi", true);
            //return new ServiceResponse<NoContent>(ResultTypeEnum.Success, "Product Eklendi", true);
        }

    }
}

#region Without ResponseBase
//using MediatR;
//using MiniCommerce.Application.Features.Commands.Products.Adds;
//using MiniCommerce.Application.Models;
//using MiniCommerce.Application.Models.Product;
//using MiniCommerce.Application.Services.ProductService;
//using MiniCommerce.Domain.Entities;
//using MiniCommerce.Domain.Enum;
//using System.Threading;
//using System.Threading.Tasks;

//namespace MiniCommerce.Application.Features.Commands.Categories.Adds
//{
//    public class AddProductCommandHandler : IRequestHandler<AddProductCommand, ProductViewModel>/*IRequestHandler<AddProductCommand, ResponseBase> */

//    {
//        private readonly IMapper _mapper;
//        private readonly IProductService _productService;

//        public AddProductCommandHandler(IProductService productService,IMapper mapper)
//        {
//            _productService = productService;
//            _mapper = mapper;
//        }
//        public async Task<ProductViewModel> Handle(AddProductCommand request, CancellationToken cancellationToken)
//        {
//            var productEntity = _mapper.Map<Product>(request);

//            var newProductEntity = await _productService.AddAsync(productEntity);
//            await _productService.SaveAsync();

//            return new();
//        }

//    }
//}
#endregion

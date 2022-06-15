using AutoMapper;
using MediatR;
using MiniCommerce.Application.Models;
using MiniCommerce.Application.Services.ProductService;
using MiniCommerce.Domain.Entities;
using MiniCommerce.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MiniCommerce.Application.Features.Commands.Products.Updates.BuyProduct
{
    public class BuyProductCommandHandler : IRequestHandler<BuyProductCommand, ServiceResponse<bool>>
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public BuyProductCommandHandler(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }


        //public async Task<ServiceResponse<bool>> Handle(BuyProductCommand request, CancellationToken cancellationToken)
        public async Task<ServiceResponse<bool>> Handle(BuyProductCommand request, CancellationToken cancellationToken)
        {
            var productEntity = await _productService.GetByIdAsync(request.Id);

            _mapper.Map(request, productEntity, typeof(BuyProductCommand), typeof(Product));
            productEntity.IsSold = true;
            _productService.Update(productEntity);
            await _productService.SaveAsync();

            var response = new ServiceResponse<bool>(ResultTypeEnum.Success, "Product Güncellendi.", true);
            return response;
        }
    }

}

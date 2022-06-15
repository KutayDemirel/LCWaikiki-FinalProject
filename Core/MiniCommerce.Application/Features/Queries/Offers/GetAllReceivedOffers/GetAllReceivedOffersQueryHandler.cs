using AutoMapper;
using MediatR;
using MiniCommerce.Application.Models;
using MiniCommerce.Application.Services.OfferService;
using MiniCommerce.Application.Services.ProductService;
using MiniCommerce.Domain.Entities;
using MiniCommerce.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MiniCommerce.Application.Features.Queries.Offers.GetAllReceivedOffers
{
    public class GetAllReceivedOffersQueryHandler : IRequestHandler<GetAllReceivedOffersQuery, ServiceResponse<IReadOnlyList<GetAllReceivedOffersQueryResponse>>>
    {
        private readonly IOfferService _offerService;
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public GetAllReceivedOffersQueryHandler(IMapper mapper, IOfferService offerService, IProductService productService)
        {
            _offerService = offerService;
            _mapper = mapper;
            _productService = productService;
        }

        public async Task<ServiceResponse<IReadOnlyList<GetAllReceivedOffersQueryResponse>>> Handle(GetAllReceivedOffersQuery request, CancellationToken cancellationToken)
        {
            var products = _productService.GetWhere(products => products.UserId == request.UserId, false).ToList();
            //IQueryable<Offer> offerList = new IQueryable<Offer>();
            var result = new List<Offer>();
            foreach (var item in products)
            {
                result.AddRange(_offerService.GetReceivedOffers(offers => offers.ProductId == item.Id));
            }


            IReadOnlyList<GetAllReceivedOffersQueryResponse> vm = _mapper.Map<IReadOnlyList<GetAllReceivedOffersQueryResponse>>(result);
            return new ServiceResponse<IReadOnlyList<GetAllReceivedOffersQueryResponse>>(ResultTypeEnum.Success, "Offers Getirildi", vm);
        }
    }
}

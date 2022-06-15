
using AutoMapper;
using MediatR;
using MiniCommerce.Application.Models;
using MiniCommerce.Application.Services.OfferService;
using MiniCommerce.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MiniCommerce.Application.Features.Queries.Offers.GetAllSubmittedOffers
{
    public class GetAllSubmittedOffersQueryHandler : IRequestHandler<GetAllSubmittedOffersQuery, ServiceResponse<IReadOnlyList<GetAllSubmittedOffersQueryResponse>>>
    {
        private readonly IOfferService _offerService;
        private readonly IMapper _mapper;

        public GetAllSubmittedOffersQueryHandler(IMapper mapper, IOfferService offerService)
        {
            _offerService = offerService;
            _mapper = mapper;
        }

        public async Task<ServiceResponse<IReadOnlyList<GetAllSubmittedOffersQueryResponse>>> Handle(GetAllSubmittedOffersQuery request, CancellationToken cancellationToken)
        {
            var submittedOffers = _offerService.GetWhere(offers => offers.UserId == request.UserId, false);


            IReadOnlyList<GetAllSubmittedOffersQueryResponse> vm = _mapper.Map<IReadOnlyList<GetAllSubmittedOffersQueryResponse>>(submittedOffers);
            return new ServiceResponse<IReadOnlyList<GetAllSubmittedOffersQueryResponse>>(ResultTypeEnum.Success, "Offers Getirildi", vm);
        }
    }
}

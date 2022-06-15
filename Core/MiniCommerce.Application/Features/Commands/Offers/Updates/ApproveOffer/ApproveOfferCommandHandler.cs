using AutoMapper;
using MediatR;
using MiniCommerce.Application.Models;
using MiniCommerce.Application.Services.OfferService;
using MiniCommerce.Domain.Entities;
using MiniCommerce.Domain.Enum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MiniCommerce.Application.Features.Commands.Offers.Updates.ApproveOffer
{
    public class ApproveOfferCommandHandler : IRequestHandler<ApproveOfferCommand, ServiceResponse<bool>>
    {
        private readonly IOfferService _offerService;
        private readonly IMapper _mapper;

        public ApproveOfferCommandHandler(IOfferService offerService, IMapper mapper)
        {
            _offerService = offerService;
            _mapper = mapper;
        }


        public async Task<ServiceResponse<bool>> Handle(ApproveOfferCommand request, CancellationToken cancellationToken)
        {
            var offerEntity = await _offerService.GetByIdAsync(request.Id);

            _mapper.Map(request, offerEntity, typeof(ApproveOfferCommand), typeof(Offer));
            offerEntity.IsApproved = true;
            _offerService.Update(offerEntity);
            await _offerService.SaveAsync();

            var response = new ServiceResponse<bool>(ResultTypeEnum.Success, "Offer Güncellendi.", true);
            return response;
        }
    }
}

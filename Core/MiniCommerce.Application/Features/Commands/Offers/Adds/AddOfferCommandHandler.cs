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

namespace MiniCommerce.Application.Features.Commands.Offers.Adds
{
    public class AddOfferCommandHandler : IRequestHandler<AddOfferCommand, ServiceResponse<bool>>

    {
        private readonly IMapper _mapper;
        private readonly IOfferService _offerService;


        public AddOfferCommandHandler(IOfferService offerService, IMapper mapper)
        {
            _offerService = offerService;
            _mapper = mapper;
        }
        public async Task<ServiceResponse<bool>> Handle(AddOfferCommand request, CancellationToken cancellationToken)
        {
            var offer = _mapper.Map<Offer>(request);


            var newOfferEntity = await _offerService.AddAsync(offer);
            await _offerService.SaveAsync();

            return new ServiceResponse<bool>(ResultTypeEnum.Success, "Offer Eklendi", true);
        }

    }
}

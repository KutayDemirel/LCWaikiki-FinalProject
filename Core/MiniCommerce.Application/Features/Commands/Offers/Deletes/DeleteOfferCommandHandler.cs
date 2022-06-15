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

namespace MiniCommerce.Application.Features.Commands.Offers.Deletes
{
    public class DeleteOfferCommandHandler : IRequestHandler<DeleteOfferCommand, ServiceResponse<bool>>

    {
        private readonly IOfferService _offerService;


        public DeleteOfferCommandHandler(IOfferService offerService)
        {
            _offerService = offerService;
        }
        
        public async Task<ServiceResponse<bool>> Handle(DeleteOfferCommand request, CancellationToken cancellationToken)
        {
            var offer = await _offerService.GetByIdAsync(request.Id);
            //if (offer is null)
            //    return new ErrorResponse(ResultTypeEnum.Error, "Cari hesap ciro yok.");
            
            _offerService.Remove(offer);
            await _offerService.SaveAsync();
            
            var response = new ServiceResponse<bool>(ResultTypeEnum.Success, "Offer Silindi", true);
            return response;
        }
    }
}

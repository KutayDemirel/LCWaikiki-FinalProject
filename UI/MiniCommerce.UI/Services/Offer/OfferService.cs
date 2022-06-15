using Microsoft.AspNetCore.Http;
using MiniCommerce.UI.Extentions;
using MiniCommerce.UI.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace MiniCommerce.UI.Services.Offer
{
    public class OfferService : IOfferService
    {
        private readonly HttpClient _client;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public OfferService(HttpClient client, IHttpContextAccessor httpContextAccessor)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }
        public async Task<ServiceResponse<bool>> AddAsync(AddOfferModel addOfferModel)
        {
            var result = await _client.PostAsJson(_httpContextAccessor.HttpContext, $"/api/v1/Offers", addOfferModel);
            return result;
        }
         public async Task<ServiceResponse<bool>> ApproveAsync(ApproveOfferModel approveOfferModel)
        {
            var result = await _client.PutAsJson(_httpContextAccessor.HttpContext, $"/api/v1/Offers", approveOfferModel);
            return result;
        }

        public async Task<ServiceResponse<IEnumerable<GetOffersModel>>> GetReceivedOffers()
        {
            var result = await _client.ReadContentAs<ServiceResponse<IEnumerable<GetOffersModel>>>(_httpContextAccessor.HttpContext, $"/api/v1/Offers");
            return result;
        }
        public async Task<ServiceResponse<IEnumerable<GetOffersModel>>> GetSubmittedOffers()
        {
            var result = await _client.ReadContentAs<ServiceResponse<IEnumerable<GetOffersModel>>>(_httpContextAccessor.HttpContext, $"/api/v1/Offers/Submit");
            return result;
        }

        #region Delete

        public async Task<ServiceResponse<bool>> DeleteAsync(int id)
        {
            var result = await _client.DeleteAs(_httpContextAccessor.HttpContext, $"/api/v1/Offers/{id}");
            return result;
        }



        #endregion

    }
}

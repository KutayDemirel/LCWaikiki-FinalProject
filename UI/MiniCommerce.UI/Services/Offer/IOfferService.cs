using MiniCommerce.UI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiniCommerce.UI.Services.Offer
{
    public interface IOfferService
    {
        Task<ServiceResponse<IEnumerable<GetOffersModel>>> GetReceivedOffers();
        Task<ServiceResponse<IEnumerable<GetOffersModel>>> GetSubmittedOffers();
        Task<ServiceResponse<bool>> AddAsync(AddOfferModel addOfferModel);
        Task<ServiceResponse<bool>> ApproveAsync(ApproveOfferModel approveOfferModel);
        Task<ServiceResponse<bool>> DeleteAsync(int id);
    }
}

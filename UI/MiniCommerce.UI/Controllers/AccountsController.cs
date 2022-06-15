using Microsoft.AspNetCore.Mvc;
using MiniCommerce.UI.Services.Offer;
using System.Threading.Tasks;

namespace MiniCommerce.UI.Controllers
{
    public class AccountsController : Controller
    {
        private readonly IOfferService _offerService;

        public AccountsController(IOfferService offerService)
        {
            _offerService = offerService;
        }

        public IActionResult Index()
        {
            return View();
        }
        
        
        
        [HttpGet]
        public async Task<IActionResult> ReceivedOffers()
        {
            var offers = await _offerService.GetReceivedOffers();
            return View(offers.Data);
        }

        [HttpGet]
        public async Task<IActionResult> SubmittedOffers()
        {
            var offers = await _offerService.GetSubmittedOffers();
            return View(offers.Data);
        }
    }
}

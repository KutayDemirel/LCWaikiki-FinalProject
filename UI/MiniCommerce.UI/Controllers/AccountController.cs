using Microsoft.AspNetCore.Mvc;
using MiniCommerce.UI.Filter;
using MiniCommerce.UI.Services.Offer;
using MiniCommerce.UI.Services.Product;
using MiniCommerce.UI.ViewModels;
using System.Threading.Tasks;

namespace MiniCommerce.UI.Controllers
{
    public class AccountController : Controller
    {
        private readonly IOfferService _offerService;
        private readonly IProductService _productService;

        public AccountController(IOfferService offerService, IProductService productService)
        {
            _offerService = offerService;
            _productService = productService;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _productService.GetProductsByUserId();
            var productViewModel = new ProductViewModel()
            {
                Products = products.Data,
            };
            return View(productViewModel);

            //return View(products.Data);
        }
        
        [HttpGet]
        public async Task<IActionResult> ReceivedOffers()
        {
            var offers = await _offerService.GetReceivedOffers();
            var products = await _productService.GetAllProducts();
            ApproveOfferViewModel vm = new ApproveOfferViewModel()
            {
                GetOffers = offers.Data,
                Products =  products.Data,

            };
            return View(vm);
        }

        [HttpGet]
        public async Task<IActionResult> SubmittedOffers()
        {
            var offers = await _offerService.GetSubmittedOffers();
            var products = await _productService.GetAllProducts();
            ApproveOfferViewModel vm = new ApproveOfferViewModel()
            {
                GetOffers = offers.Data,
                Products = products.Data,

            };
            return View(vm);
        }
    }
}

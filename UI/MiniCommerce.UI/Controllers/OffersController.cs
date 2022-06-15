using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using MiniCommerce.UI.Enums;
using MiniCommerce.UI.Extentions;
using MiniCommerce.UI.Models;
using MiniCommerce.UI.Services.Offer;
using MiniCommerce.UI.Services.Product;
using MiniCommerce.UI.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiniCommerce.UI.Controllers
{
    public class OffersController : Controller
    {
        private readonly IOfferService _offerService;
        private readonly IProductService _productService;

        public OffersController(IOfferService offerService, IProductService productService)
        {
            _offerService = offerService;
            _productService = productService;
        }

        public IActionResult Index()
        {
            return View();
        }

        #region Make Offer

        [HttpGet]
        public async Task<IActionResult> Make(int? id)
        {

            if (id == null)
                return RedirectToAction().ShowMessage(Status.Error, "Uyarı", "Talep hatalı lütfen menüleri kullanarak yeniden deneyiniz!");

            var offer = await _productService.GetByIdAsync(id.Value);

            ProductOfferViewModel productOfferViewModel = new ProductOfferViewModel()
            {
                Product = offer.Data,
                Offer = null,
            };

            OfferList(offer.Data);
            //_mapper.Map<OfferModel>(offer.Data))
            return View(productOfferViewModel);

        }

        [HttpPost]

        public async Task<IActionResult> Make(ProductOfferViewModel addOfferModel)
        {
            if (addOfferModel == null)
                return RedirectToAction("Index").ShowMessage(Status.Error, "Uyarı", "Güncellenmek istenen blok bulunamadı!");

            if (!ModelState.IsValid)
            {
                var product = await _productService.GetByIdAsync(addOfferModel.Offer.ProductId);
                addOfferModel.Product = product.Data;
                OfferList(product.Data);
                return View(addOfferModel).ShowMessage(Status.Error, "Error", "Eksik veya hatalı bilgiler mevcut!");
            }

            var result = await _offerService.AddAsync(addOfferModel.Offer);

            if (result.ResultType == ResultTypeEnum.Success)
            {
                return RedirectToAction("Index","Product").ShowMessage(Status.Ok, "Başarılı", result.Message);
            }
            else
            {
                return RedirectToAction("Index", "Product").ShowMessage(Status.Error, "Hata", "Beklenmedik bir hata oluştu!");
            }

        }

        #endregion


        #region OfferApprove


        [HttpPost]

        public async Task<IActionResult> Approve(ApproveOfferModel approveOfferModel)
        {
            if (approveOfferModel == null)
                return RedirectToAction("Index").ShowMessage(Status.Error, "Uyarı", "Güncellenmek istenen blok bulunamadı!");

            if (!ModelState.IsValid)
            {
                //var product = await _productService.GetByIdAsync(approveOfferModel.Id);
                //approveOfferModel.Product = product.Data;
                //OfferList(product.Data);
                return View(approveOfferModel).ShowMessage(Status.Error, "Error", "Eksik veya hatalı bilgiler mevcut!");
            }

            var result = await _offerService.ApproveAsync(approveOfferModel);

            if (result.ResultType == ResultTypeEnum.Success)
            {
                return RedirectToAction("Index", "Product").ShowMessage(Status.Ok, "Başarılı", result.Message);
            }
            else
            {
                return RedirectToAction("Index", "Product").ShowMessage(Status.Error, "Hata", "Beklenmedik bir hata oluştu!");
            }

        }


        #endregion





        #region Delete Offer

        [HttpPost]
        public async Task<IActionResult> Delete(int id)
        {

            //if (deleteOfferModel == null)
            //{
            //    return Json(new JResult
            //    {
            //        Status = Status.BadRequest,
            //        Message = "Hatalı istekte bulundunuz! Lütfen yeniden deneyiniz."
            //    });
            //}

            var result = await _offerService.DeleteAsync(id);

            switch (result.ResultType)
            {
                case ResultTypeEnum.Success:
                    return RedirectToAction("ReceivedOffers","Accounts");
                    
                case ResultTypeEnum.Error:
                    return Json(new JResult
                    {
                        Status = Status.BadRequest,
                        Message = result.Message
                    });
                default:
                    return Json(new JResult
                    {
                        Status = Status.BadRequest,
                        Message = "Beklenmedik hata oluştu!"
                    });


            }

        }


        #endregion

        private bool OfferList(ProductModel offer)
        {
            List<SelectListItem> percentages = new List<SelectListItem>();
            for (int i = 10; i < 100; i += 10)
            {
                decimal priceCheck = (decimal)(offer.Price * i / 100);
                //string percentagePrice = String.Format("{0:0.00}", priceCheck);
                percentages.Add(new SelectListItem() { Text = string.Concat("%",i.ToString()," = ", priceCheck.ToString("c")), Value = priceCheck.ToString() });
            }
            ViewBag.Percentages = percentages;

            return true;
        }




    }
}

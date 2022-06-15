using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Hosting;
using MiniCommerce.UI.Enums;
using MiniCommerce.UI.Extentions;
using MiniCommerce.UI.Models;
using MiniCommerce.UI.Services.Category;
using MiniCommerce.UI.Services.Product;
using MiniCommerce.UI.ViewModels;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.IO;
using System;
using MiniCommerce.UI.Services.Color;
using MiniCommerce.UI.Services.Usage;
using MiniCommerce.UI.Services.Brand;
using System.Collections.Generic;

namespace MiniCommerce.UI.Controllers
{
    public class ProductController : Controller
    {

        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IColorService _colorService;
        private readonly IUsageService _usageService;
        private readonly IBrandService _brandService;
        private readonly IMapper _mapper;

        public ProductController(IMapper mapper, IProductService productService, ICategoryService categoryService, IHttpContextAccessor httpContextAccessor, IWebHostEnvironment webHostEnvironment, IColorService colorService, IUsageService usageService, IBrandService brandService)
        {
            _mapper = mapper;
            _productService = productService;
            _categoryService = categoryService;
            _httpContextAccessor = httpContextAccessor;
            _webHostEnvironment = webHostEnvironment;
            _colorService = colorService;
            _usageService = usageService;
            _brandService = brandService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> List()
        {
            var products = await _productService.GetAllProducts();


            var productViewModel = new ProductViewModel()
            {
                Products = products.Data,
            };
            return View(productViewModel);
        }
        public async Task<IActionResult> Details(int id)
        {

            var detail = await _productService.GetProductDetails(id);
            return View(detail.Data);

        }

        public async Task<IActionResult> Category(int? id)
        {

            var categories = await _categoryService.GetAllCategories();

            if (id is not null)
            {
                var categoryProducts = await _productService.GetProductsByCategory(id.Value);
                var productViewModel = new ProductViewModel()
                {
                    Products = categoryProducts.Data,
                    Categories = categories.Data,
                };
                return View(productViewModel);
            }
            else
            {
                var products = await _productService.GetAllProducts();
                var productViewModel = new ProductViewModel()
                {
                    Products = products.Data,
                    Categories = categories.Data,
                };
                return View(productViewModel);
            }
        }


        [HttpGet]
        public async Task<IActionResult> BuyProduct(int? id)
        {

            if (id == null)
                return RedirectToAction().ShowMessage(Status.Error, "Uyarı", "Talep hatalı lütfen menüleri kullanarak yeniden deneyiniz!");
            
            var product = await _productService.GetByIdAsync(id.Value);
            //_mapper.Map<ProductModel>(product.Data))
            return View(product.Data);

        }

        [HttpPost]
        public async Task<IActionResult> BuyProduct(ProductModel buyProductModel)
        {
            if (buyProductModel == null)
                return RedirectToAction("Index").ShowMessage(Status.Error, "Uyarı", "Güncellenmek istenen blok bulunamadı!");

            if (!ModelState.IsValid)
            {
                return View(buyProductModel).ShowMessage(Status.Error, "Error", "Eksik veya hatalı bilgiler mevcut!");
            }

            var result = await _productService.BuyAsync(buyProductModel);

            if (result.ResultType == ResultTypeEnum.Success)
            {
                return RedirectToAction("Index").ShowMessage(Status.Ok, "Başarılı", result.Message);
            }
            else
            {
                return RedirectToAction("Index").ShowMessage(Status.Error, "Hata", "Beklenmedik bir hata oluştu!");
            }
        }



        #region offerbuy



        [HttpGet]
        public async Task<IActionResult> OfferBuyProduct(int? id,string price)
        {

            if (id == null)
                return RedirectToAction().ShowMessage(Status.Error, "Uyarı", "Talep hatalı lütfen menüleri kullanarak yeniden deneyiniz!");

            var product = await _productService.GetByIdAsync(id.Value);
            product.Data.Price =Convert.ToDecimal(price);
            var set = await _productService.SetPriceAsync(product.Data);
            //_mapper.Map<ProductModel>(product.Data))
            return View(product.Data);

        }

        [HttpPost]
        public async Task<IActionResult> OfferBuyProduct(ProductModel offerBuyProductModel)
        {
            if (offerBuyProductModel == null)
                return RedirectToAction("Index").ShowMessage(Status.Error, "Uyarı", "Güncellenmek istenen blok bulunamadı!");

            if (!ModelState.IsValid)
            {
                return View(offerBuyProductModel).ShowMessage(Status.Error, "Error", "Eksik veya hatalı bilgiler mevcut!");
            }

            var result = await _productService.BuyAsync(offerBuyProductModel);

            if (result.ResultType == ResultTypeEnum.Success)
            {
                return RedirectToAction("Index").ShowMessage(Status.Ok, "Başarılı", result.Message);
            }
            else
            {
                return RedirectToAction("Index").ShowMessage(Status.Error, "Hata", "Beklenmedik bir hata oluştu!");
            }
        }


        #endregion

        #region ADD

        [HttpGet]
        public async Task<IActionResult> AddProduct()
        {
            await DropDownAddProduct();
            //FileUploadModel ic = new FileUploadModel();

            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(AddProductModel addProductModel)
        {

            if (!ModelState.IsValid)
            {
                await DropDownAddProduct();
                //string uniqueName = UploadedFile(addProductModel);
                //addProductModel.ImageUrl = uniqueName;
                return View(addProductModel).ShowMessage(Status.BadRequest, "Uyarı", "Eksik veya hatalı bilgiler mevcut!"); ;
            }

            string uniqueFileName = UploadedFile(addProductModel);
            addProductModel.ImageUrl = uniqueFileName;


            var result = await _productService.AddAsync(addProductModel);
            if (result.ResultType == ResultTypeEnum.Success)
            {
                return RedirectToAction("Index").ShowMessage(Status.Ok, "Başarılı", result.Message);
            }
            else
            {

                return RedirectToAction("Index").ShowMessage(Status.Error, "Hata", "Beklenmedik bir hata oluştu!");

            }
        }
        #endregion

        #region ImageUpload
        [HttpGet]
        public ActionResult UploadImages()
        {
            return View();
        }

        [HttpPost]
        public ActionResult UploadImages(AddProductModel addProductImage)
        {
            if (!ModelState.IsValid)
            {
                return View(addProductImage);
            }

            return View("Index");
        }

        private string UploadedFile(AddProductModel addProductModel)
        {
            string uniqueFileName = null;

            if (addProductModel.Image != null)
            {
                string uploadsFolder = Path.Combine(_webHostEnvironment.WebRootPath, "images");
                uniqueFileName = Guid.NewGuid().ToString() + "_" + addProductModel.Image.FileName;
                string filePath = Path.Combine(uploadsFolder, uniqueFileName);
                //STREAM CLOSE
                using (var fileStream = new FileStream(filePath, FileMode.Create))
                {
                    addProductModel.Image.CopyTo(fileStream);
                }
            }
            return uniqueFileName;
        }

        #endregion

        #region DropDown

        private async Task<bool> DropDownAddProduct()
        {
            var categories = await _categoryService.GetAllCategories();
            var colors = await _colorService.GetAllColors();
            var brands = await _brandService.GetAllBrands();
            var usages = await _usageService.GetAllUsages();

            ViewBag.Categories = new SelectList(categories.Data, "Id", "Name");
            ViewBag.Brands = new SelectList(brands.Data, "Id", "Name");
            ViewBag.Colors = new SelectList(colors.Data, "Id", "Name");
            ViewBag.Usages = new SelectList(usages.Data, "Id", "Name");
            ViewBag.IsOfferable = new List<SelectListItem>()
                {
                new SelectListItem() { Text = "Yes", Value = "True" },
                new SelectListItem() { Text = "No", Value = "False"}
                };

            #region dictionary BackUp

            //Dictionary kullanırsak conflictten kaçınılır
            // Dictionary<int,string> category = new();
            //// category.Add(0, "Hiçbiri");
            // foreach (var item in categories.Data)
            // {   //Text = Görünen kısımdır. Kategori ismini yazdıyoruz
            //     //Value = Değer kısmıdır.ID değerini atıyoruz
            //     category.Add(item.Id, item.Name);
            // }
            // Dictionary<int,string> brand = new();
            // //brand.Add(0, "Hiçbiri");
            // foreach (var item in brands.Data)
            // {   //Text = Görünen kısımdır. Kategori ismini yazdıyoruz
            //     //Value = Değer kısmıdır.ID değerini atıyoruz
            //     brand.Add(item.Id, item.Name);
            // }
            // Dictionary<int,string> color = new();
            // //color.Add(0, "Hiçbiri");
            // foreach (var item in colors.Data)
            // {   
            //     color.Add(item.Id, item.Name);
            // }
            // Dictionary<int,string> usage = new();
            // //usage.Add(0, "Hiçbiri");
            // foreach (var item in usages.Data)
            // {   
            //     usage.Add(item.Id, item.Name);
            // }
            //ViewBag.Categories = category; //(IEnumerable<SelectListItem>)
            //ViewBag.Brands = brand;
            //ViewBag.Colors = color;
            //ViewBag.Usages = usage;
            #endregion

            return false;

        }

        #endregion

    }
}

using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MiniCommerce.UI.Extentions;
using MiniCommerce.UI.Models;
using MiniCommerce.UI.Services;
using MiniCommerce.UI.Services.Category;
using MiniCommerce.UI.Services.Product;
using MiniCommerce.UI.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace MiniCommerce.UI.Controllers
{
    public class HomeController : Controller
    {

        private readonly IAuthService _authService;
        private readonly IProductService _productService;
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public HomeController(IMapper mapper, IProductService productService, IAuthService authService, ICategoryService categoryService)
        {
            _mapper = mapper;
            _productService = productService;
            _authService = authService;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> Index()
        {
            var products = await _productService.GetAllProducts();
            var categories = await _categoryService.GetAllCategories();


            var productViewModel = new ProductViewModel()
            {
                Products = products.Data,
                Categories = categories.Data,
            };
            return View(productViewModel);
        }
    
        public IActionResult About()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }

}


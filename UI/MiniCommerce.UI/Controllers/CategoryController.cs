using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MiniCommerce.UI.Enums;
using MiniCommerce.UI.Models;
using MiniCommerce.UI.Services.Category;
using MiniCommerce.UI.ViewModels;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiniCommerce.UI.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryService;
        private readonly IMapper _mapper;

        public CategoryController(IMapper mapper, ICategoryService categoryService)
        {
            _mapper = mapper;
            _categoryService = categoryService;
        }

        public async Task<IActionResult> List()
        {
            var categories = await _categoryService.GetAllCategories();

            var productViewModel = new ProductViewModel()
            {
                Categories = categories.Data,
            };

            return Ok(productViewModel);
        }
    }
}

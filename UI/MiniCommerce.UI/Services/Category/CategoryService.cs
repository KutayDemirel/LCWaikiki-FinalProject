using Microsoft.AspNetCore.Http;
using MiniCommerce.UI.Extentions;
using MiniCommerce.UI.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace MiniCommerce.UI.Services.Category
{
    public class CategoryService : ICategoryService
    {
        private readonly HttpClient _client;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public CategoryService(HttpClient client, IHttpContextAccessor httpContextAccessor)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }

     
        public async Task<ServiceResponse<List<CategoryModel>>> GetAllCategories()
        {
            var result = await _client.ReadContentAs<ServiceResponse<List<CategoryModel>>>(_httpContextAccessor.HttpContext, $"/api/v1/Categories");
            return result;
        }
    }
}

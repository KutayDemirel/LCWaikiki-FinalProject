using Microsoft.AspNetCore.Http;
using MiniCommerce.UI.Extentions;
using MiniCommerce.UI.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace MiniCommerce.UI.Services.Brand
{
    public class BrandService : IBrandService
    {
        private readonly HttpClient _client;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public BrandService(HttpClient client, IHttpContextAccessor httpContextAccessor)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }


        public async Task<ServiceResponse<IReadOnlyList<BrandModel>>> GetAllBrands()
        {
            var result = await _client.ReadContentAs<ServiceResponse<IReadOnlyList<BrandModel>>>(_httpContextAccessor.HttpContext, $"/api/v1/Brands");
            return result;
        }
    }
}

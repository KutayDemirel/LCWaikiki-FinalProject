using Microsoft.AspNetCore.Http;
using MiniCommerce.UI.Extentions;
using MiniCommerce.UI.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace MiniCommerce.UI.Services.Color
{
    public class ColorService : IColorService
    {
        private readonly HttpClient _client;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ColorService(HttpClient client, IHttpContextAccessor httpContextAccessor)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }


        public async Task<ServiceResponse<IReadOnlyList<ColorModel>>> GetAllColors()
        {
            var result = await _client.ReadContentAs<ServiceResponse<IReadOnlyList<ColorModel>>>(_httpContextAccessor.HttpContext, $"/api/v1/Colors");
            return result;
        }
    }
}

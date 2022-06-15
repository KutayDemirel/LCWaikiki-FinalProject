using Microsoft.AspNetCore.Http;
using MiniCommerce.UI.Extentions;
using MiniCommerce.UI.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace MiniCommerce.UI.Services.Product
{
    public class ProductService : IProductService
    {
        private readonly HttpClient _client;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public ProductService(HttpClient client, IHttpContextAccessor httpContextAccessor)
        {
            _client = client ?? throw new ArgumentNullException(nameof(client));
            _httpContextAccessor = httpContextAccessor ?? throw new ArgumentNullException(nameof(httpContextAccessor));
        }

        public async Task<ServiceResponse<IReadOnlyList<ProductModel>>> GetAllProducts()
        {
            var result = await _client.ReadContentAs<ServiceResponse<IReadOnlyList<ProductModel>>>(_httpContextAccessor.HttpContext, $"/api/v1/Product");
            return result;
        }

        public async Task<ServiceResponse<ProductModel>> GetByIdAsync(int id)
        {
            var result = await _client.ReadContentAs<ServiceResponse<ProductModel>>(_httpContextAccessor.HttpContext, $"/api/v1/Product/{id}");
            return result;
        }


        public async Task<ServiceResponse<IReadOnlyList<ProductModel>>> GetProductsByCategory(int id)
        {
            var result = await _client.ReadContentAs<ServiceResponse<IReadOnlyList<ProductModel>>>(_httpContextAccessor.HttpContext, $"/api/v1/Product/Search?categoryId={id}");
            return result;
        }

        public async Task<ServiceResponse<ProductModel>> GetProductDetails(int id)
        {
            var result = await _client.ReadContentAs<ServiceResponse<ProductModel>>(_httpContextAccessor.HttpContext, $"/api/v1/Product/{id}");
            return result;
        }

        public async Task<ServiceResponse<bool>> AddAsync(AddProductModel addProductModel)
        {
            var result = await _client.PostAsJson(_httpContextAccessor.HttpContext, $"/api/v1/Product", addProductModel);
            return result;
        }
        public async Task<ServiceResponse<bool>> BuyAsync(ProductModel buyProductModel)
        {
            var result = await _client.PutAsJson(_httpContextAccessor.HttpContext, $"/api/v1/Product", buyProductModel);
            return result;
        }

        //public async Task<ServiceResponse<bool>> UpdateAsync(UpdateOrganizasyonModel updateOrganizasyonAylikHesapModel)
        //{
        //    var result = await _client.PutAsJson(_httpContextAccessor.HttpContext, $"/api/Organizasyon", updateOrganizasyonAylikHesapModel);

        //    return result;
        //}


    }
}

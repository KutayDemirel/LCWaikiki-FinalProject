using MiniCommerce.UI.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiniCommerce.UI.Services.Product
{
    public interface IProductService
    {
        Task<ServiceResponse<ProductModel>> GetProductDetails(int id);
        Task<ServiceResponse<IReadOnlyList<ProductModel>>> GetAllProducts();
        Task<ServiceResponse<IReadOnlyList<ProductModel>>> GetProductsByUserId();
        Task<ServiceResponse<ProductModel>> GetByIdAsync(int id);
        Task<ServiceResponse<IReadOnlyList<ProductModel>>> GetProductsByCategory(int id);
        Task<ServiceResponse<bool>> AddAsync(AddProductModel addProductModel);
        Task<ServiceResponse<bool>> BuyAsync(ProductModel buyProductModel);
        Task<ServiceResponse<bool>> SetPriceAsync(ProductModel setProductModel);


    }
}

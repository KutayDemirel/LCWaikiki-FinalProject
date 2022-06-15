using MiniCommerce.Application.Repositories;
using MiniCommerce.Application.Repositories.ProductRepo;
using MiniCommerce.Application.Services.ProductService;
using MiniCommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Persistence.Services.ProductServ
{
    public class ProductService : ServiceBase<Product>, IProductService
    {
        private readonly IProductReadRepository _entityReadRepository;
        private readonly IProductWriteRepository _entityWriteRepository;

        public ProductService(IProductReadRepository entityReadRepository, IProductWriteRepository entityWriteRepository) : base(entityReadRepository, entityWriteRepository)
        {
            _entityReadRepository = entityReadRepository ?? throw new ArgumentNullException(nameof(entityReadRepository));
            _entityWriteRepository = entityWriteRepository ?? throw new ArgumentNullException(nameof(entityWriteRepository));

        }

    }
}

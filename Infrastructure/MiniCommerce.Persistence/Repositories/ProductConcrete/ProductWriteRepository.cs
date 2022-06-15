using MiniCommerce.Application.Repositories.ProductRepo;
using MiniCommerce.Domain.Entities;
using MiniCommerce.Persistence.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Persistence.Repositories.ProductConcrete
{
    public class ProductWriteRepository : WriteRepository<Product>, IProductWriteRepository
    {
        public ProductWriteRepository(MiniCommerceDbContext context) : base(context)
        {
        }
    }
}

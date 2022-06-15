using MiniCommerce.Application.Repositories.BrandRepo;
using MiniCommerce.Domain.Entities;
using MiniCommerce.Persistence.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Persistence.Repositories.BrandConcrete
{
    public class BrandReadRepository : ReadRepository<Brand>, IBrandReadRepository
    {
        public BrandReadRepository(MiniCommerceDbContext context) : base(context)
        {
        }
    }
}

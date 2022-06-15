using MiniCommerce.Application.Repositories.BrandRepo;
using MiniCommerce.Domain.Entities;
using MiniCommerce.Persistence.DbContexts;

namespace MiniCommerce.Persistence.Repositories.BrandConcrete
{
    public class BrandWriteRepository : WriteRepository<Brand>, IBrandWriteRepository
    {
        public BrandWriteRepository(MiniCommerceDbContext context) : base(context)
        {
        }
    }
}

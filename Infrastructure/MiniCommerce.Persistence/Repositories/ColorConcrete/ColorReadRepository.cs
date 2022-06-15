using MiniCommerce.Application.Repositories.ColorRepo;
using MiniCommerce.Domain.Entities;
using MiniCommerce.Persistence.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Persistence.Repositories.ColorConcrete
{
    public class ColorReadRepository : ReadRepository<Color>, IColorReadRepository
    {
        public ColorReadRepository(MiniCommerceDbContext context) : base(context)
        {
        }
    }
}

using Microsoft.EntityFrameworkCore;
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
    public class ProductReadRepository : ReadRepository<Product>, IProductReadRepository
    {
        private readonly MiniCommerceDbContext _context;
        public DbSet<Product> Table => _context.Set<Product>();
        public ProductReadRepository(MiniCommerceDbContext context) : base(context)
        {
            _context = context;
        }

        public override async Task<Product> GetByIdAsync(int id, bool tracking = true)
        //=> await Table.FindAsync(Guid.Parse(id));
        //=> await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return await query.Include(x=> x.Category)
                .Include(x=> x.Color)
                .Include(x=> x.Brand)
                .Include(x=> x.Usage)
                .FirstOrDefaultAsync(data => data.Id == id);
        }


    }
}

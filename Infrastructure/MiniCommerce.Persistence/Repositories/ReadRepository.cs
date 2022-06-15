using Microsoft.EntityFrameworkCore;
using MiniCommerce.Application.Repositories;
using MiniCommerce.Domain.Entities.Common;
using MiniCommerce.Persistence.DbContexts;
using System;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MiniCommerce.Persistence.Repositories
{
    public class ReadRepository<T> : IReadRepository<T> where T : BaseEntity
    {
        private readonly MiniCommerceDbContext _context;

        public ReadRepository(MiniCommerceDbContext context)
        {
            _context = context ?? throw new ArgumentNullException(nameof(context));
        }

        public DbSet<T> Table => _context.Set<T>();

        public IQueryable<T> GetAll(bool tracking = true)
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return query;
        }
   

        public async Task<T> GetSingleAsync(Expression<Func<T, bool>> method, bool tracking = true)
        //=> await Table.FirstOrDefaultAsync(method);
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return await query.FirstOrDefaultAsync(method);
        }

        public IQueryable<T> GetWhere(Expression<Func<T, bool>> method, bool tracking = true)
        {
            var query = Table.Where(method);
            if (!tracking)
                query = query.AsNoTracking();
            return query;
        }
        public virtual async Task<T> GetByIdAsync(int id, bool tracking = true)
        //=> await Table.FindAsync(Guid.Parse(id));
        //=> await Table.FirstOrDefaultAsync(data => data.Id == Guid.Parse(id));
        {
            var query = Table.AsQueryable();
            if (!tracking)
                query = query.AsNoTracking();
            return await query.FirstOrDefaultAsync(data => data.Id == id);
        }


        //public IQueryable<T> GetAll(bool tracking = true)
        //{
        //    var query = Table.Where(x => x.Id ==5).AsQueryable();
        //    if (!tracking)
        //        query = query.AsNoTracking();
        //    return query;
        //}

    }
}

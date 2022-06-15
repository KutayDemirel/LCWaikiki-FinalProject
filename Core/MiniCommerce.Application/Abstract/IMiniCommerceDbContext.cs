using Microsoft.EntityFrameworkCore;
using MiniCommerce.Domain.Entities;
using MiniCommerce.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MiniCommerce.Application.Abstract
{
    public interface IMiniCommerceDbContext
    {
        DbSet<Product> Products { get; set; }
        DbSet<Offer> Offers { get; set; }
        //DbSet<User> Users { get; set; }
        DbSet<Category> Categories { get; set; }

        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
        //DbSet<T> Set<T>() where T : BaseEntity;
    }
}

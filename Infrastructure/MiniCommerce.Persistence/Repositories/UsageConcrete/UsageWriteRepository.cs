using MiniCommerce.Application.Repositories.UsageRepo;
using MiniCommerce.Domain.Entities;
using MiniCommerce.Persistence.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Persistence.Repositories.UsageConcrete
{
    public class UsageWriteRepository : WriteRepository<Usage>, IUsageWriteRepository
    {
        public UsageWriteRepository(MiniCommerceDbContext context) : base(context)
        {
        }
    }
}

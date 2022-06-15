using MiniCommerce.Application.Repositories.OfferRepo;
using MiniCommerce.Domain.Entities;
using MiniCommerce.Persistence.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Persistence.Repositories.OfferConcrete
{
    public class OfferReadRepository : ReadRepository<Offer>, IOfferReadRepository
    {
        public OfferReadRepository(MiniCommerceDbContext context) : base(context)
        {
        }
    }
}

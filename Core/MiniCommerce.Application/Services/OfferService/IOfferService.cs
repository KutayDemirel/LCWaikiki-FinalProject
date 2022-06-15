using MiniCommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Application.Services.OfferService
{
    public interface IOfferService : IServiceBase<Offer>
    {
        IQueryable<Offer> GetReceivedOffers(Expression<Func<Offer, bool>> method, bool tracking = true);
    }
}

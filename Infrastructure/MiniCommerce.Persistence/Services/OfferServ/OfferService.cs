using MiniCommerce.Application.Repositories;
using MiniCommerce.Application.Services.OfferService;
using MiniCommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Persistence.Services.OfferServ
{
    public class OfferService : ServiceBase<Offer>, IOfferService
    {

        private readonly IReadRepository<Offer> _entityReadRepository;
        private readonly IWriteRepository<Offer> _entityWriteRepository;

        public OfferService(IReadRepository<Offer> entityReadRepository, IWriteRepository<Offer> entityWriteRepository) : base(entityReadRepository, entityWriteRepository)
        {
            _entityReadRepository = entityReadRepository ?? throw new ArgumentNullException(nameof(entityReadRepository));
            _entityWriteRepository = entityWriteRepository ?? throw new ArgumentNullException(nameof(entityWriteRepository));

        }

        public IQueryable<Offer> GetReceivedOffers(Expression<Func<Offer, bool>> method, bool tracking = true)
        {
            return _entityReadRepository.GetWhere(method, tracking);
        }
    }
}

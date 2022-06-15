using MiniCommerce.Application.Repositories;
using MiniCommerce.Application.Services.UsageService;
using MiniCommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Persistence.Services.UsageServ
{
    public class UsageService : ServiceBase<Usage>, IUsageService
    {
        private readonly IReadRepository<Usage> _entityReadRepository;
        private readonly IWriteRepository<Usage> _entityWriteRepository;

        public UsageService(IReadRepository<Usage> entityReadRepository, IWriteRepository<Usage> entityWriteRepository) : base(entityReadRepository, entityWriteRepository)
        {
            _entityReadRepository = entityReadRepository ?? throw new ArgumentNullException(nameof(entityReadRepository));
            _entityWriteRepository = entityWriteRepository ?? throw new ArgumentNullException(nameof(entityWriteRepository));

        }
    }
}

using MiniCommerce.Application.Repositories;
using MiniCommerce.Application.Services.BrandService;
using MiniCommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Persistence.Services.BrandServ
{
    public class BrandService : ServiceBase<Brand>, IBrandService
    {
        private readonly IReadRepository<Brand> _entityReadRepository;
        private readonly IWriteRepository<Brand> _entityWriteRepository;

        public BrandService(IReadRepository<Brand> entityReadRepository, IWriteRepository<Brand> entityWriteRepository) : base(entityReadRepository, entityWriteRepository)
        {
            _entityReadRepository = entityReadRepository ?? throw new ArgumentNullException(nameof(entityReadRepository));
            _entityWriteRepository = entityWriteRepository ?? throw new ArgumentNullException(nameof(entityWriteRepository));

        }
    }
}

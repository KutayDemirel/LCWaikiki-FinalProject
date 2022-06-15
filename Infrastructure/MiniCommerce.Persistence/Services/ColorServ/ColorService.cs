using MiniCommerce.Application.Repositories;
using MiniCommerce.Application.Services.ColorService;
using MiniCommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Persistence.Services.ColorServ
{
    public class ColorService : ServiceBase<Color>, IColorService
    {
        private readonly IReadRepository<Color> _entityReadRepository;
        private readonly IWriteRepository<Color> _entityWriteRepository;

        public ColorService(IReadRepository<Color> entityReadRepository, IWriteRepository<Color> entityWriteRepository) : base(entityReadRepository, entityWriteRepository)
        {
            _entityReadRepository = entityReadRepository ?? throw new ArgumentNullException(nameof(entityReadRepository));
            _entityWriteRepository = entityWriteRepository ?? throw new ArgumentNullException(nameof(entityWriteRepository));

        }
    }
}

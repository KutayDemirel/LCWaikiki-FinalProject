using MiniCommerce.Application.Repositories;
using MiniCommerce.Application.Services.CategoryService;
using MiniCommerce.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Persistence.Services.CategoryServ
{
    public class CategoryService : ServiceBase<Category>, ICategoryService
    {
        private readonly IReadRepository<Category> _entityReadRepository;
        private readonly IWriteRepository<Category> _entityWriteRepository;

        public CategoryService(IReadRepository<Category> entityReadRepository, IWriteRepository<Category> entityWriteRepository) : base(entityReadRepository, entityWriteRepository)
        {
            _entityReadRepository = entityReadRepository ?? throw new ArgumentNullException(nameof(entityReadRepository));
            _entityWriteRepository = entityWriteRepository ?? throw new ArgumentNullException(nameof(entityWriteRepository));

        }
    }
}

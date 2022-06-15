﻿using MiniCommerce.Application.Repositories.CategoryRepo;
using MiniCommerce.Domain.Entities;
using MiniCommerce.Persistence.DbContexts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Persistence.Repositories.CategoryConcrete
{
    public class CategoryReadRepository : ReadRepository<Category>, ICategoryReadRepository
    {
        public CategoryReadRepository(MiniCommerceDbContext context) : base(context)
        {
        }
    }
}

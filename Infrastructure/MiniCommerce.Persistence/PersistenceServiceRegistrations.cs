using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MiniCommerce.Application.Repositories;
using MiniCommerce.Application.Repositories.BrandRepo;
using MiniCommerce.Application.Repositories.CategoryRepo;
using MiniCommerce.Application.Repositories.ColorRepo;
using MiniCommerce.Application.Repositories.OfferRepo;
using MiniCommerce.Application.Repositories.ProductRepo;
using MiniCommerce.Application.Repositories.UsageRepo;
using MiniCommerce.Application.Services;
using MiniCommerce.Application.Services.BrandService;
using MiniCommerce.Application.Services.CategoryService;
using MiniCommerce.Application.Services.ColorService;
using MiniCommerce.Application.Services.OfferService;
using MiniCommerce.Application.Services.ProductService;
using MiniCommerce.Application.Services.UsageService;
using MiniCommerce.Persistence.Configurations;
using MiniCommerce.Persistence.DbContexts;
using MiniCommerce.Persistence.Repositories;
using MiniCommerce.Persistence.Repositories.BrandConcrete;
using MiniCommerce.Persistence.Repositories.CategoryConcrete;
using MiniCommerce.Persistence.Repositories.ColorConcrete;
using MiniCommerce.Persistence.Repositories.OfferConcrete;
using MiniCommerce.Persistence.Repositories.ProductConcrete;
using MiniCommerce.Persistence.Repositories.UsageConcrete;
using MiniCommerce.Persistence.Services;
using MiniCommerce.Persistence.Services.BrandServ;
using MiniCommerce.Persistence.Services.CategoryServ;
using MiniCommerce.Persistence.Services.ColorServ;
using MiniCommerce.Persistence.Services.OfferServ;
using MiniCommerce.Persistence.Services.ProductServ;
using MiniCommerce.Persistence.Services.UsageServ;

namespace MiniCommerce.Persistence
{
    public static class PersistenceServiceRegistrations
    {
        public static IServiceCollection AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<MiniCommerceDbContext>(options => options.UseNpgsql
                (Configurate.ConnectionString));

            //services.AddScoped<IMiniCommerceDbContext>(provider => provider.GetService<MiniCommerceDbContext>());

            #region Commons

            services.AddScoped(typeof(IReadRepository<>), typeof(ReadRepository<>));
            services.AddScoped(typeof(IWriteRepository<>), typeof(WriteRepository<>));
            services.AddScoped(typeof(IServiceBase<>), typeof(ServiceBase<>));

            #endregion

            services.AddScoped<ICategoryWriteRepository, CategoryWriteRepository>();
            services.AddScoped<ICategoryReadRepository, CategoryReadRepository>();
            services.AddScoped<ICategoryService, CategoryService>();

            services.AddScoped<IOfferReadRepository, OfferReadRepository>();
            services.AddScoped<IOfferWriteRepository, OfferWriteRepository>();
            services.AddScoped<IOfferService, OfferService>();

            services.AddScoped<IProductReadRepository, ProductReadRepository>();
            services.AddScoped<IProductWriteRepository, ProductWriteRepository>();
            services.AddScoped<IProductService, ProductService>();

            services.AddScoped<IBrandReadRepository, BrandReadRepository>();
            services.AddScoped<IBrandWriteRepository, BrandWriteRepository>();
            services.AddScoped<IBrandService, BrandService>();

            services.AddScoped<IColorReadRepository, ColorReadRepository>();
            services.AddScoped<IColorWriteRepository, ColorWriteRepository>();
            services.AddScoped<IColorService, ColorService>();

            services.AddScoped<IUsageReadRepository, UsageReadRepository>();
            services.AddScoped<IUsageWriteRepository, UsageWriteRepository>();
            services.AddScoped<IUsageService, UsageService>();



            return services;
        }
    }
}

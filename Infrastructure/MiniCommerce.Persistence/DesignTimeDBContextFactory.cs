using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using MiniCommerce.Persistence.DbContexts;
using MiniCommerce.Persistence.Configurations;


namespace MiniCommerce.Persistence
{
    internal class DesignTimeDBContextFactory : IDesignTimeDbContextFactory<MiniCommerceDbContext>
    {
        public MiniCommerceDbContext CreateDbContext(string[] args)
        {
            DbContextOptionsBuilder<MiniCommerceDbContext> dbContextOptionsBuilder = new();
            dbContextOptionsBuilder.UseNpgsql(Configurate.ConnectionString);
            return new MiniCommerceDbContext(dbContextOptionsBuilder.Options);
            
        }
    }
}

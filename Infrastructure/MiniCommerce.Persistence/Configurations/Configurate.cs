using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiniCommerce.Persistence.Configurations
{
    public static class Configurate
    {
        public static string ConnectionString
        {
            get
            {
               IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Path.Combine(Directory.GetCurrentDirectory(),"../../Presentation/MiniCommerce.API"))
                .AddJsonFile("appsettings.json")
                .Build();

                var connectionString = configuration.GetConnectionString("PostgreSQL");

                return connectionString;
            }
        }
        
    }
}

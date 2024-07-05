using Microsoft.Extensions.DependencyInjection;
using OrdinancaESyve.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace OrdinancaESyve.Utilities
{
    internal class CreateDbConnection
    {
        public static OrdinancaDbContext makeMySqlConnection()
        {
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddDbContext<OrdinancaDbContext>(options =>
                options.UseMySql("server=localhost;userid=root;database=ordinanca_syve;",
                    ServerVersion.AutoDetect("server=localhost;userid=root;database=ordinanca_syve;")));
            var serviceProvider = serviceCollection.BuildServiceProvider();

            return serviceProvider.GetService<OrdinancaDbContext>();
        }
    }
}

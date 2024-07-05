using Microsoft.EntityFrameworkCore;
using OrdinancaESyve.Data;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.VisualBasic.ApplicationServices; // Add this using statement

namespace OrdinancaESyve
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // Set up the service collection
            var serviceCollection = new ServiceCollection();
            serviceCollection.AddDbContext<OrdinancaDbContext>(options =>
                options.UseMySql("server=localhost;userid=root;database=ordinanca_syve;",
                    ServerVersion.AutoDetect("server=localhost;userid=root;database=ordinanca_syve;")));
            var serviceProvider = serviceCollection.BuildServiceProvider();

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new IdentifikohuForm(serviceProvider.GetService<OrdinancaDbContext>()));
        }
    }
}
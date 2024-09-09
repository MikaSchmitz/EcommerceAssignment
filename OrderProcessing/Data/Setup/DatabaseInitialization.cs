using Microsoft.EntityFrameworkCore;
using OrderProcessing.Configuration;
using System.Diagnostics;

namespace OrderProcessing.Data.Setup
{
    internal static class DatabaseInitialization
    {
        /// <summary>
        /// Adds the database to the application in a way that makes it accessable via services
        /// </summary>
        /// <param name="services"></param>
        internal static void AddDataLayer(this IServiceCollection services)
        {
            services.AddDatabase();
            services.AddRepositories();
            services.AddDataAccessLayer();
        }

        /// <summary>
        /// Try to connect to the database
        /// </summary>
        /// <param name="services"></param>
        private static void AddDatabase(this IServiceCollection services)
        {
            try
            {
                Debug.WriteLine("Connecting to database...");
                var connectionString = AppSettingsManager.AppSettings.ConnectionStrings.Database;
                services.AddDbContext<ApplicationDbContext>(options =>
                    options.UseSqlServer(connectionString)
                );
                Debug.WriteLine("Successfully connected to database!");
            }
            catch
            {
                Debug.WriteLine("Failed to connect to database");
            }
        }

        /// <summary>
        /// Scope all repositories allowing us to access each database table via the coresponding repository interface
        /// </summary>
        /// <param name="services"></param>
        private static void AddRepositories(this IServiceCollection services)
        {
            try
            {
                Debug.WriteLine("Scoping database repositories...");

                // Scope repositories...

                Debug.WriteLine("Successfully scoped all repositories!");
            }
            catch
            {
                Debug.WriteLine("Failed to scope all repositories");
            }
        }

        /// <summary>
        /// Scope all database related services, allowing us to create a seperate layer for all database related queries
        /// </summary>
        /// <param name="services"></param>
        private static void AddDataAccessLayer(this IServiceCollection services)
        {
            try
            {
                Debug.WriteLine("Scoping services...");

                // Scope services...

                Debug.WriteLine("Successfully scoped all services!");
            }
            catch
            {
                Debug.WriteLine("Failed to setup data access layer");
            }
        }
    }
}

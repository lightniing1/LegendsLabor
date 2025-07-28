using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace LegendsLabor.Infrastructure
{
    public class DesignTimeDbContextFactory : IDesignTimeDbContextFactory<LegendsLaborDbContext>
    {
        public LegendsLaborDbContext CreateDbContext(string[] args)
        {
            // Build configuration
            IConfigurationRoot configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var builder = new DbContextOptionsBuilder<LegendsLaborDbContext>();
            var connectionString = configuration.GetConnectionString("Postgres");

            builder.UseNpgsql(connectionString);

            return new LegendsLaborDbContext(builder.Options);
        }
    }
}
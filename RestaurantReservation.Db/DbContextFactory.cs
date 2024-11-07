using Microsoft.EntityFrameworkCore.Design;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace RestaurantReservation.Db
{
    public class DbContextFactory : IDesignTimeDbContextFactory<RestaurantReservationDbContext>
    {
        public RestaurantReservationDbContext CreateDbContext(string[] args = null)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\")))
                .AddJsonFile("appsettings.json")
                .Build();

            var optionsBuilder = new DbContextOptionsBuilder<RestaurantReservationDbContext>();
            optionsBuilder.UseSqlServer(configuration.GetConnectionString("DefaultConnection"));

            return new RestaurantReservationDbContext(optionsBuilder.Options);
        }
    }
}

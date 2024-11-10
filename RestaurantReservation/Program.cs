using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RestaurantReservation.Db;
using RestaurantReservation.Db.Repositories;
using RestaurantReservation.Db.RepositoriesInterfaces;

namespace RestaurantReservation
{
    public class Program
    {
        public static async Task Main(string[] args)
        {
            var host = CreateHostBuilder(args).Build();
            host.Start();

            var customerservice = host.Services.GetRequiredService<ICustomerRepository>();
            var customers = await customerservice.GetCustomersWithPartySizeGreaterThanAsync(3, 2, 2);
            Console.WriteLine($"Count of customers that have party size greater than 3 is: {customers.count}.");
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureServices((context, services) =>
                {
                    var configuration = new ConfigurationBuilder().SetBasePath(Path.GetFullPath(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, @"..\..\..\")))
                    .AddJsonFile("appsettings.json", optional: false, reloadOnChange: true)
                    .Build();

                    services.AddDbContext<RestaurantReservationDbContext>(options =>
                        options.UseSqlServer(configuration.GetConnectionString("RestaurantReservationCore")));

                    services.AddScoped<ICustomerRepository, CustomerRepository>();
                    services.AddScoped<IEmployeeRepository, EmployeeRepository>();
                    services.AddScoped<IMenuItemRepository, MenuItemRepository>();
                    services.AddScoped<IOrderItemRepository, OrderItemRepository>();
                    services.AddScoped<IOrderRepository, OrderRepository>();
                    services.AddScoped<IReservationRepository, ReservationRepository>();
                    services.AddScoped<IRestaurantRepository, RestaurantRepository>();
                    services.AddScoped<ITableRepository, TableRepository>();
                });
    }
}
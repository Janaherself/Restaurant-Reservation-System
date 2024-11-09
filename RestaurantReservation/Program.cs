using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using RestaurantReservation.Db;
using RestaurantReservation.Db.Repositories;
using RestaurantReservation.Db.RepositoriesInterfaces;

public class Program
{
    public static void Main(string[] args)
    {
        var host = CreateHostBuilder(args).Build();
        host.Run();
    }

    public static IHostBuilder CreateHostBuilder(string[] args) =>
        Host.CreateDefaultBuilder(args)
            .ConfigureServices((context, services) =>
            {
                services.AddDbContext<RestaurantReservationDbContext>(options =>
                    options.UseSqlServer(context.Configuration.GetConnectionString("RestaurantReservationCore")));

                services.AddSingleton<DbContextFactory>();
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

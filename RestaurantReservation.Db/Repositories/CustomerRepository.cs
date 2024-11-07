using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.DataModels;
using RestaurantReservation.Db.RepositoriesInterfaces;

namespace RestaurantReservation.Db.Repositories
{
    public class CustomerRepository : ICustomerRepository, IDisposable
    {
        private readonly RestaurantReservationDbContext _context;
        private bool _disposed = false;

        public CustomerRepository(DbContextFactory factory)
        {
            _context = factory.CreateDbContext();
        }

        public async Task CreateCustomerAsync(Customer customer)
        {
            _context.Customers.Add(customer);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateCustomerAsync(Customer customer)
        {
            _context.Customers.Update(customer);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteCustomerAsync(int customerId)
        {
            var customer = _context.Customers.Find(customerId);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<(int count, List<Customer> customers)> GetCustomersWithPartySizeGreaterThanAsync(int partySize, int pageNumber, int pageSize)
        {
            var count = await _context.Database
                        .SqlQuery<int>($"GetCountOfCustomerWithPartySizeGreaterThan {partySize}")
                        .ToListAsync();

            var customer = await _context.Customers
                           .FromSqlInterpolated($"GetCustomersWithPartySizeGreaterThan {partySize}, {pageNumber}, {pageSize}")
                           .ToListAsync();

            return (count[0], customer);
        }

        public void Dispose()
        {
            if (!_disposed)
            {
                _context.Dispose();
                _disposed = true;
            }
        }
    }
}
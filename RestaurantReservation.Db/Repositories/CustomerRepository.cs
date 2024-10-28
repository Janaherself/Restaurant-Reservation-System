using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.DataModels;
using RestaurantReservation.Db.RepositoriesInterfaces;

namespace RestaurantReservation.Db.Repositories
{
    public class CustomerRepository : BaseRepository, ICustomerRepository
    {
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

        public async Task<List<Customer>> GetCustomersWithPartySizeGreaterThanAsync(int partySize, int pageNumber, int pageSize)
        {
            return await _context.Customers
                           .FromSqlInterpolated($"GetCustomersWithPartySizeGreaterThan {partySize}, {pageNumber}, {pageSize}")
                           .ToListAsync();
        }
    }
}
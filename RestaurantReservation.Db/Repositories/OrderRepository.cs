using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.DataModels;
using RestaurantReservation.Db.RepositoriesInterfaces;

namespace RestaurantReservation.Db.Repositories
{
    public class OrderRepository : IOrderRepository, IDisposable
    {
        private readonly RestaurantReservationDbContext _context;
        private bool _disposed = false;

        public OrderRepository(DbContextFactory factory)
        {
            _context = factory.CreateDbContext();
        }

        public async Task CreateOrderAsync(Order order)
        {
            _context.Orders.Add(order);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateOrderAsync(Order order)
        {
            _context.Orders.Update(order);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteOrderAsync(int OrderId)
        {
            var order = _context.Orders.Find(OrderId);
            if (order != null)
            {
                _context.Orders.Remove(order);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Order>> ListOrdersAndMenuItemsAsync(int reservationId)
        {
            return await _context.Orders
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.MenuItem)
                .Where(o => o.ReservationId == reservationId)
                .ToListAsync();
        }

        public async Task<decimal> CalculateAverageOrderAmountAsync(int employeeId)
        {
            var orders = await _context.Orders
                                       .Where(o => o.EmployeeId == employeeId)
                                       .ToListAsync();

            return orders.Count != 0 ? orders.Average(o => o.TotalAmount) : 0;
        }

        public async Task<decimal> CalculateTotalRevenueByRestaurantAsync(int restaurantId)
        {
            return await _context.Database
                                 .SqlQuery<decimal>($"SELECT dbo.CalculateTotalRevenue({restaurantId}) AS Value")
                                 .SingleAsync();
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
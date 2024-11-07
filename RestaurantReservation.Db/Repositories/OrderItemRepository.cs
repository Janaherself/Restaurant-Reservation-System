using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.DataModels;
using RestaurantReservation.Db.RepositoriesInterfaces;

namespace RestaurantReservation.Db.Repositories
{
    public class OrderItemRepository : IOrderItemRepository, IDisposable
    {
        private readonly RestaurantReservationDbContext _context;
        private bool _disposed = false;

        public OrderItemRepository(DbContextFactory factory)
        {
            _context = factory.CreateDbContext();
        }

        public async Task CreateOrderItemAsync(OrderItem orderItem)
        {
            _context.OrderItems.Add(orderItem);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateOrderItemAsync(OrderItem orderItem)
        {
            _context.OrderItems.Update(orderItem);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteOrderItemAsync(int orderItemId)
        {
            var orderItem = _context.OrderItems.Find(orderItemId);
            if (orderItem != null)
            {
                _context.OrderItems.Remove(orderItem);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<MenuItem>> ListOrderedMenuItemsAsync(int reservationId)
        {
            return await _context.OrderItems
                           .Include(oi => oi.MenuItem)
                           .Where(oi => oi.Order.ReservationId == reservationId)
                           .Select(oi => oi.MenuItem)
                           .ToListAsync();
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
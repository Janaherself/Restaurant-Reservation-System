using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.DataModels;

namespace RestaurantReservation.Db.Repositories
{
    public class OrderItemRepository
    {
        private readonly RestaurantReservationDbContext _context;

        public OrderItemRepository(RestaurantReservationDbContext context)
        {
            _context = context;
        }

        public void CreateOrderItem(OrderItem orderItem)
        {
            _context.OrderItems.Add(orderItem);
            _context.SaveChanges();
        }

        public void UpdateOrderItem(OrderItem orderItem)
        {
            var existingOrderItem = _context.OrderItems.Find(orderItem.OrderItemId);
            if (existingOrderItem != null)
            {
                existingOrderItem.OrderId = orderItem.OrderId;
                existingOrderItem.MenuItemId = orderItem.MenuItemId;
                existingOrderItem.Quantity = orderItem.Quantity;
                existingOrderItem.Order = orderItem.Order;
                existingOrderItem.MenuItem = orderItem.MenuItem;
                _context.SaveChanges();
            }
        }

        public void DeleteOrderItem(int orderItemId)
        {
            var orderItem = _context.OrderItems.Find(orderItemId);
            if (orderItem != null)
            {
                _context.OrderItems.Remove(orderItem);
                _context.SaveChanges();
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
    }
}
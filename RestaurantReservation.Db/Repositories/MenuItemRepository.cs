using RestaurantReservation.Db.DataModels;

namespace RestaurantReservation.Db.Repositories
{
    public class MenuItemRepository
    {
        private readonly RestaurantReservationDbContext _context;

        public MenuItemRepository(RestaurantReservationDbContext context)
        {
            _context = context;
        }

        public void CreateMenuItem(MenuItem menuItem)
        {
            _context.MenuItem.Add(menuItem);
            _context.SaveChanges();
        }

        public void UpdateMenuItem(MenuItem menuItem)
        {
            var existingMenuItem = _context.MenuItem.Find(menuItem.MenuItemId);
            if (existingMenuItem != null)
            {
                existingMenuItem.Name = menuItem.Name;
                existingMenuItem.Description = menuItem.Description;
                existingMenuItem.Price = menuItem.Price;
                existingMenuItem.Restaurant = menuItem.Restaurant;
                existingMenuItem.RestaurantId = menuItem.RestaurantId;
                existingMenuItem.OrderItems = menuItem.OrderItems;
                _context.SaveChanges();
            }
        }

        public void DeleteMenuItem(int menuItemId)
        {
            var menuItem = _context.MenuItem.Find(menuItemId);
            if (menuItem != null)
            {
                _context.MenuItem.Remove(menuItem);
                _context.SaveChanges();
            }
        }
    }
}
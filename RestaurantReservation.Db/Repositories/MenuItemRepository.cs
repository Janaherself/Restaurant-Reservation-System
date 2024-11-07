using RestaurantReservation.Db.DataModels;
using RestaurantReservation.Db.RepositoriesInterfaces;

namespace RestaurantReservation.Db.Repositories
{
    public class MenuItemRepository : IMenuItemRepository, IDisposable
    {
        private readonly RestaurantReservationDbContext _context;
        private bool _disposed = false;

        public MenuItemRepository(DbContextFactory factory)
        {
            _context = factory.CreateDbContext();
        }

        public async Task CreateMenuItemAsync(MenuItem menuItem)
        {
            _context.MenuItem.Add(menuItem);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateMenuItemAsync(MenuItem menuItem)
        {
            _context.MenuItem.Update(menuItem);
            await _context.SaveChangesAsync();

        }

        public async Task DeleteMenuItemAsync(int menuItemId)
        {
            var menuItem = _context.MenuItem.Find(menuItemId);
            if (menuItem != null)
            {
                _context.MenuItem.Remove(menuItem);
                await _context.SaveChangesAsync();
            }
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
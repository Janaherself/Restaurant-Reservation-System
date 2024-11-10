using RestaurantReservation.Db.DataModels;
using RestaurantReservation.Db.RepositoriesInterfaces;

namespace RestaurantReservation.Db.Repositories
{
    public class MenuItemRepository : BaseRepository, IMenuItemRepository
    {
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
    }
}
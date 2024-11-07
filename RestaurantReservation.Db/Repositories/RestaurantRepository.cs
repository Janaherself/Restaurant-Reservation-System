using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.DataModels;
using RestaurantReservation.Db.RepositoriesInterfaces;

namespace RestaurantReservation.Db.Repositories
{
    public class RestaurantRepository : IRestaurantRepository, IDisposable
    {
        private readonly RestaurantReservationDbContext _context;
        private bool _disposed = false;

        public RestaurantRepository(DbContextFactory factory)
        {
            _context = factory.CreateDbContext();
        }

        public async Task CreateRestaurantAsync(Restaurant restaurant)
        {
            _context.Restaurants.Add(restaurant);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateMenuItemAsync(Restaurant restaurant)
        {
            _context.Restaurants.Update(restaurant);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteRestaurantAsync(int restaurantId)
        {
            var restaurant = _context.Restaurants.Find(restaurantId);
            if (restaurant != null)
            {
                _context.Restaurants.Remove(restaurant);
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
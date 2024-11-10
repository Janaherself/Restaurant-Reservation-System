using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.DataModels;
using RestaurantReservation.Db.RepositoriesInterfaces;

namespace RestaurantReservation.Db.Repositories
{
    public class RestaurantRepository : BaseRepository, IRestaurantRepository
    {
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
    }
}
using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.DataModels;

namespace RestaurantReservation.Db.Repositories
{
    public class RestaurantRepository
    {
        private readonly RestaurantReservationDbContext _context;

        public RestaurantRepository(RestaurantReservationDbContext context)
        {
            _context = context;
        }

        public void CreateRestaurant(Restaurant restaurant)
        {
            _context.Restaurants.Add(restaurant);
            _context.SaveChanges();
        }

        public void UpdateMenuItem(Restaurant restaurant)
        {
            var existingRestaurant = _context.Restaurants.Find(restaurant.RestaurantId);
            if (existingRestaurant != null)
            {
                existingRestaurant.Name = restaurant.Name;
                existingRestaurant.Address = restaurant.Address;
                existingRestaurant.PhoneNumber = restaurant.PhoneNumber;
                existingRestaurant.OpeningHours = restaurant.OpeningHours;
                existingRestaurant.Reservations = restaurant.Reservations;
                existingRestaurant.Employees = restaurant.Employees;
                existingRestaurant.MenuItems = restaurant.MenuItems;
                existingRestaurant.Tables = restaurant.Tables;
                _context.SaveChanges();
            }
        }

        public void DeleteRestaurant(int restaurantId)
        {
            var restaurant = _context.Restaurants.Find(restaurantId);
            if (restaurant != null)
            {
                _context.Restaurants.Remove(restaurant);
                _context.SaveChanges();
            }
        }
    }
}
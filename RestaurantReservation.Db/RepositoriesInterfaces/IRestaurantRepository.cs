using RestaurantReservation.Db.DataModels;

namespace RestaurantReservation.Db.RepositoriesInterfaces
{
    public interface IRestaurantRepository
    {
        Task CreateRestaurantAsync(Restaurant restaurant);
        Task DeleteRestaurantAsync(int restaurantId);
        Task UpdateMenuItemAsync(Restaurant restaurant);
    }
}
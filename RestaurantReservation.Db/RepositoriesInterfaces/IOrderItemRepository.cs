using RestaurantReservation.Db.DataModels;

namespace RestaurantReservation.Db.RepositoriesInterfaces
{
    public interface IOrderItemRepository
    {
        Task CreateOrderItemAsync(OrderItem orderItem);
        Task DeleteOrderItemAsync(int orderItemId);
        Task<List<MenuItem>> ListOrderedMenuItemsAsync(int reservationId);
        Task UpdateOrderItemAsync(OrderItem orderItem);
    }
}
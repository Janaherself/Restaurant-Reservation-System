using RestaurantReservation.Db.DataModels;

namespace RestaurantReservation.Db.RepositoriesInterfaces
{
    public interface IOrderRepository
    {
        Task<decimal> CalculateAverageOrderAmountAsync(int employeeId);
        Task<decimal> CalculateTotalRevenueByRestaurantAsync(int restaurantId);
        Task CreateOrderAsync(Order order);
        Task DeleteOrderAsync(int OrderId);
        Task<List<Order>> ListOrdersAndMenuItemsAsync(int reservationId);
        Task UpdateOrderAsync(Order order);
    }
}
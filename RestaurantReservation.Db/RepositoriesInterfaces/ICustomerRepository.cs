using RestaurantReservation.Db.DataModels;

namespace RestaurantReservation.Db.RepositoriesInterfaces
{
    public interface ICustomerRepository
    {
        Task CreateCustomerAsync(Customer customer);
        Task DeleteCustomerAsync(int customerId);
        Task<List<Customer>> GetCustomersWithPartySizeGreaterThanAsync(int partySize, int pageNumber, int pageSize);
        Task UpdateCustomerAsync(Customer customer);
    }
}
using RestaurantReservation.Db.DataModels;

namespace RestaurantReservation.Db.RepositoriesInterfaces
{
    public interface ITableRepository
    {
        Task CreateTableAsync(Table table);
        Task DeleteTableAsync(int tableId);
        Task UpdateTableAsync(Table table);
    }
}
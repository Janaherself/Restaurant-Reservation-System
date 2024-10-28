using RestaurantReservation.Db.DataModels;

namespace RestaurantReservation.Db.RepositoriesInterfaces
{
    public interface IEmployeeRepository
    {
        Task CreateEmployeeAsync(Employee employee);
        Task DeleteEmployeeAsync(int employeeId);
        Task<List<EmployeeView>> EmployeeViewAsync();
        Task<List<Employee>> ListManagersAsync();
        Task UpdateEmployeeAsync(Employee employee);
    }
}
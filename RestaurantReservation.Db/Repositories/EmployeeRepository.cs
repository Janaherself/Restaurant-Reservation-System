using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.DataModels;
using RestaurantReservation.Db.RepositoriesInterfaces;

namespace RestaurantReservation.Db.Repositories
{
    public class EmployeeRepository : IEmployeeRepository, IDisposable
    {
        private readonly RestaurantReservationDbContext _context;
        private bool _disposed = false;

        public EmployeeRepository(DbContextFactory factory)
        {
            _context = factory.CreateDbContext();
        }

        public async Task CreateEmployeeAsync(Employee employee)
        {
            _context.Employees.Add(employee);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateEmployeeAsync(Employee employee)
        {
            _context.Employees.Update(employee);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteEmployeeAsync(int employeeId)
        {
            var employee = _context.Employees.Find(employeeId);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                await _context.SaveChangesAsync();
            }
        }
        public async Task<List<Employee>> ListManagersAsync()
        {
            return await _context.Employees.Where(e => e.Position == "Manager").ToListAsync();
        }

        public async Task<List<EmployeeView>> ListEmployeeViewAsync()
        {
            return await _context.EmployeesView.ToListAsync();
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
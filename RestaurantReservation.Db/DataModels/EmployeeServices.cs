using Microsoft.EntityFrameworkCore;

namespace RestaurantReservation.Db.DataModels
{
    public class EmployeeServices
    {
        private readonly RestaurantReservationDbContext _context;

        public EmployeeServices(RestaurantReservationDbContext context)
        {
            _context = context;
        }

        public void CreateEmployee(Employee employee)
        {
            _context.Employees.Add(employee);
            _context.SaveChanges();
        }

        public void UpdateEmployee(Employee employee)
        {
            var existingEmployee = _context.Employees.Find(employee.EmployeeId);
            if (existingEmployee != null)
            {
                existingEmployee.FirstName = employee.FirstName;
                existingEmployee.LastName = employee.LastName;
                existingEmployee.Position = employee.Position;
                existingEmployee.Restaurant = employee.Restaurant;
                existingEmployee.RestaurantId = employee.RestaurantId;
                existingEmployee.Orders = employee.Orders;
                _context.SaveChanges();
            }
        }

        public void DeleteEmployee(int employeeId)
        {
            var employee = _context.Employees.Find(employeeId);
            if (employee != null)
            {
                _context.Employees.Remove(employee);
                _context.SaveChanges();
            }
        }
        public async Task<List<Employee>> ListManagersAsync()
        {
            return await _context.Employees.Where(e => e.Position == "Manager").ToListAsync();
        }

        public async Task<List<EmployeeView>> EmployeeViewAsync()
        {
            return await _context.EmployeesView.ToListAsync();
        }
    }
}
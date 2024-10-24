namespace RestaurantReservation.Db.DataModels
{
    public class Employee
    {
        public Employee()
        {
            Orders = new List<Order>();
        }

        public int EmployeeId { get; set; }
        public int? RestaurantId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public Restaurant Restaurant { get; set; }
        public List<Order> Orders { get; set; }
    }
}

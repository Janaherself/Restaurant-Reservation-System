namespace RestaurantReservation.Db.DataModels
{
    public class Restaurant
    {
        public Restaurant()
        {
            Reservations = new List<Reservation>();
            Employees = new List<Employee>();
            MenuItems = new List<MenuItem>();
            Tables = new List<Table>();
        }

        public int RestaurantId { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string PhoneNumber { get; set; }
        public string OpeningHours { get; set; }
        public List<Reservation> Reservations { get; set; }
        public List<Employee> Employees { get; set; }
        public List<MenuItem> MenuItems { get; set; }
        public List<Table> Tables { get; set; }
    }
}

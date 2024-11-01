namespace RestaurantReservation.Db.DataModels
{
    public class EmployeeView
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public string RestaurantName { get; set; }
        public string Address { get; set; }
        public string OpeningHours { get; set; }
        public string PhoneNumber { get; set; }

    }
}

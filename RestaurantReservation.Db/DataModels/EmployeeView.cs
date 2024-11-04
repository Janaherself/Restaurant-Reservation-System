namespace RestaurantReservation.Db.DataModels
{
    public class EmployeeView
    {
        public int EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public string EmployeePosition { get; set; }
        public string RestaurantName { get; set; }
        public string RestaurantAddress { get; set; }
        public string OpeningHours { get; set; }
        public string RestaurantPhoneNumber { get; set; }

    }
}

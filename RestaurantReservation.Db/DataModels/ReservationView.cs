namespace RestaurantReservation.Db.DataModels
{
    public class ReservationView
    {
        public int ReservationId { get; set; }
        public int CustomerId { get; set; }
        public string CustomerFirstName { get; set; }
        public string CustomerLastName { get; set; }
        public string CustomerPhoneNumber { get; set; }
        public string RestaurantName { get; set; }
        public string RestaurantAddress { get; set; }
        public string RestaurantPhoneNumber { get; set; }
        public string OpeningHours { get; set; }
        public DateTime ReservationDate { get; set; }
    }
}

namespace RestaurantReservation.Db.DataModels
{
    public class ReservationView
    {
        public int ReservationId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string RestaurantName { get; set; }
        public DateTime ReservationDate { get; set; }
    }
}

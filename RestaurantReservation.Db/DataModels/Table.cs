namespace RestaurantReservation.Db.DataModels
{
    public class Table
    {
        public Table()
        {
            Reservations = new List<Reservation>();
        }

        public int TableId { get; set; }
        public int? RestaurantId { get; set; }
        public int Capacity { get; set; }
        public Restaurant Restaurant { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}

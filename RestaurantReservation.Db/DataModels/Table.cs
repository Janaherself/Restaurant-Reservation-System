namespace RestaurantReservation.Db.DataModels
{
    public class Table
    {
        public int TableId { get; set; }
        public int RestaurantId { get; set; }
        public int Capacity { get; set; }
    }
}

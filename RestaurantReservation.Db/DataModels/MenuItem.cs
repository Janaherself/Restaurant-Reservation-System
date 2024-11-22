namespace RestaurantReservation.Db.DataModels
{
    public class MenuItem
    {
        public MenuItem()
        {
            OrderItems = new List<OrderItem>();
        }

        public int MenuItemId { get; set; }
        public int? RestaurantId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public Restaurant Restaurant { get; set; }
        public List<OrderItem> OrderItems { get; set; }
    }
}

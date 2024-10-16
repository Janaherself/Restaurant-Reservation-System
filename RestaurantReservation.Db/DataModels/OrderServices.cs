namespace RestaurantReservation.Db.DataModels
{
    public class OrderServices
    {
        private readonly RestaurantReservationDbContext _context;

        public OrderServices(RestaurantReservationDbContext context)
        {
            _context = context;
        }

        public void CreateOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public void UpdateOrder(Order order)
        {
            var existingOrder = _context.Orders.Find(order.OrderId);
            if (existingOrder != null)
            {
                existingOrder.ReservationId = order.ReservationId;
                existingOrder.EmployeeId = order.EmployeeId;
                existingOrder.OrderDate = order.OrderDate;
                existingOrder.TotalAmount = order.TotalAmount;
                existingOrder.Reservation = order.Reservation;
                existingOrder.Employee = order.Employee;
                existingOrder.OrderItems = order.OrderItems;
                _context.SaveChanges();
            }
        }

        public void DeleteOrder(int OrderId)
        {
            var order = _context.Orders.Find(OrderId);
            if (order != null)
            {
                _context.Orders.Remove(order);
                _context.SaveChanges();
            }
        }
    }
}
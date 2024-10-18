using Microsoft.EntityFrameworkCore;

namespace RestaurantReservation.Db.DataModels
{
    public class ReservationServices
    {
        private readonly RestaurantReservationDbContext _context;

        public ReservationServices(RestaurantReservationDbContext context)
        {
            _context = context;
        }

        public void CreateReservation(Reservation reservation)
        {
            _context.Reservations.Add(reservation);
            _context.SaveChanges();
        }

        public void UpdateReservation(Reservation reservation)
        {
            var existingreservation = _context.Reservations.Find(reservation.ReservationId);
            if (existingreservation != null)
            {
                existingreservation.CustomerId = reservation.CustomerId;
                existingreservation.RestaurantId = reservation.RestaurantId;
                existingreservation.TableId = reservation.TableId;
                existingreservation.ReservationDate = reservation.ReservationDate;
                existingreservation.PartySize = reservation.PartySize;
                existingreservation.Customer = reservation.Customer;
                existingreservation.Restaurant = reservation.Restaurant;
                existingreservation.Table = reservation.Table;
                existingreservation.Orders = reservation.Orders;
                _context.SaveChanges();
            }
        }

        public void DeleteReservation(int reservationId)
        {
            var reservation = _context.Reservations.Find(reservationId);
            if (reservation != null)
            {
                _context.Reservations.Remove(reservation);
                _context.SaveChanges();
            }
        }

        public async Task<List<Order>> ListOrdersAndMenuItems(int reservationId)
        {
            return await _context.Orders
                .Include(o => o.OrderItems)
                .ThenInclude(oi => oi.MenuItem)
                .Where(o => o.ReservationId == reservationId)
                .ToListAsync();
        }
    }
}
using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.DataModels;
using RestaurantReservation.Db.RepositoriesInterfaces;

namespace RestaurantReservation.Db.Repositories
{
    public class ReservationRepository : IReservationRepository, IDisposable
    {
        private readonly RestaurantReservationDbContext _context;
        private bool _disposed = false;

        public ReservationRepository(DbContextFactory factory)
        {
            _context = factory.CreateDbContext();
        }

        public async Task CreateReservationAsync(Reservation reservation)
        {
            _context.Reservations.Add(reservation);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateReservationAsync(Reservation reservation)
        {
            _context.Reservations.Update(reservation);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteReservationAsync(int reservationId)
        {
            var reservation = _context.Reservations.Find(reservationId);
            if (reservation != null)
            {
                _context.Reservations.Remove(reservation);
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<Reservation>> GetReservationsByCustomerAsync(int customerId)
        {
            return await _context.Reservations
                           .Include(c => c.Customer)
                           .Include(c => c.Restaurant)
                           .Where(c => c.CustomerId == customerId)
                           .ToListAsync();
        }

        public async Task<List<ReservationView>> ListReservationViewAsync()
        {
            return await _context.ReservationsView.ToListAsync();
        }

        public void Dispose()
        {
            if (!_disposed)
            {
                _context.Dispose();
                _disposed = true;
            }
        }
    }
}
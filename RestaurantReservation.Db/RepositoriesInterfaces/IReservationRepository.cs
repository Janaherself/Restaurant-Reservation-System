using RestaurantReservation.Db.DataModels;

namespace RestaurantReservation.Db.RepositoriesInterfaces
{
    public interface IReservationRepository
    {
        Task CreateReservationAsync(Reservation reservation);
        Task DeleteReservationAsync(int reservationId);
        Task<List<Reservation>> GetReservationsByCustomerAsync(int customerId);
        Task<List<ReservationView>> ReservationViewAsync();
        Task UpdateReservationAsync(Reservation reservation);
    }
}
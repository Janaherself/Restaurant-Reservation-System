namespace RestaurantReservation.Db.Repositories
{
    public class BaseRepository
    {
        internal readonly RestaurantReservationDbContext _context = new();
    }
}
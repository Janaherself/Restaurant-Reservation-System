using RestaurantReservation.Db.DataModels;
using RestaurantReservation.Db.RepositoriesInterfaces;

namespace RestaurantReservation.Db.Repositories
{
    public class TableRepository : ITableRepository, IDisposable
    {
        private readonly RestaurantReservationDbContext _context;
        private bool _disposed = false;

        public TableRepository(DbContextFactory factory)
        {
            _context = factory.CreateDbContext();
        }

        public async Task CreateTableAsync(Table table)
        {
            _context.Tables.Add(table);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateTableAsync(Table table)
        {
            _context.Tables.Update(table);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteTableAsync(int tableId)
        {
            var table = _context.Tables.Find(tableId);
            if (table != null)
            {
                _context.Tables.Remove(table);
                await _context.SaveChangesAsync();
            }
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
using RestaurantReservation.Db.DataModels;

namespace RestaurantReservation.Db.Repositories
{
    public class TableRepository
    {
        private readonly RestaurantReservationDbContext _context;

        public TableRepository(RestaurantReservationDbContext context)
        {
            _context = context;
        }

        public void CreateTable(Table table)
        {
            _context.Tables.Add(table);
            _context.SaveChanges();
        }

        public void UpdateTable(Table table)
        {
            var existingTable = _context.Tables.Find(table.TableId);
            if (existingTable != null)
            {
                existingTable.Capacity = table.Capacity;
                existingTable.Restaurant = table.Restaurant;
                existingTable.RestaurantId = table.RestaurantId;
                existingTable.Reservations = table.Reservations;
                _context.SaveChanges();
            }
        }

        public void DeleteTable(int tableId)
        {
            var table = _context.Tables.Find(tableId);
            if (table != null)
            {
                _context.Tables.Remove(table);
                _context.SaveChanges();
            }
        }
    }
}
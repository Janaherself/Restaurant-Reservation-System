using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.DataModels;

namespace RestaurantReservation.Db
{
    public class RestaurantReservationDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<MenuItem> MenuItem { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderItem> OrderItems { get; set; }
        public DbSet<Reservation> Reservations { get; set; }
        public DbSet<Restaurant> Restaurants { get; set; }
        public DbSet<Table> Tables { get; set; }
        public DbSet<ReservationView> ReservationsView { get; set; }
        public DbSet<EmployeeView> EmployeesView { get; set; }



        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(
                "Data Source = LAPTOP-5RBHM2O9; Initial Catalog = RestaurantReservationCore; Trusted_Connection = True; TrustServerCertificate = True"
                );
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<EmployeeView>().HasNoKey().ToView("EmployeesView");

            modelBuilder.Entity<ReservationView>().HasNoKey().ToView("ReservationsView");

            modelBuilder.Entity<OrderItem>()
                .ToTable("OrderItems");

            modelBuilder.Entity<Customer>().HasData(
                new Customer { CustomerId = 1, FirstName = "John", LastName = "Doe", Email = "john.doe@example.com", PhoneNumber = "1234567890" },
                new Customer { CustomerId = 2, FirstName = "Jane", LastName = "Smith", Email = "jane.smith@example.com", PhoneNumber = "2345678901" },
                new Customer { CustomerId = 3, FirstName = "Alice", LastName = "Johnson", Email = "alice.johnson@example.com", PhoneNumber = "3456789012" },
                new Customer { CustomerId = 4, FirstName = "Bob", LastName = "Brown", Email = "bob.brown@example.com", PhoneNumber = "4567890123" },
                new Customer { CustomerId = 5, FirstName = "Emma", LastName = "Davis", Email = "emma.davis@example.com", PhoneNumber = "5678901234" }
            );

            modelBuilder.Entity<Restaurant>().HasData(
                new Restaurant { RestaurantId = 1, Name = "Ocean Grill", Address = "123 Sea Road", PhoneNumber = "0987654321", OpeningHours = "9:00 AM - 10:00 PM" },
                new Restaurant { RestaurantId = 2, Name = "Mountain View Cafe", Address = "456 Mountain Drive", PhoneNumber = "8765432109", OpeningHours = "8:00 AM - 9:00 PM" },
                new Restaurant { RestaurantId = 3, Name = "Sunset Bistro", Address = "789 Sunset Blvd", PhoneNumber = "7654321098", OpeningHours = "10:00 AM - 11:00 PM" },
                new Restaurant { RestaurantId = 4, Name = "Sage & Salt", Address = "521 Mountain Hugo", PhoneNumber = "8123892109", OpeningHours = "11:00 AM - 12:00 AM" },
                new Restaurant { RestaurantId = 5, Name = "Lord of the Fries", Address = "473 St. Carlo Road", PhoneNumber = "8765447589", OpeningHours = "11:00 AM - 11:00 PM" },
                new Restaurant { RestaurantId = 6, Name = "Tres Gatos", Address = "496 5th Blvd", PhoneNumber = "8362514013", OpeningHours = "6:00 PM - 12:00 AM" }
            );

            modelBuilder.Entity<Table>().HasData(
                new Table { TableId = 1, RestaurantId = 1, Capacity = 4 },
                new Table { TableId = 2, RestaurantId = 1, Capacity = 4 },
                new Table { TableId = 3, RestaurantId = 2, Capacity = 2 },
                new Table { TableId = 4, RestaurantId = 3, Capacity = 6 },
                new Table { TableId = 5, RestaurantId = 3, Capacity = 4 },
                new Table { TableId = 6, RestaurantId = 4, Capacity = 6 },
                new Table { TableId = 7, RestaurantId = 5, Capacity = 2 },
                new Table { TableId = 8, RestaurantId = 5, Capacity = 2 },
                new Table { TableId = 9, RestaurantId = 5, Capacity = 4 },
                new Table { TableId = 10, RestaurantId = 5, Capacity = 5 },
                new Table { TableId = 11, RestaurantId = 6, Capacity = 5 },
                new Table { TableId = 12, RestaurantId = 6, Capacity = 2 },
                new Table { TableId = 13, RestaurantId = 6, Capacity = 4 }
            );

            modelBuilder.Entity<Employee>().HasData(
                new Employee { EmployeeId = 1, RestaurantId = 1, FirstName = "Chris", LastName = "Evans", Position = "Manager" },
                new Employee { EmployeeId = 2, RestaurantId = 2, FirstName = "Jessica", LastName = "Alba", Position = "Chef" },
                new Employee { EmployeeId = 3, RestaurantId = 1, FirstName = "Paul", LastName = "Walker", Position = "Waiter" },
                new Employee { EmployeeId = 4, RestaurantId = 3, FirstName = "Sophie", LastName = "Turner", Position = "Manager" },
                new Employee { EmployeeId = 5, RestaurantId = 4, FirstName = "Tom", LastName = "Holland", Position = "Waiter" },
                new Employee { EmployeeId = 6, RestaurantId = 4, FirstName = "Lexi", LastName = "Hensler", Position = "Chef" },
                new Employee { EmployeeId = 7, RestaurantId = 1, FirstName = "Alan", LastName = "Walker", Position = "Chef" },
                new Employee { EmployeeId = 8, RestaurantId = 5, FirstName = "Ben", LastName = "Azelart", Position = "Manager" },
                new Employee { EmployeeId = 9, RestaurantId = 5, FirstName = "Andrew", LastName = "Davilla", Position = "Waiter" },
                new Employee { EmployeeId = 10, RestaurantId = 6, FirstName = "Jeremy", LastName = "Hutchins", Position = "Waiter" }
            );

            modelBuilder.Entity<MenuItem>().HasData(
                new MenuItem { MenuItemId = 1, RestaurantId = 1, Name = "Grilled Salmon", Description = "Freshly grilled salmon with herbs", Price = 15.99M },
                new MenuItem { MenuItemId = 2, RestaurantId = 1, Name = "Caesar Salad", Description = "Classic Caesar salad with a twist", Price = 8.99M },
                new MenuItem { MenuItemId = 3, RestaurantId = 2, Name = "Pancake Stack", Description = "Fluffy pancakes with maple syrup", Price = 7.50M },
                new MenuItem { MenuItemId = 4, RestaurantId = 3, Name = "Beef Burger", Description = "Juicy beef burger with cheese", Price = 12.99M },
                new MenuItem { MenuItemId = 5, RestaurantId = 3, Name = "Pasta Alfredo", Description = "Creamy pasta with Alfredo sauce", Price = 14.50M },
                new MenuItem { MenuItemId = 6, RestaurantId = 4, Name = "Steak", Description = "Tender steak cooked to perfection", Price = 18.99M },
                new MenuItem { MenuItemId = 7, RestaurantId = 4, Name = "French Toast", Description = "Sweet and savory French toast", Price = 10.99M },
                new MenuItem { MenuItemId = 8, RestaurantId = 4, Name = "Veggie Omelette", Description = "Omelette with fresh veggies", Price = 7.99M },
                new MenuItem { MenuItemId = 9, RestaurantId = 4, Name = "Sliders", Description = "3 Mini burgers with fries", Price = 13.99M }

            );

            modelBuilder.Entity<Reservation>().HasData(
                new Reservation { ReservationId = 1, CustomerId = 1, RestaurantId = 1, TableId = 1, ReservationDate = DateTime.Now.AddDays(1), PartySize = 4 },
                new Reservation { ReservationId = 2, CustomerId = 2, RestaurantId = 2, TableId = 3, ReservationDate = DateTime.Now.AddDays(2), PartySize = 2 },
                new Reservation { ReservationId = 3, CustomerId = 3, RestaurantId = 1, TableId = 2, ReservationDate = DateTime.Now.AddDays(3), PartySize = 4 },
                new Reservation { ReservationId = 4, CustomerId = 4, RestaurantId = 3, TableId = 5, ReservationDate = DateTime.Now.AddDays(4), PartySize = 4 },
                new Reservation { ReservationId = 5, CustomerId = 5, RestaurantId = 3, TableId = 4, ReservationDate = DateTime.Now.AddDays(5), PartySize = 6 },
                new Reservation { ReservationId = 6, CustomerId = 1, RestaurantId = 6, TableId = 13, ReservationDate = DateTime.Now.AddDays(6), PartySize = 3 },
                new Reservation { ReservationId = 7, CustomerId = 3, RestaurantId = 5, TableId = 7, ReservationDate = DateTime.Now.AddDays(7), PartySize = 2 }

            );

            modelBuilder.Entity<Order>().HasData(
                new Order { OrderId = 1, ReservationId = 1, EmployeeId = 3, OrderDate = DateTime.Now, TotalAmount = 10 },
                new Order { OrderId = 2, ReservationId = 2, EmployeeId = 2, OrderDate = DateTime.Now, TotalAmount = 5 },
                new Order { OrderId = 3, ReservationId = 3, EmployeeId = 1, OrderDate = DateTime.Now, TotalAmount = 7 },
                new Order { OrderId = 4, ReservationId = 4, EmployeeId = 5, OrderDate = DateTime.Now, TotalAmount = 9 },
                new Order { OrderId = 5, ReservationId = 5, EmployeeId = 4, OrderDate = DateTime.Now, TotalAmount = 4 },
                new Order { OrderId = 6, ReservationId = 5, EmployeeId = 7, OrderDate = DateTime.Now, TotalAmount = 21 },
                new Order { OrderId = 7, ReservationId = 7, EmployeeId = 8, OrderDate = DateTime.Now, TotalAmount = 5 },
                new Order { OrderId = 8, ReservationId = 6, EmployeeId = 8, OrderDate = DateTime.Now, TotalAmount = 3 }
            );

            modelBuilder.Entity<OrderItem>().HasData(
                new OrderItem { OrderItemId = 1, OrderId = 1, MenuItemId = 1, Quantity = 5 },
                new OrderItem { OrderItemId = 2, OrderId = 1, MenuItemId = 2, Quantity = 4 },
                new OrderItem { OrderItemId = 3, OrderId = 2, MenuItemId = 3, Quantity = 2 },
                new OrderItem { OrderItemId = 4, OrderId = 3, MenuItemId = 1, Quantity = 3 },
                new OrderItem { OrderItemId = 5, OrderId = 4, MenuItemId = 9, Quantity = 4 },
                new OrderItem { OrderItemId = 6, OrderId = 5, MenuItemId = 2, Quantity = 1 },
                new OrderItem { OrderItemId = 7, OrderId = 5, MenuItemId = 3, Quantity = 3 },
                new OrderItem { OrderItemId = 8, OrderId = 7, MenuItemId = 1, Quantity = 5 },
                new OrderItem { OrderItemId = 9, OrderId = 8, MenuItemId = 5, Quantity = 3 }
            );
        }

    }
}

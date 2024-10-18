using RestaurantReservation.Db.DataModels;
using RestaurantReservation.Db;

//CreateExampleCustomer();

//Listmanagers();

//GetReservationsByCustomer();

//ListOrdersAndMenuItems();

//ListOrderedMenuItems();

CalculateAverageOrderAmount();

static void CalculateAverageOrderAmount()
{
    var dbContext = new RestaurantReservationDbContext();
    var orderService = new OrderServices(dbContext);

    Console.WriteLine($"Average order amount of employee with Id = 8 is: " +
        $"{orderService.CalculateAverageOrderAmount(8)}");
}

static void ListOrderedMenuItems()
{
    var dbContext = new RestaurantReservationDbContext();
    var orderItemService = new OrderItemServices(dbContext);
    var items = orderItemService.ListOrderedMenuItems(5);

    foreach ( var item in items)
    {
        Console.WriteLine($"{item.MenuItemId}. {item.Name}");
    }
}

static void ListOrdersAndMenuItems()
{
    var dbContext = new RestaurantReservationDbContext();
    var reservationService = new ReservationServices(dbContext);
    var orders = reservationService.ListOrdersAndMenuItems(5);

    foreach (var order in orders)
    {
        Console.WriteLine($"Order ID: {order.OrderId}, Total Amount: {order.TotalAmount}");

        foreach (var item in order.OrderItems)
        {
            Console.WriteLine($"Item: {item.MenuItem.Name}, Quantity: {item.Quantity}");
        }
    }
}

static void GetReservationsByCustomer()
{
    var dbContext = new RestaurantReservationDbContext();
    var customerService = new CustomerServices(dbContext);
    var reservations = customerService.GetReservationsByCustomer(1);

    foreach (var reservation in reservations)
    {
        Console.WriteLine($"{reservation.ReservationId}. {reservation.ReservationDate}\n" +
                          $"{reservation.Restaurant.Name}\n" +
                          $"Table: {reservation.TableId}\n"
                          );
    }
}

static void Listmanagers()
{
    var dbContext = new RestaurantReservationDbContext();
    var employeeService = new EmployeeServices(dbContext);
    var managers = employeeService.ListManagers();

    foreach (var manager in managers)
    {
        Console.WriteLine($"{manager.FirstName} {manager.LastName}");
    }
}
static void CreateExampleCustomer()
{
    var dbContext = new RestaurantReservationDbContext();
    var customerService = new CustomerServices(dbContext);
    customerService.CreateCustomer(new Customer
    {
        FirstName = "Jana",
        LastName = "Abusaa",
        Email = "jana@gmail.com",
        PhoneNumber = "0011223345"
    });
}

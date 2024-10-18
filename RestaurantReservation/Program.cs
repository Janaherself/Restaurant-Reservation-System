using RestaurantReservation.Db.DataModels;
using RestaurantReservation.Db;

//CreateExampleCustomer();

Listmanagers();

GetReservationsByCustomer();

ListOrdersAndMenuItems();

ListOrderedMenuItems();

CalculateAverageOrderAmount();

static void CalculateAverageOrderAmount()
{
    var dbContext = new RestaurantReservationDbContext();
    var orderService = new OrderServices(dbContext);

    Console.WriteLine($"Average order amount of employee with Id = 8 is: " +
        $"{orderService.CalculateAverageOrderAmount(8).Result}");
}

static void ListOrderedMenuItems()
{
    var dbContext = new RestaurantReservationDbContext();
    var orderItemService = new OrderItemServices(dbContext);
    var items = orderItemService.ListOrderedMenuItems(5);

    Console.WriteLine($"Ordered menu items for the reservation with Id = 5 is: \n");

    foreach ( var item in items.Result)
    {
        Console.WriteLine($"{item.MenuItemId}. {item.Name}");
    }
}

static void ListOrdersAndMenuItems()
{
    var dbContext = new RestaurantReservationDbContext();
    var reservationService = new ReservationServices(dbContext);
    var orders = reservationService.ListOrdersAndMenuItems(5);

    Console.WriteLine($"Orders and menu items for the reservation with Id = 5 is: ");

    foreach (var order in orders.Result)
    {
        Console.WriteLine($"\nOrder ID: {order.OrderId}, Total Amount: {order.TotalAmount}");

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
    var reservations = customerService.GetReservationsByCustomerAsync(1);

    Console.WriteLine($"Reservation of the customer with Id = 1 is: \n");

    foreach (var reservation in reservations.Result)
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

    foreach (var manager in managers.Result)
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

using RestaurantReservation.Db.DataModels;
using RestaurantReservation.Db.Repositories;

await CreateExampleCustomerAsync();

await ListmanagersAsync();

await GetReservationsByCustomerAsync();

await ListOrdersAndMenuItemsAsync();

await ListOrderedMenuItemsAsync();

await CalculateAverageOrderAmountAsync();

await GetReservationsByViewAsync();

await GetEmployeesByViewAsync();

await CalculateTotalRevenueAsync();

await GetCustomersWithPartySizeAsync();

static async Task GetCustomersWithPartySizeAsync()
{
    var customerService = new CustomerRepository();
    var customers = await customerService.GetCustomersWithPartySizeGreaterThanAsync(3, 2, 2);
    
    Console.WriteLine($"Customers with party size greater than 3 are: ");

    foreach (var customer in customers)
    {
        Console.WriteLine($"{customer.FirstName} {customer.LastName}");
    }
}

static async Task CalculateTotalRevenueAsync()
{
    var orderService = new OrderRepository();
    var totalRevenue = await orderService.CalculateTotalRevenueByRestaurantAsync(1);

    Console.WriteLine($"Total revenue for restaurant with Id = 1 is: {totalRevenue}$");
}

static async Task GetEmployeesByViewAsync()
{
    var employeeService = new EmployeeRepository();
    var employees = await employeeService.EmployeeViewAsync();

    foreach (var employee in employees)
    {
        Console.WriteLine($"{employee.EmployeeId}. {employee.FirstName} {employee.LastName}\n" +
                          $"{employee.Position} at {employee.RestaurantName}\n");
    }
}

static async Task GetReservationsByViewAsync()
{
    var reservationService = new ReservationRepository();
    var reservations = await reservationService.ReservationViewAsync();

    foreach (var reservation in reservations)
    {
        Console.WriteLine($"{reservation.ReservationId}. {reservation.FirstName} {reservation.LastName}\n" +
                          $"{reservation.RestaurantName}, {reservation.ReservationDate}\n");
    }
}

static async Task CalculateAverageOrderAmountAsync()
{
    var orderService = new OrderRepository();
    var averageOrderAmount = await orderService.CalculateAverageOrderAmountAsync(8);

    Console.WriteLine($"Average order amount of employee with Id = 8 is: " +
        $"{averageOrderAmount}");
}

static async Task ListOrderedMenuItemsAsync()
{
    var orderItemService = new OrderItemRepository();
    var items = await orderItemService.ListOrderedMenuItemsAsync(5);

    Console.WriteLine($"Ordered menu items for the reservation with Id = 5 is: \n");

    foreach ( var item in items)
    {
        Console.WriteLine($"{item.MenuItemId}. {item.Name}");
    }
}

static async Task ListOrdersAndMenuItemsAsync()
{
    var orderService = new OrderRepository();
    var orders = await orderService.ListOrdersAndMenuItemsAsync(5);

    Console.WriteLine($"Orders and menu items for the reservation with Id = 5 is: ");

    foreach (var order in orders)
    {
        Console.WriteLine($"\nOrder ID: {order.OrderId}, Total Amount: {order.TotalAmount}");

        foreach (var item in order.OrderItems)
        {
            Console.WriteLine($"Item: {item.MenuItem.Name}, Quantity: {item.Quantity}");
        }
    }
}

static async Task GetReservationsByCustomerAsync()
{
    var customerService = new ReservationRepository();
    var reservations = await customerService.GetReservationsByCustomerAsync(1);

    Console.WriteLine($"Reservation of the customer with Id = 1 is: \n");

    foreach (var reservation in reservations)
    {
        Console.WriteLine($"{reservation.ReservationId}. {reservation.ReservationDate}\n" +
                          $"{reservation.Restaurant.Name}\n" +
                          $"Table: {reservation.TableId}\n"
                          );
    }
}

static async Task ListmanagersAsync()
{
    var employeeService = new EmployeeRepository();
    var managers = await employeeService.ListManagersAsync();

    foreach (var manager in managers)
    {
        Console.WriteLine($"{manager.FirstName} {manager.LastName}");
    }
}
static async Task CreateExampleCustomerAsync()
{
    var customerService = new CustomerRepository();
    await customerService.CreateCustomerAsync(new Customer
    {
        FirstName = "Jana",
        LastName = "Abusaa",
        Email = "jana@gmail.com",
        PhoneNumber = "0011223345"
    });
}

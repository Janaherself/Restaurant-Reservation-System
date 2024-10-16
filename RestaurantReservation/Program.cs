using RestaurantReservation.Db.DataModels;
using RestaurantReservation.Db;

CreateExampleCustomer();

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

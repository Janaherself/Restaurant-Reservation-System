using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace RestaurantReservation.Db.Migrations
{
    /// <inheritdoc />
    public partial class SeedData : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "Email", "FirstName", "LastName", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "john.doe@example.com", "John", "Doe", "1234567890" },
                    { 2, "jane.smith@example.com", "Jane", "Smith", "2345678901" },
                    { 3, "alice.johnson@example.com", "Alice", "Johnson", "3456789012" },
                    { 4, "bob.brown@example.com", "Bob", "Brown", "4567890123" },
                    { 5, "emma.davis@example.com", "Emma", "Davis", "5678901234" }
                });

            migrationBuilder.InsertData(
                table: "Restaurants",
                columns: new[] { "RestaurantId", "Address", "Name", "OpeningHours", "PhoneNumber" },
                values: new object[,]
                {
                    { 1, "123 Sea Road", "Ocean Grill", "9:00 AM - 10:00 PM", "0987654321" },
                    { 2, "456 Mountain Drive", "Mountain View Cafe", "8:00 AM - 9:00 PM", "8765432109" },
                    { 3, "789 Sunset Blvd", "Sunset Bistro", "10:00 AM - 11:00 PM", "7654321098" },
                    { 4, "521 Mountain Hugo", "Sage & Salt", "11:00 AM - 12:00 AM", "8123892109" },
                    { 5, "473 St. Carlo Road", "Lord of the Fries", "11:00 AM - 11:00 PM", "8765447589" },
                    { 6, "496 5th Blvd", "Tres Gatos", "6:00 PM - 12:00 AM", "8362514013" }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "FirstName", "LastName", "Position", "RestaurantId" },
                values: new object[,]
                {
                    { 1, "Chris", "Evans", "Manager", 1 },
                    { 2, "Jessica", "Alba", "Chef", 2 },
                    { 3, "Paul", "Walker", "Waiter", 1 },
                    { 4, "Sophie", "Turner", "Manager", 3 },
                    { 5, "Tom", "Holland", "Waiter", 4 },
                    { 6, "Lexi", "Hensler", "Chef", 4 },
                    { 7, "Alan", "Walker", "Chef", 1 },
                    { 8, "Ben", "Azelart", "Manager", 5 },
                    { 9, "Andrew", "Davilla", "Waiter", 5 },
                    { 10, "Jeremy", "Hutchins", "Waiter", 6 }
                });

            migrationBuilder.InsertData(
                table: "MenuItem",
                columns: new[] { "MenuItemId", "Description", "Name", "Price", "RestaurantId" },
                values: new object[,]
                {
                    { 1, "Freshly grilled salmon with herbs", "Grilled Salmon", 15.99m, 1 },
                    { 2, "Classic Caesar salad with a twist", "Caesar Salad", 8.99m, 1 },
                    { 3, "Fluffy pancakes with maple syrup", "Pancake Stack", 7.50m, 2 },
                    { 4, "Juicy beef burger with cheese", "Beef Burger", 12.99m, 3 },
                    { 5, "Creamy pasta with Alfredo sauce", "Pasta Alfredo", 14.50m, 3 },
                    { 6, "Tender steak cooked to perfection", "Steak", 18.99m, 4 },
                    { 7, "Sweet and savory French toast", "French Toast", 10.99m, 4 },
                    { 8, "Omelette with fresh veggies", "Veggie Omelette", 7.99m, 4 },
                    { 9, "3 Mini burgers with fries", "Sliders", 13.99m, 4 }
                });

            migrationBuilder.InsertData(
                table: "Tables",
                columns: new[] { "TableId", "Capacity", "RestaurantId" },
                values: new object[,]
                {
                    { 1, 4, 1 },
                    { 2, 4, 1 },
                    { 3, 2, 2 },
                    { 4, 6, 3 },
                    { 5, 4, 3 },
                    { 6, 6, 4 },
                    { 7, 2, 5 },
                    { 8, 2, 5 },
                    { 9, 4, 5 },
                    { 10, 5, 5 },
                    { 11, 5, 6 },
                    { 12, 2, 6 },
                    { 13, 4, 6 }
                });

            migrationBuilder.InsertData(
                table: "Reservations",
                columns: new[] { "ReservationId", "CustomerId", "PartySize", "ReservationDate", "RestaurantId", "TableId" },
                values: new object[,]
                {
                    { 1, 1, 4, new DateTime(2024, 10, 16, 23, 1, 3, 798, DateTimeKind.Local).AddTicks(5128), 1, 1 },
                    { 2, 2, 2, new DateTime(2024, 10, 17, 23, 1, 3, 798, DateTimeKind.Local).AddTicks(5181), 2, 3 },
                    { 3, 3, 4, new DateTime(2024, 10, 18, 23, 1, 3, 798, DateTimeKind.Local).AddTicks(5186), 1, 2 },
                    { 4, 4, 4, new DateTime(2024, 10, 19, 23, 1, 3, 798, DateTimeKind.Local).AddTicks(5190), 3, 5 },
                    { 5, 5, 6, new DateTime(2024, 10, 20, 23, 1, 3, 798, DateTimeKind.Local).AddTicks(5194), 3, 4 },
                    { 6, 1, 3, new DateTime(2024, 10, 21, 23, 1, 3, 798, DateTimeKind.Local).AddTicks(5197), 6, 13 },
                    { 7, 3, 2, new DateTime(2024, 10, 22, 23, 1, 3, 798, DateTimeKind.Local).AddTicks(5201), 5, 7 }
                });

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "OrderId", "EmployeeId", "OrderDate", "ReservationId", "TotalAmount" },
                values: new object[,]
                {
                    { 1, 3, new DateTime(2024, 10, 15, 23, 1, 3, 798, DateTimeKind.Local).AddTicks(5237), 1, 10 },
                    { 2, 2, new DateTime(2024, 10, 15, 23, 1, 3, 798, DateTimeKind.Local).AddTicks(5242), 2, 5 },
                    { 3, 1, new DateTime(2024, 10, 15, 23, 1, 3, 798, DateTimeKind.Local).AddTicks(5245), 3, 7 },
                    { 4, 5, new DateTime(2024, 10, 15, 23, 1, 3, 798, DateTimeKind.Local).AddTicks(5248), 4, 9 },
                    { 5, 4, new DateTime(2024, 10, 15, 23, 1, 3, 798, DateTimeKind.Local).AddTicks(5250), 5, 4 },
                    { 6, 7, new DateTime(2024, 10, 15, 23, 1, 3, 798, DateTimeKind.Local).AddTicks(5253), 5, 21 },
                    { 7, 8, new DateTime(2024, 10, 15, 23, 1, 3, 798, DateTimeKind.Local).AddTicks(5256), 7, 5 },
                    { 8, 8, new DateTime(2024, 10, 15, 23, 1, 3, 798, DateTimeKind.Local).AddTicks(5259), 6, 3 }
                });

            migrationBuilder.InsertData(
                table: "Items",
                columns: new[] { "OrderItemId", "MenuItemId", "OrderId", "Quantity" },
                values: new object[,]
                {
                    { 1, 1, 1, 5 },
                    { 2, 2, 1, 4 },
                    { 3, 3, 2, 2 },
                    { 4, 1, 3, 3 },
                    { 5, 9, 4, 4 },
                    { 6, 2, 5, 1 },
                    { 7, 3, 5, 3 },
                    { 8, 1, 7, 5 },
                    { 9, 5, 8, 3 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "OrderItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "OrderItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "OrderItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "OrderItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "OrderItemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "OrderItemId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "OrderItemId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "OrderItemId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Items",
                keyColumn: "OrderItemId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "MenuItemId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "MenuItemId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "MenuItemId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "MenuItemId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "MenuItemId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "MenuItemId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "MenuItemId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "MenuItemId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "MenuItem",
                keyColumn: "MenuItemId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Employees",
                keyColumn: "EmployeeId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Customers",
                keyColumn: "CustomerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Tables",
                keyColumn: "TableId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Restaurants",
                keyColumn: "RestaurantId",
                keyValue: 6);
        }
    }
}

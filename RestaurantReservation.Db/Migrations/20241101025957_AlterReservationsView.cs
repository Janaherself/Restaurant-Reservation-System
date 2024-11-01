using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantReservation.Db.Migrations
{
    /// <inheritdoc />
    public partial class AlterReservationsView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                ALTER VIEW ReservationsView 
                AS
                SELECT r.ReservationId, r.ReservationDate,
                    c.CustomerId, c.FirstName AS CustomerFirstName, c.LastName AS CustomerLastName, c.PhoneNumber AS CustomerPhoneNumber,
                    rest.Name AS RestaurantName, rest.Address AS RestaurantAddress, rest.PhoneNumber AS RestaurantPhoneNumber, rest.OpeningHours
                FROM Reservations r
                JOIN Customers c ON r.CustomerId = c.CustomerId
                JOIN Restaurants rest ON r.RestaurantId = rest.RestaurantId;
                ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                ALTER VIEW ReservationsView 
                AS
                SELECT r.ReservationId, c.FirstName, c.LastName, rest.Name AS RestaurantName, r.ReservationDate
                FROM Reservations r
                JOIN Customers c ON r.CustomerId = c.CustomerId
                JOIN Restaurants rest ON r.RestaurantId = rest.RestaurantId;
                ");
        }
    }
}

using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantReservation.Db.Migrations
{
    /// <inheritdoc />
    public partial class AddReservationsView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE VIEW ReservationsView AS
                SELECT r.ReservationId, c.FirstName, c.LastName, rest.Name AS RestaurantName, r.ReservationDate
                FROM Reservations r
                JOIN Customers c ON r.CustomerId = c.CustomerId
                JOIN Restaurants rest ON r.RestaurantId = rest.RestaurantId;
                ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP VIEW ReservationsView");
        }
    }
}

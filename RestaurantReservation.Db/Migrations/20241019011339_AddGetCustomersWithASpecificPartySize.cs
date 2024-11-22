using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantReservation.Db.Migrations
{
    /// <inheritdoc />
    public partial class AddGetCustomersWithASpecificPartySize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE PROCEDURE GetCustomersWithPartySizeGreaterThan @PartySize INT
                AS
                BEGIN
                    SELECT c.*
                    FROM Customers c
                    JOIN Reservations r ON c.CustomerId = r.CustomerId
                    WHERE r.PartySize > @PartySize;
                END;
                ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP PROCEDURE GetCustomersWithLargePartySize");
        }
    }
}

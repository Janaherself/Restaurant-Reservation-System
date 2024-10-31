using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantReservation.Db.Migrations
{
    /// <inheritdoc />
    public partial class AddGetCountOfCustomerWithPartySizeGreaterThanProcedure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE PROCEDURE GetCountOfCustomerWithPartySizeGreaterThan
                    @PartySize INT
                AS
                BEGIN
                    SET NOCOUNT ON;

                    SELECT COUNT(*) AS TotalCount
                    FROM Reservations r
                    WHERE r.PartySize >= @PartySize;
                END;
                ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"DROP PROCEDURE GetCountOfCustomerWithPartySizeGreaterThan;");
        }
    }
}

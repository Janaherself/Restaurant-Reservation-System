using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantReservation.Db.Migrations
{
    /// <inheritdoc />
    public partial class AddPaginationToGetCustomersWithPartySizeGreaterThanProcedure : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                ALTER PROCEDURE GetCustomersWithPartySizeGreaterThan
                    @PartySize INT,
                    @PageNumber INT,
                    @PageSize INT
                AS
                BEGIN
                    SET NOCOUNT ON;

                    DECLARE @Offset INT = (@PageNumber - 1) * @PageSize;

                    SELECT c.CustomerId, c.FirstName, c.LastName, c.Email, c.PhoneNumber
                    FROM Customers c
	                JOIN Reservations r ON c.CustomerId = r.CustomerId
                    WHERE r.PartySize >= @PartySize
                    ORDER BY c.CustomerId
                    OFFSET @Offset ROWS
                    FETCH NEXT @PageSize ROWS ONLY;
                END;
                ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                ALTER PROCEDURE GetCustomersWithPartySizeGreaterThan
                    @PartySize INT
                AS
                BEGIN
		            SELECT c.*
		            FROM Customers c
		            JOIN Reservations r ON c.CustomerId = r.CustomerId
		            WHERE r.PartySize > @PartySize;
                END;
                ");
        }
    }
}

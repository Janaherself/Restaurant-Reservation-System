using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantReservation.Db.Migrations
{
    /// <inheritdoc />
    public partial class AlterPropertiesNamesInEmployeesView : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                ALTER VIEW EmployeesView 
                AS
                SELECT e.EmployeeId, e.FirstName AS EmployeeFirstName, e.LastName AS EmployeeLastName, e.Position AS EmployeePosition, 
                    r.Name AS RestaurantName, r.Address AS RestaurantAddress, r.OpeningHours, r.PhoneNumber AS RestaurantPhoneNumber
                FROM Employees e
                JOIN Restaurants r ON e.RestaurantId = r.RestaurantId;
                ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                ALTER VIEW EmployeesView 
                AS
                SELECT e.EmployeeId, e.FirstName, e.LastName, e.Position, 
                    r.Name AS RestaurantName, r.Address, r.OpeningHours, r.PhoneNumber
                FROM Employees e
                JOIN Restaurants r ON e.RestaurantId = r.RestaurantId;
                ");
        }
    }
}

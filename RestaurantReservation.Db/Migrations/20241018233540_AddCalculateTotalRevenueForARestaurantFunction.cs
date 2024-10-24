﻿using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantReservation.Db.Migrations
{
    /// <inheritdoc />
    public partial class AddCalculateTotalRevenueForARestaurantFunction : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
                CREATE FUNCTION dbo.CalculateTotalRevenue (@RestaurantId INT)
                RETURNS DECIMAL(18,2)
                AS
                BEGIN
                    DECLARE @TotalRevenue DECIMAL(20,2);
                    SELECT @TotalRevenue = SUM(o.TotalAmount)
                    FROM Orders o
                    JOIN Reservations r ON o.ReservationId = r.ReservationId
                    WHERE r.RestaurantId = @RestaurantId;
                    RETURN @TotalRevenue;
                END;
                ");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql("DROP FUNCTION IF EXISTS CalculateTotalRevenue");
        }
    }
}

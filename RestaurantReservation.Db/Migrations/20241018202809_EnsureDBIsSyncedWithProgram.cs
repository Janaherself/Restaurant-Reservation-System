using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantReservation.Db.Migrations
{
    /// <inheritdoc />
    public partial class EnsureDBIsSyncedWithProgram : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 10, 18, 23, 28, 9, 78, DateTimeKind.Local).AddTicks(3287));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 10, 18, 23, 28, 9, 78, DateTimeKind.Local).AddTicks(3291));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2024, 10, 18, 23, 28, 9, 78, DateTimeKind.Local).AddTicks(3294));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2024, 10, 18, 23, 28, 9, 78, DateTimeKind.Local).AddTicks(3322));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2024, 10, 18, 23, 28, 9, 78, DateTimeKind.Local).AddTicks(3324));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2024, 10, 18, 23, 28, 9, 78, DateTimeKind.Local).AddTicks(3327));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7,
                column: "OrderDate",
                value: new DateTime(2024, 10, 18, 23, 28, 9, 78, DateTimeKind.Local).AddTicks(3330));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8,
                column: "OrderDate",
                value: new DateTime(2024, 10, 18, 23, 28, 9, 78, DateTimeKind.Local).AddTicks(3333));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                column: "ReservationDate",
                value: new DateTime(2024, 10, 19, 23, 28, 9, 78, DateTimeKind.Local).AddTicks(3187));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                column: "ReservationDate",
                value: new DateTime(2024, 10, 20, 23, 28, 9, 78, DateTimeKind.Local).AddTicks(3236));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                column: "ReservationDate",
                value: new DateTime(2024, 10, 21, 23, 28, 9, 78, DateTimeKind.Local).AddTicks(3239));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 4,
                column: "ReservationDate",
                value: new DateTime(2024, 10, 22, 23, 28, 9, 78, DateTimeKind.Local).AddTicks(3243));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 5,
                column: "ReservationDate",
                value: new DateTime(2024, 10, 23, 23, 28, 9, 78, DateTimeKind.Local).AddTicks(3246));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 6,
                column: "ReservationDate",
                value: new DateTime(2024, 10, 24, 23, 28, 9, 78, DateTimeKind.Local).AddTicks(3249));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 7,
                column: "ReservationDate",
                value: new DateTime(2024, 10, 25, 23, 28, 9, 78, DateTimeKind.Local).AddTicks(3252));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 10, 17, 23, 15, 40, 47, DateTimeKind.Local).AddTicks(7076));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 10, 17, 23, 15, 40, 47, DateTimeKind.Local).AddTicks(7086));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2024, 10, 17, 23, 15, 40, 47, DateTimeKind.Local).AddTicks(7091));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2024, 10, 17, 23, 15, 40, 47, DateTimeKind.Local).AddTicks(7095));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2024, 10, 17, 23, 15, 40, 47, DateTimeKind.Local).AddTicks(7099));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2024, 10, 17, 23, 15, 40, 47, DateTimeKind.Local).AddTicks(7104));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7,
                column: "OrderDate",
                value: new DateTime(2024, 10, 17, 23, 15, 40, 47, DateTimeKind.Local).AddTicks(7108));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8,
                column: "OrderDate",
                value: new DateTime(2024, 10, 17, 23, 15, 40, 47, DateTimeKind.Local).AddTicks(7112));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                column: "ReservationDate",
                value: new DateTime(2024, 10, 18, 23, 15, 40, 47, DateTimeKind.Local).AddTicks(6934));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                column: "ReservationDate",
                value: new DateTime(2024, 10, 19, 23, 15, 40, 47, DateTimeKind.Local).AddTicks(6996));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                column: "ReservationDate",
                value: new DateTime(2024, 10, 20, 23, 15, 40, 47, DateTimeKind.Local).AddTicks(7001));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 4,
                column: "ReservationDate",
                value: new DateTime(2024, 10, 21, 23, 15, 40, 47, DateTimeKind.Local).AddTicks(7007));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 5,
                column: "ReservationDate",
                value: new DateTime(2024, 10, 22, 23, 15, 40, 47, DateTimeKind.Local).AddTicks(7011));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 6,
                column: "ReservationDate",
                value: new DateTime(2024, 10, 23, 23, 15, 40, 47, DateTimeKind.Local).AddTicks(7016));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 7,
                column: "ReservationDate",
                value: new DateTime(2024, 10, 24, 23, 15, 40, 47, DateTimeKind.Local).AddTicks(7020));
        }
    }
}

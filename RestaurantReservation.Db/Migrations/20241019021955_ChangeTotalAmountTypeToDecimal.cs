using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantReservation.Db.Migrations
{
    /// <inheritdoc />
    public partial class ChangeTotalAmountTypeToDecimal : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<decimal>(
                name: "TotalAmount",
                table: "Orders",
                type: "decimal(18,2)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                columns: new[] { "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 19, 5, 19, 54, 942, DateTimeKind.Local).AddTicks(9571), 10m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                columns: new[] { "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 19, 5, 19, 54, 942, DateTimeKind.Local).AddTicks(9577), 5m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                columns: new[] { "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 19, 5, 19, 54, 942, DateTimeKind.Local).AddTicks(9580), 7m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                columns: new[] { "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 19, 5, 19, 54, 942, DateTimeKind.Local).AddTicks(9583), 9m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                columns: new[] { "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 19, 5, 19, 54, 942, DateTimeKind.Local).AddTicks(9586), 4m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6,
                columns: new[] { "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 19, 5, 19, 54, 942, DateTimeKind.Local).AddTicks(9590), 21m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7,
                columns: new[] { "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 19, 5, 19, 54, 942, DateTimeKind.Local).AddTicks(9593), 5m });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8,
                columns: new[] { "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 19, 5, 19, 54, 942, DateTimeKind.Local).AddTicks(9597), 3m });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                column: "ReservationDate",
                value: new DateTime(2024, 10, 20, 5, 19, 54, 942, DateTimeKind.Local).AddTicks(9464));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                column: "ReservationDate",
                value: new DateTime(2024, 10, 21, 5, 19, 54, 942, DateTimeKind.Local).AddTicks(9516));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                column: "ReservationDate",
                value: new DateTime(2024, 10, 22, 5, 19, 54, 942, DateTimeKind.Local).AddTicks(9520));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 4,
                column: "ReservationDate",
                value: new DateTime(2024, 10, 23, 5, 19, 54, 942, DateTimeKind.Local).AddTicks(9523));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 5,
                column: "ReservationDate",
                value: new DateTime(2024, 10, 24, 5, 19, 54, 942, DateTimeKind.Local).AddTicks(9526));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 6,
                column: "ReservationDate",
                value: new DateTime(2024, 10, 25, 5, 19, 54, 942, DateTimeKind.Local).AddTicks(9530));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 7,
                column: "ReservationDate",
                value: new DateTime(2024, 10, 26, 5, 19, 54, 942, DateTimeKind.Local).AddTicks(9534));
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "TotalAmount",
                table: "Orders",
                type: "int",
                nullable: false,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                columns: new[] { "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 19, 4, 13, 38, 308, DateTimeKind.Local).AddTicks(6400), 10 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                columns: new[] { "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 19, 4, 13, 38, 308, DateTimeKind.Local).AddTicks(6411), 5 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                columns: new[] { "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 19, 4, 13, 38, 308, DateTimeKind.Local).AddTicks(6423), 7 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                columns: new[] { "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 19, 4, 13, 38, 308, DateTimeKind.Local).AddTicks(6433), 9 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                columns: new[] { "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 19, 4, 13, 38, 308, DateTimeKind.Local).AddTicks(6447), 4 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6,
                columns: new[] { "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 19, 4, 13, 38, 308, DateTimeKind.Local).AddTicks(6462), 21 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7,
                columns: new[] { "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 19, 4, 13, 38, 308, DateTimeKind.Local).AddTicks(6476), 5 });

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8,
                columns: new[] { "OrderDate", "TotalAmount" },
                values: new object[] { new DateTime(2024, 10, 19, 4, 13, 38, 308, DateTimeKind.Local).AddTicks(6488), 3 });

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                column: "ReservationDate",
                value: new DateTime(2024, 10, 20, 4, 13, 38, 308, DateTimeKind.Local).AddTicks(6164));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                column: "ReservationDate",
                value: new DateTime(2024, 10, 21, 4, 13, 38, 308, DateTimeKind.Local).AddTicks(6231));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                column: "ReservationDate",
                value: new DateTime(2024, 10, 22, 4, 13, 38, 308, DateTimeKind.Local).AddTicks(6247));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 4,
                column: "ReservationDate",
                value: new DateTime(2024, 10, 23, 4, 13, 38, 308, DateTimeKind.Local).AddTicks(6264));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 5,
                column: "ReservationDate",
                value: new DateTime(2024, 10, 24, 4, 13, 38, 308, DateTimeKind.Local).AddTicks(6272));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 6,
                column: "ReservationDate",
                value: new DateTime(2024, 10, 25, 4, 13, 38, 308, DateTimeKind.Local).AddTicks(6286));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 7,
                column: "ReservationDate",
                value: new DateTime(2024, 10, 26, 4, 13, 38, 308, DateTimeKind.Local).AddTicks(6299));
        }
    }
}

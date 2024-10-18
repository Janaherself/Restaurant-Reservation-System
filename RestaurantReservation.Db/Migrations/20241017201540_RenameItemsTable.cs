using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace RestaurantReservation.Db.Migrations
{
    /// <inheritdoc />
    public partial class RenameItemsTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Items_MenuItem_MenuItemId",
                table: "Items");

            migrationBuilder.DropForeignKey(
                name: "FK_Items_Orders_OrderId",
                table: "Items");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Items",
                table: "Items");

            migrationBuilder.RenameTable(
                name: "Items",
                newName: "OrderItems");

            migrationBuilder.RenameIndex(
                name: "IX_Items_OrderId",
                table: "OrderItems",
                newName: "IX_OrderItems_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_Items_MenuItemId",
                table: "OrderItems",
                newName: "IX_OrderItems_MenuItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems",
                column: "OrderItemId");

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

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_MenuItem_MenuItemId",
                table: "OrderItems",
                column: "MenuItemId",
                principalTable: "MenuItem",
                principalColumn: "MenuItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_MenuItem_MenuItemId",
                table: "OrderItems");

            migrationBuilder.DropForeignKey(
                name: "FK_OrderItems_Orders_OrderId",
                table: "OrderItems");

            migrationBuilder.DropPrimaryKey(
                name: "PK_OrderItems",
                table: "OrderItems");

            migrationBuilder.RenameTable(
                name: "OrderItems",
                newName: "Items");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_OrderId",
                table: "Items",
                newName: "IX_Items_OrderId");

            migrationBuilder.RenameIndex(
                name: "IX_OrderItems_MenuItemId",
                table: "Items",
                newName: "IX_Items_MenuItemId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Items",
                table: "Items",
                column: "OrderItemId");

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 1,
                column: "OrderDate",
                value: new DateTime(2024, 10, 15, 23, 1, 3, 798, DateTimeKind.Local).AddTicks(5237));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 2,
                column: "OrderDate",
                value: new DateTime(2024, 10, 15, 23, 1, 3, 798, DateTimeKind.Local).AddTicks(5242));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 3,
                column: "OrderDate",
                value: new DateTime(2024, 10, 15, 23, 1, 3, 798, DateTimeKind.Local).AddTicks(5245));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 4,
                column: "OrderDate",
                value: new DateTime(2024, 10, 15, 23, 1, 3, 798, DateTimeKind.Local).AddTicks(5248));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 5,
                column: "OrderDate",
                value: new DateTime(2024, 10, 15, 23, 1, 3, 798, DateTimeKind.Local).AddTicks(5250));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 6,
                column: "OrderDate",
                value: new DateTime(2024, 10, 15, 23, 1, 3, 798, DateTimeKind.Local).AddTicks(5253));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 7,
                column: "OrderDate",
                value: new DateTime(2024, 10, 15, 23, 1, 3, 798, DateTimeKind.Local).AddTicks(5256));

            migrationBuilder.UpdateData(
                table: "Orders",
                keyColumn: "OrderId",
                keyValue: 8,
                column: "OrderDate",
                value: new DateTime(2024, 10, 15, 23, 1, 3, 798, DateTimeKind.Local).AddTicks(5259));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 1,
                column: "ReservationDate",
                value: new DateTime(2024, 10, 16, 23, 1, 3, 798, DateTimeKind.Local).AddTicks(5128));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 2,
                column: "ReservationDate",
                value: new DateTime(2024, 10, 17, 23, 1, 3, 798, DateTimeKind.Local).AddTicks(5181));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 3,
                column: "ReservationDate",
                value: new DateTime(2024, 10, 18, 23, 1, 3, 798, DateTimeKind.Local).AddTicks(5186));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 4,
                column: "ReservationDate",
                value: new DateTime(2024, 10, 19, 23, 1, 3, 798, DateTimeKind.Local).AddTicks(5190));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 5,
                column: "ReservationDate",
                value: new DateTime(2024, 10, 20, 23, 1, 3, 798, DateTimeKind.Local).AddTicks(5194));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 6,
                column: "ReservationDate",
                value: new DateTime(2024, 10, 21, 23, 1, 3, 798, DateTimeKind.Local).AddTicks(5197));

            migrationBuilder.UpdateData(
                table: "Reservations",
                keyColumn: "ReservationId",
                keyValue: 7,
                column: "ReservationDate",
                value: new DateTime(2024, 10, 22, 23, 1, 3, 798, DateTimeKind.Local).AddTicks(5201));

            migrationBuilder.AddForeignKey(
                name: "FK_Items_MenuItem_MenuItemId",
                table: "Items",
                column: "MenuItemId",
                principalTable: "MenuItem",
                principalColumn: "MenuItemId");

            migrationBuilder.AddForeignKey(
                name: "FK_Items_Orders_OrderId",
                table: "Items",
                column: "OrderId",
                principalTable: "Orders",
                principalColumn: "OrderId");
        }
    }
}

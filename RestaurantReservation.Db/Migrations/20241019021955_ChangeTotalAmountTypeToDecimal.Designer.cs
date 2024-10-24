﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using RestaurantReservation.Db;

#nullable disable

namespace RestaurantReservation.Db.Migrations
{
    [DbContext(typeof(RestaurantReservationDbContext))]
    [Migration("20241019021955_ChangeTotalAmountTypeToDecimal")]
    partial class ChangeTotalAmountTypeToDecimal
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("RestaurantReservation.Db.DataModels.Customer", b =>
                {
                    b.Property<int>("CustomerId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CustomerId"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("CustomerId");

                    b.ToTable("Customers");

                    b.HasData(
                        new
                        {
                            CustomerId = 1,
                            Email = "john.doe@example.com",
                            FirstName = "John",
                            LastName = "Doe",
                            PhoneNumber = "1234567890"
                        },
                        new
                        {
                            CustomerId = 2,
                            Email = "jane.smith@example.com",
                            FirstName = "Jane",
                            LastName = "Smith",
                            PhoneNumber = "2345678901"
                        },
                        new
                        {
                            CustomerId = 3,
                            Email = "alice.johnson@example.com",
                            FirstName = "Alice",
                            LastName = "Johnson",
                            PhoneNumber = "3456789012"
                        },
                        new
                        {
                            CustomerId = 4,
                            Email = "bob.brown@example.com",
                            FirstName = "Bob",
                            LastName = "Brown",
                            PhoneNumber = "4567890123"
                        },
                        new
                        {
                            CustomerId = 5,
                            Email = "emma.davis@example.com",
                            FirstName = "Emma",
                            LastName = "Davis",
                            PhoneNumber = "5678901234"
                        });
                });

            modelBuilder.Entity("RestaurantReservation.Db.DataModels.Employee", b =>
                {
                    b.Property<int>("EmployeeId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("EmployeeId"));

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int?>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("EmployeeId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            EmployeeId = 1,
                            FirstName = "Chris",
                            LastName = "Evans",
                            Position = "Manager",
                            RestaurantId = 1
                        },
                        new
                        {
                            EmployeeId = 2,
                            FirstName = "Jessica",
                            LastName = "Alba",
                            Position = "Chef",
                            RestaurantId = 2
                        },
                        new
                        {
                            EmployeeId = 3,
                            FirstName = "Paul",
                            LastName = "Walker",
                            Position = "Waiter",
                            RestaurantId = 1
                        },
                        new
                        {
                            EmployeeId = 4,
                            FirstName = "Sophie",
                            LastName = "Turner",
                            Position = "Manager",
                            RestaurantId = 3
                        },
                        new
                        {
                            EmployeeId = 5,
                            FirstName = "Tom",
                            LastName = "Holland",
                            Position = "Waiter",
                            RestaurantId = 4
                        },
                        new
                        {
                            EmployeeId = 6,
                            FirstName = "Lexi",
                            LastName = "Hensler",
                            Position = "Chef",
                            RestaurantId = 4
                        },
                        new
                        {
                            EmployeeId = 7,
                            FirstName = "Alan",
                            LastName = "Walker",
                            Position = "Chef",
                            RestaurantId = 1
                        },
                        new
                        {
                            EmployeeId = 8,
                            FirstName = "Ben",
                            LastName = "Azelart",
                            Position = "Manager",
                            RestaurantId = 5
                        },
                        new
                        {
                            EmployeeId = 9,
                            FirstName = "Andrew",
                            LastName = "Davilla",
                            Position = "Waiter",
                            RestaurantId = 5
                        },
                        new
                        {
                            EmployeeId = 10,
                            FirstName = "Jeremy",
                            LastName = "Hutchins",
                            Position = "Waiter",
                            RestaurantId = 6
                        });
                });

            modelBuilder.Entity("RestaurantReservation.Db.DataModels.EmployeeView", b =>
                {
                    b.Property<int>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RestaurantName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable((string)null);

                    b.ToView("EmployeesView", (string)null);
                });

            modelBuilder.Entity("RestaurantReservation.Db.DataModels.MenuItem", b =>
                {
                    b.Property<int>("MenuItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("MenuItemId"));

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("MenuItemId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("MenuItem");

                    b.HasData(
                        new
                        {
                            MenuItemId = 1,
                            Description = "Freshly grilled salmon with herbs",
                            Name = "Grilled Salmon",
                            Price = 15.99m,
                            RestaurantId = 1
                        },
                        new
                        {
                            MenuItemId = 2,
                            Description = "Classic Caesar salad with a twist",
                            Name = "Caesar Salad",
                            Price = 8.99m,
                            RestaurantId = 1
                        },
                        new
                        {
                            MenuItemId = 3,
                            Description = "Fluffy pancakes with maple syrup",
                            Name = "Pancake Stack",
                            Price = 7.50m,
                            RestaurantId = 2
                        },
                        new
                        {
                            MenuItemId = 4,
                            Description = "Juicy beef burger with cheese",
                            Name = "Beef Burger",
                            Price = 12.99m,
                            RestaurantId = 3
                        },
                        new
                        {
                            MenuItemId = 5,
                            Description = "Creamy pasta with Alfredo sauce",
                            Name = "Pasta Alfredo",
                            Price = 14.50m,
                            RestaurantId = 3
                        },
                        new
                        {
                            MenuItemId = 6,
                            Description = "Tender steak cooked to perfection",
                            Name = "Steak",
                            Price = 18.99m,
                            RestaurantId = 4
                        },
                        new
                        {
                            MenuItemId = 7,
                            Description = "Sweet and savory French toast",
                            Name = "French Toast",
                            Price = 10.99m,
                            RestaurantId = 4
                        },
                        new
                        {
                            MenuItemId = 8,
                            Description = "Omelette with fresh veggies",
                            Name = "Veggie Omelette",
                            Price = 7.99m,
                            RestaurantId = 4
                        },
                        new
                        {
                            MenuItemId = 9,
                            Description = "3 Mini burgers with fries",
                            Name = "Sliders",
                            Price = 13.99m,
                            RestaurantId = 4
                        });
                });

            modelBuilder.Entity("RestaurantReservation.Db.DataModels.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderId"));

                    b.Property<int?>("EmployeeId")
                        .HasColumnType("int");

                    b.Property<DateTime>("OrderDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("ReservationId")
                        .HasColumnType("int");

                    b.Property<decimal>("TotalAmount")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("OrderId");

                    b.HasIndex("EmployeeId");

                    b.HasIndex("ReservationId");

                    b.ToTable("Orders");

                    b.HasData(
                        new
                        {
                            OrderId = 1,
                            EmployeeId = 3,
                            OrderDate = new DateTime(2024, 10, 19, 5, 19, 54, 942, DateTimeKind.Local).AddTicks(9571),
                            ReservationId = 1,
                            TotalAmount = 10m
                        },
                        new
                        {
                            OrderId = 2,
                            EmployeeId = 2,
                            OrderDate = new DateTime(2024, 10, 19, 5, 19, 54, 942, DateTimeKind.Local).AddTicks(9577),
                            ReservationId = 2,
                            TotalAmount = 5m
                        },
                        new
                        {
                            OrderId = 3,
                            EmployeeId = 1,
                            OrderDate = new DateTime(2024, 10, 19, 5, 19, 54, 942, DateTimeKind.Local).AddTicks(9580),
                            ReservationId = 3,
                            TotalAmount = 7m
                        },
                        new
                        {
                            OrderId = 4,
                            EmployeeId = 5,
                            OrderDate = new DateTime(2024, 10, 19, 5, 19, 54, 942, DateTimeKind.Local).AddTicks(9583),
                            ReservationId = 4,
                            TotalAmount = 9m
                        },
                        new
                        {
                            OrderId = 5,
                            EmployeeId = 4,
                            OrderDate = new DateTime(2024, 10, 19, 5, 19, 54, 942, DateTimeKind.Local).AddTicks(9586),
                            ReservationId = 5,
                            TotalAmount = 4m
                        },
                        new
                        {
                            OrderId = 6,
                            EmployeeId = 7,
                            OrderDate = new DateTime(2024, 10, 19, 5, 19, 54, 942, DateTimeKind.Local).AddTicks(9590),
                            ReservationId = 5,
                            TotalAmount = 21m
                        },
                        new
                        {
                            OrderId = 7,
                            EmployeeId = 8,
                            OrderDate = new DateTime(2024, 10, 19, 5, 19, 54, 942, DateTimeKind.Local).AddTicks(9593),
                            ReservationId = 7,
                            TotalAmount = 5m
                        },
                        new
                        {
                            OrderId = 8,
                            EmployeeId = 8,
                            OrderDate = new DateTime(2024, 10, 19, 5, 19, 54, 942, DateTimeKind.Local).AddTicks(9597),
                            ReservationId = 6,
                            TotalAmount = 3m
                        });
                });

            modelBuilder.Entity("RestaurantReservation.Db.DataModels.OrderItem", b =>
                {
                    b.Property<int>("OrderItemId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("OrderItemId"));

                    b.Property<int?>("MenuItemId")
                        .HasColumnType("int");

                    b.Property<int?>("OrderId")
                        .HasColumnType("int");

                    b.Property<int>("Quantity")
                        .HasColumnType("int");

                    b.HasKey("OrderItemId");

                    b.HasIndex("MenuItemId");

                    b.HasIndex("OrderId");

                    b.ToTable("OrderItems", (string)null);

                    b.HasData(
                        new
                        {
                            OrderItemId = 1,
                            MenuItemId = 1,
                            OrderId = 1,
                            Quantity = 5
                        },
                        new
                        {
                            OrderItemId = 2,
                            MenuItemId = 2,
                            OrderId = 1,
                            Quantity = 4
                        },
                        new
                        {
                            OrderItemId = 3,
                            MenuItemId = 3,
                            OrderId = 2,
                            Quantity = 2
                        },
                        new
                        {
                            OrderItemId = 4,
                            MenuItemId = 1,
                            OrderId = 3,
                            Quantity = 3
                        },
                        new
                        {
                            OrderItemId = 5,
                            MenuItemId = 9,
                            OrderId = 4,
                            Quantity = 4
                        },
                        new
                        {
                            OrderItemId = 6,
                            MenuItemId = 2,
                            OrderId = 5,
                            Quantity = 1
                        },
                        new
                        {
                            OrderItemId = 7,
                            MenuItemId = 3,
                            OrderId = 5,
                            Quantity = 3
                        },
                        new
                        {
                            OrderItemId = 8,
                            MenuItemId = 1,
                            OrderId = 7,
                            Quantity = 5
                        },
                        new
                        {
                            OrderItemId = 9,
                            MenuItemId = 5,
                            OrderId = 8,
                            Quantity = 3
                        });
                });

            modelBuilder.Entity("RestaurantReservation.Db.DataModels.Reservation", b =>
                {
                    b.Property<int>("ReservationId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ReservationId"));

                    b.Property<int?>("CustomerId")
                        .HasColumnType("int");

                    b.Property<int>("PartySize")
                        .HasColumnType("int");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("RestaurantId")
                        .HasColumnType("int");

                    b.Property<int?>("TableId")
                        .HasColumnType("int");

                    b.HasKey("ReservationId");

                    b.HasIndex("CustomerId");

                    b.HasIndex("RestaurantId");

                    b.HasIndex("TableId");

                    b.ToTable("Reservations");

                    b.HasData(
                        new
                        {
                            ReservationId = 1,
                            CustomerId = 1,
                            PartySize = 4,
                            ReservationDate = new DateTime(2024, 10, 20, 5, 19, 54, 942, DateTimeKind.Local).AddTicks(9464),
                            RestaurantId = 1,
                            TableId = 1
                        },
                        new
                        {
                            ReservationId = 2,
                            CustomerId = 2,
                            PartySize = 2,
                            ReservationDate = new DateTime(2024, 10, 21, 5, 19, 54, 942, DateTimeKind.Local).AddTicks(9516),
                            RestaurantId = 2,
                            TableId = 3
                        },
                        new
                        {
                            ReservationId = 3,
                            CustomerId = 3,
                            PartySize = 4,
                            ReservationDate = new DateTime(2024, 10, 22, 5, 19, 54, 942, DateTimeKind.Local).AddTicks(9520),
                            RestaurantId = 1,
                            TableId = 2
                        },
                        new
                        {
                            ReservationId = 4,
                            CustomerId = 4,
                            PartySize = 4,
                            ReservationDate = new DateTime(2024, 10, 23, 5, 19, 54, 942, DateTimeKind.Local).AddTicks(9523),
                            RestaurantId = 3,
                            TableId = 5
                        },
                        new
                        {
                            ReservationId = 5,
                            CustomerId = 5,
                            PartySize = 6,
                            ReservationDate = new DateTime(2024, 10, 24, 5, 19, 54, 942, DateTimeKind.Local).AddTicks(9526),
                            RestaurantId = 3,
                            TableId = 4
                        },
                        new
                        {
                            ReservationId = 6,
                            CustomerId = 1,
                            PartySize = 3,
                            ReservationDate = new DateTime(2024, 10, 25, 5, 19, 54, 942, DateTimeKind.Local).AddTicks(9530),
                            RestaurantId = 6,
                            TableId = 13
                        },
                        new
                        {
                            ReservationId = 7,
                            CustomerId = 3,
                            PartySize = 2,
                            ReservationDate = new DateTime(2024, 10, 26, 5, 19, 54, 942, DateTimeKind.Local).AddTicks(9534),
                            RestaurantId = 5,
                            TableId = 7
                        });
                });

            modelBuilder.Entity("RestaurantReservation.Db.DataModels.ReservationView", b =>
                {
                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("ReservationDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("ReservationId")
                        .HasColumnType("int");

                    b.Property<string>("RestaurantName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.ToTable((string)null);

                    b.ToView("ReservationsView", (string)null);
                });

            modelBuilder.Entity("RestaurantReservation.Db.DataModels.Restaurant", b =>
                {
                    b.Property<int>("RestaurantId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RestaurantId"));

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("OpeningHours")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("RestaurantId");

                    b.ToTable("Restaurants");

                    b.HasData(
                        new
                        {
                            RestaurantId = 1,
                            Address = "123 Sea Road",
                            Name = "Ocean Grill",
                            OpeningHours = "9:00 AM - 10:00 PM",
                            PhoneNumber = "0987654321"
                        },
                        new
                        {
                            RestaurantId = 2,
                            Address = "456 Mountain Drive",
                            Name = "Mountain View Cafe",
                            OpeningHours = "8:00 AM - 9:00 PM",
                            PhoneNumber = "8765432109"
                        },
                        new
                        {
                            RestaurantId = 3,
                            Address = "789 Sunset Blvd",
                            Name = "Sunset Bistro",
                            OpeningHours = "10:00 AM - 11:00 PM",
                            PhoneNumber = "7654321098"
                        },
                        new
                        {
                            RestaurantId = 4,
                            Address = "521 Mountain Hugo",
                            Name = "Sage & Salt",
                            OpeningHours = "11:00 AM - 12:00 AM",
                            PhoneNumber = "8123892109"
                        },
                        new
                        {
                            RestaurantId = 5,
                            Address = "473 St. Carlo Road",
                            Name = "Lord of the Fries",
                            OpeningHours = "11:00 AM - 11:00 PM",
                            PhoneNumber = "8765447589"
                        },
                        new
                        {
                            RestaurantId = 6,
                            Address = "496 5th Blvd",
                            Name = "Tres Gatos",
                            OpeningHours = "6:00 PM - 12:00 AM",
                            PhoneNumber = "8362514013"
                        });
                });

            modelBuilder.Entity("RestaurantReservation.Db.DataModels.Table", b =>
                {
                    b.Property<int>("TableId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("TableId"));

                    b.Property<int>("Capacity")
                        .HasColumnType("int");

                    b.Property<int?>("RestaurantId")
                        .HasColumnType("int");

                    b.HasKey("TableId");

                    b.HasIndex("RestaurantId");

                    b.ToTable("Tables");

                    b.HasData(
                        new
                        {
                            TableId = 1,
                            Capacity = 4,
                            RestaurantId = 1
                        },
                        new
                        {
                            TableId = 2,
                            Capacity = 4,
                            RestaurantId = 1
                        },
                        new
                        {
                            TableId = 3,
                            Capacity = 2,
                            RestaurantId = 2
                        },
                        new
                        {
                            TableId = 4,
                            Capacity = 6,
                            RestaurantId = 3
                        },
                        new
                        {
                            TableId = 5,
                            Capacity = 4,
                            RestaurantId = 3
                        },
                        new
                        {
                            TableId = 6,
                            Capacity = 6,
                            RestaurantId = 4
                        },
                        new
                        {
                            TableId = 7,
                            Capacity = 2,
                            RestaurantId = 5
                        },
                        new
                        {
                            TableId = 8,
                            Capacity = 2,
                            RestaurantId = 5
                        },
                        new
                        {
                            TableId = 9,
                            Capacity = 4,
                            RestaurantId = 5
                        },
                        new
                        {
                            TableId = 10,
                            Capacity = 5,
                            RestaurantId = 5
                        },
                        new
                        {
                            TableId = 11,
                            Capacity = 5,
                            RestaurantId = 6
                        },
                        new
                        {
                            TableId = 12,
                            Capacity = 2,
                            RestaurantId = 6
                        },
                        new
                        {
                            TableId = 13,
                            Capacity = 4,
                            RestaurantId = 6
                        });
                });

            modelBuilder.Entity("RestaurantReservation.Db.DataModels.Employee", b =>
                {
                    b.HasOne("RestaurantReservation.Db.DataModels.Restaurant", "Restaurant")
                        .WithMany("Employees")
                        .HasForeignKey("RestaurantId");

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("RestaurantReservation.Db.DataModels.MenuItem", b =>
                {
                    b.HasOne("RestaurantReservation.Db.DataModels.Restaurant", "Restaurant")
                        .WithMany("MenuItems")
                        .HasForeignKey("RestaurantId");

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("RestaurantReservation.Db.DataModels.Order", b =>
                {
                    b.HasOne("RestaurantReservation.Db.DataModels.Employee", "Employee")
                        .WithMany("Orders")
                        .HasForeignKey("EmployeeId");

                    b.HasOne("RestaurantReservation.Db.DataModels.Reservation", "Reservation")
                        .WithMany("Orders")
                        .HasForeignKey("ReservationId");

                    b.Navigation("Employee");

                    b.Navigation("Reservation");
                });

            modelBuilder.Entity("RestaurantReservation.Db.DataModels.OrderItem", b =>
                {
                    b.HasOne("RestaurantReservation.Db.DataModels.MenuItem", "MenuItem")
                        .WithMany("OrderItems")
                        .HasForeignKey("MenuItemId");

                    b.HasOne("RestaurantReservation.Db.DataModels.Order", "Order")
                        .WithMany("OrderItems")
                        .HasForeignKey("OrderId");

                    b.Navigation("MenuItem");

                    b.Navigation("Order");
                });

            modelBuilder.Entity("RestaurantReservation.Db.DataModels.Reservation", b =>
                {
                    b.HasOne("RestaurantReservation.Db.DataModels.Customer", "Customer")
                        .WithMany("Reservations")
                        .HasForeignKey("CustomerId");

                    b.HasOne("RestaurantReservation.Db.DataModels.Restaurant", "Restaurant")
                        .WithMany("Reservations")
                        .HasForeignKey("RestaurantId");

                    b.HasOne("RestaurantReservation.Db.DataModels.Table", "Table")
                        .WithMany("Reservations")
                        .HasForeignKey("TableId");

                    b.Navigation("Customer");

                    b.Navigation("Restaurant");

                    b.Navigation("Table");
                });

            modelBuilder.Entity("RestaurantReservation.Db.DataModels.Table", b =>
                {
                    b.HasOne("RestaurantReservation.Db.DataModels.Restaurant", "Restaurant")
                        .WithMany("Tables")
                        .HasForeignKey("RestaurantId");

                    b.Navigation("Restaurant");
                });

            modelBuilder.Entity("RestaurantReservation.Db.DataModels.Customer", b =>
                {
                    b.Navigation("Reservations");
                });

            modelBuilder.Entity("RestaurantReservation.Db.DataModels.Employee", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("RestaurantReservation.Db.DataModels.MenuItem", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("RestaurantReservation.Db.DataModels.Order", b =>
                {
                    b.Navigation("OrderItems");
                });

            modelBuilder.Entity("RestaurantReservation.Db.DataModels.Reservation", b =>
                {
                    b.Navigation("Orders");
                });

            modelBuilder.Entity("RestaurantReservation.Db.DataModels.Restaurant", b =>
                {
                    b.Navigation("Employees");

                    b.Navigation("MenuItems");

                    b.Navigation("Reservations");

                    b.Navigation("Tables");
                });

            modelBuilder.Entity("RestaurantReservation.Db.DataModels.Table", b =>
                {
                    b.Navigation("Reservations");
                });
#pragma warning restore 612, 618
        }
    }
}

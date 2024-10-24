﻿using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.DataModels;

namespace RestaurantReservation.Db.Repositories
{
    public class OrderRepository
    {
        private readonly RestaurantReservationDbContext _context;

        public OrderRepository(RestaurantReservationDbContext context)
        {
            _context = context;
        }

        public void CreateOrder(Order order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public void UpdateOrder(Order order)
        {
            var existingOrder = _context.Orders.Find(order.OrderId);
            if (existingOrder != null)
            {
                existingOrder.ReservationId = order.ReservationId;
                existingOrder.EmployeeId = order.EmployeeId;
                existingOrder.OrderDate = order.OrderDate;
                existingOrder.TotalAmount = order.TotalAmount;
                existingOrder.Reservation = order.Reservation;
                existingOrder.Employee = order.Employee;
                existingOrder.OrderItems = order.OrderItems;
                _context.SaveChanges();
            }
        }

        public void DeleteOrder(int OrderId)
        {
            var order = _context.Orders.Find(OrderId);
            if (order != null)
            {
                _context.Orders.Remove(order);
                _context.SaveChanges();
            }
        }

        public async Task<decimal> CalculateAverageOrderAmountAsync(int employeeId)
        {
            var orders = await _context.Orders
                                       .Where(o => o.EmployeeId == employeeId)
                                       .ToListAsync();

            return orders.Count != 0 ? orders.Average(o => o.TotalAmount) : 0;
        }

        public async Task<decimal> CalculateTotalRevenueByRestaurantAsync(int restaurantId)
        {
            return await _context.Database
                                 .SqlQuery<decimal>($"SELECT dbo.CalculateTotalRevenue({restaurantId}) AS Value")
                                 .SingleAsync();
        }

    }
}
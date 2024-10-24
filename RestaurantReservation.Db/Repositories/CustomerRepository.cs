﻿using Microsoft.EntityFrameworkCore;
using RestaurantReservation.Db.DataModels;

namespace RestaurantReservation.Db.Repositories
{
    public class CustomerRepository
    {
        private readonly RestaurantReservationDbContext _context;

        public CustomerRepository(RestaurantReservationDbContext context)
        {
            _context = context;
        }

        public void CreateCustomer(Customer customer)
        {
            _context.Customers.Add(customer);
            _context.SaveChanges();
        }

        public void UpdateCustomer(Customer customer)
        {
            var existingCustomer = _context.Customers.Find(customer.CustomerId);
            if (existingCustomer != null)
            {
                existingCustomer.FirstName = customer.FirstName;
                existingCustomer.LastName = customer.LastName;
                existingCustomer.Email = customer.Email;
                existingCustomer.PhoneNumber = customer.PhoneNumber;
                existingCustomer.Reservations = customer.Reservations;
                _context.SaveChanges();
            }
        }

        public void DeleteCustomer(int customerId)
        {
            var customer = _context.Customers.Find(customerId);
            if (customer != null)
            {
                _context.Customers.Remove(customer);
                _context.SaveChanges();
            }
        }

        public async Task<List<Reservation>> GetReservationsByCustomerAsync(int customerId)
        {
            return await _context.Reservations
                           .Include(c => c.Customer)
                           .Include(c => c.Restaurant)
                           .Where(c => c.CustomerId == customerId)
                           .ToListAsync();
        }

        public async Task<List<Customer>> GetCustomersWithPartySizeGreaterThanAsync(int partySize)
        {
            return await _context.Customers
                           .FromSqlInterpolated($"GetCustomersWithPartySizeGreaterThan {partySize}")
                           .ToListAsync();
        }
    }
}
﻿namespace RestaurantReservation.Db.DataModels
{
    public class Customer
    {
        public Customer()
        {
            Reservations = new List<Reservation>();    
        }

        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public List<Reservation> Reservations { get; set; }
    }
}

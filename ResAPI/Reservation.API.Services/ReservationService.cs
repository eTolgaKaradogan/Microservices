using Reservation.API.Infrastructure;
using Reservation.API.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.API.Services
{
    public class ReservationService : IReservationService
    {
        public ReservationDTO GetReservationByBookingNumber(int bookingNumber)
        {
            return new ReservationDTO()
            {
                Id = (new Random()).Next(100),
                BookingNumber = bookingNumber,
                Amount = (new Random().Next(10000)),
                BookingDate = DateTime.Now,
                CheckinDate = DateTime.Now.Date.AddDays(30),
                CheckOutDate = DateTime.Now.Date.AddDays(37)
            };
        }
    }
}

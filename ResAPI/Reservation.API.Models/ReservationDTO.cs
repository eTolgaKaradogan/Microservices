using System;
using System.Collections.Generic;
using System.Text;

namespace Reservation.API.Models
{
    public class ReservationDTO
    {
        public int Id { get; set; }
        public int BookingNumber { get; set; }
        public DateTime? CheckinDate { get; set; }
        public DateTime? CheckOutDate { get; set; }
        public DateTime? BookingDate { get; set; }
        public double Amount { get; set; }
    }
}

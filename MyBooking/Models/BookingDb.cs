using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MyBooking.Models
{
    public class BookingDb : DbContext
    {
        public DbSet<BookingModel> Bookings { get; set; }
    }
}
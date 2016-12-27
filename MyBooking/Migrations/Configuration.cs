using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;
using MyBooking.Models;

namespace MyBooking.Migrations
{
    internal sealed class Configuration : DbMigrationsConfiguration<BookingDb>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(BookingDb context)
        {
            context.Bookings.AddOrUpdate(
                b => b.BookingId,
                    new BookingModel { BookingId = 1, CustomerName = "Frank Warren", StaffId = 1, BookingDateTime = new DateTime(2016, 10, 2) },
                    new BookingModel { BookingId = 2, CustomerName = "William Hill", StaffId = 1, BookingDateTime = new DateTime(2016, 10, 2) },
                    new BookingModel { BookingId = 3, CustomerName = "Arnold Palmer", StaffId = 2, BookingDateTime = new DateTime(2016, 10, 4) }
            );

            context.SaveChanges();
        }
    }
}
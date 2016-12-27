using MyBooking.DataAccess;
using MyBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBooking.Controllers
{
    public class BookingsController : Controller
    {
        private IStaffRepository staffRepo;
        private BookingDb _db = new BookingDb();


        public BookingsController()
        {
            staffRepo = new StaffRepository();
        }

        public ActionResult Index()
        {
            List<BookingModel> bookings = _db.Bookings.ToList();

            return View(bookings);
        }

        public ActionResult Create()
        {
            IEnumerable<Staff> staff = staffRepo.GetStaff();

            BookingModel model = new BookingModel();
            //model.Staff = staff.ToList();
            model.BookingDateTime = DateTime.UtcNow;

            return View(model);
        }

        [HttpPost]
        public ActionResult Create(BookingModel booking)
        {
            if (ModelState.IsValid)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View(booking);
            }
            
        }

        private List<BookingModel> getBookings()
        {
            List<BookingModel> bookings = new List<BookingModel>()
            {
                new BookingModel() {
                    CustomerName = "James West",
                    StaffId = 1,
                    BookingDateTime = new DateTime(2016, 04, 28)
                }
            };

            return bookings;
        }

        protected override void Dispose(bool disposing)
        {
            if (_db != null)
            {
                _db.Dispose();
            }
            
            base.Dispose(disposing);
        }

    }
}

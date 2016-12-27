using MyBooking.DataAccess;
using MyBooking.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MyBooking.Controllers
{
    public class StaffController : Controller
    {
        private IStaffRepository staffRepo;

        public StaffController()
        {
            this.staffRepo = new StaffRepository();
        }

        public ActionResult Index()
        {
            IEnumerable<Staff> staffList = staffRepo.GetStaff();
            var model = this.mapStaff(staffList);

            return View(model);
        }

        private IList<StaffModel> mapStaff(IEnumerable<Staff> staffList)
        {
            List<StaffModel> modelList = new List<StaffModel>();
            foreach(var staff in staffList) {
                StaffModel model = new StaffModel()
                {
                    StaffId = staff.StaffId,
                    Name = staff.Name
                };

                modelList.Add(model);
            }

            return modelList;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBooking.DataAccess
{
    public interface IStaffRepository : IDisposable
    {
        IEnumerable<Staff> GetStaff();
        Staff GetStaffByID(int studentId);
        void InsertStaff(Staff student);
        void DeleteStaff(int studentID);
        void UpdateStaff(Staff student);
        void Save();
    }
}
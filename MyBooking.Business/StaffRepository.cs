using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyBooking.DataAccess
{
    public class StaffRepository : IStaffRepository, IDisposable
    {
        public IEnumerable<Staff> GetStaff()
        {
            List<Staff> staff = new List<Staff>
            {
                new Staff() {
                    Name = "Buck Rogers",
                    StaffId = 1
                },
                new Staff() {
                    Name = "Rachel Wilson",
                    StaffId = 2
                },
                new Staff() {
                    Name = "Richard Prior",
                    StaffId = 3
                }
            };

            return staff;
        }

        public Staff GetStaffByID(int studentId)
        {
            throw new NotImplementedException();
        }

        public void InsertStaff(Staff student)
        {
            throw new NotImplementedException();
        }

        public void DeleteStaff(int studentID)
        {
            throw new NotImplementedException();
        }

        public void UpdateStaff(Staff student)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}

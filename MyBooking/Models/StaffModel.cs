using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;

namespace MyBooking.Models
{
    public class StaffModel
    {
        public int StaffId { get; set; }

        [DisplayName("Staff")]
        public string Name { get; set; }
    }
}

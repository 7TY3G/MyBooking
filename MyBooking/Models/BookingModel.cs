using MyBooking.DataAccess;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MyBooking.Models
{
    public class BookingModel
    {
        [Key]
        public int BookingId { get; set; }
        public string CustomerName { get; set; }
        public int StaffId { get; set; }
        [DisplayName("Date")]
        [DataType(DataType.Date)]
        public DateTime BookingDateTime { get; set; }
    }
}
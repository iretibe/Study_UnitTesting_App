using Study_UnitTesting_App.Models.Model.VM;
using System.ComponentModel.DataAnnotations;

namespace Study_UnitTesting_App.Models.Model
{
    public class StudyRoomBooking : StudyRoomBookingBase
    {
        [Key]
        public int BookingId { get; set; }
        public int StudyRoomId { get; set; }
    }
}

using Study_UnitTesting_App.Models.ModelValidations;
using System.ComponentModel.DataAnnotations;

namespace Study_UnitTesting_App.Models.Model.VM
{
    public class StudyRoomBookingBase
    {
        [Required]
        [StringLength(50)]
        public string FirstName { get; set; }

        [Required]
        [StringLength(50)]
        public string LastName { get; set; }

        [Required]
        [StringLength(100)]
        [EmailAddress]
        public string Email { get; set; }

        [DataType(DataType.Date)]
        [DateInFuture]
        public DateTime Date { get; set; }

        
    }
}

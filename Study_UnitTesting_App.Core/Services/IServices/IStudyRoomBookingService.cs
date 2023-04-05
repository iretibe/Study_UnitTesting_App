using Study_UnitTesting_App.Models.Model;
using Study_UnitTesting_App.Models.Model.VM;

namespace Study_UnitTesting_App.Core.Services.IServices
{
    public interface IStudyRoomBookingService
    {
        StudyRoomBookingResult BookStudyRoom(StudyRoomBooking request);
        IEnumerable<StudyRoomBooking> GetAllBooking();
    }
}

using Study_UnitTesting_App.Models.Model;

namespace Study_UnitTesting_App.DataAccess.Repository.IRepository
{
    public interface IStudyRoomBookingRepository
    {
        void Book(StudyRoomBooking booking);
        IEnumerable<StudyRoomBooking> GetAll(DateTime? dateTime);
        
    }
}

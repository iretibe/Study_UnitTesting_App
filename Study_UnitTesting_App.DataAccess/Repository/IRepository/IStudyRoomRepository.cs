using Study_UnitTesting_App.Models.Model;

namespace Study_UnitTesting_App.DataAccess.Repository.IRepository
{
    public interface IStudyRoomRepository
    {
        IEnumerable<StudyRoom> GetAll();
    }
}

using Study_UnitTesting_App.Models.Model;

namespace Study_UnitTesting_App.Core.Services.IServices
{
    public interface IStudyRoomService
    {
        IEnumerable<StudyRoom> GetAll();
    }
}

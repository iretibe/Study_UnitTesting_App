using Study_UnitTesting_App.Core.Services.IServices;
using Study_UnitTesting_App.DataAccess.Repository.IRepository;
using Study_UnitTesting_App.Models.Model;

namespace Study_UnitTesting_App.Core.Services
{
    public class StudyRoomService : IStudyRoomService
    {
        private readonly IStudyRoomRepository _studyRoomRepository;
        public StudyRoomService(IStudyRoomRepository studyRoomRepository)
        {
            _studyRoomRepository = studyRoomRepository;
        }

        public IEnumerable<StudyRoom> GetAll()
        {
            return _studyRoomRepository.GetAll();
        }
    }
}

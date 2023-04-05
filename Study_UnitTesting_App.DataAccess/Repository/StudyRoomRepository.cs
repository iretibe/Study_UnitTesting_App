using Study_UnitTesting_App.DataAccess.Repository.IRepository;
using Study_UnitTesting_App.Models.Model;

namespace Study_UnitTesting_App.DataAccess.Repository
{
    public class StudyRoomRepository : IStudyRoomRepository
    {
        private readonly ApplicationDbContext _db;
        public StudyRoomRepository(ApplicationDbContext db)
        {
            _db = db;
        }
      
    
        public IEnumerable<StudyRoom> GetAll()
        {
            return  _db.StudyRooms.ToList();
        }


    }
}

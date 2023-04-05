using Study_UnitTesting_App.Core.Services.IServices;
using Study_UnitTesting_App.DataAccess.Repository.IRepository;
using Study_UnitTesting_App.Models.Model;
using Study_UnitTesting_App.Models.Model.VM;

namespace Study_UnitTesting_App.Core.Services
{
    public class StudyRoomBookingService : IStudyRoomBookingService
    {
        private readonly IStudyRoomBookingRepository _studyRoomBookingRepository;
        private readonly IStudyRoomRepository _studyRoomRepository;

        public StudyRoomBookingService(IStudyRoomBookingRepository studyRoomBookingRepository,
          IStudyRoomRepository studyRoomRepository)
        {
            _studyRoomRepository = studyRoomRepository;
            _studyRoomBookingRepository = studyRoomBookingRepository;
        }

        public StudyRoomBookingResult BookStudyRoom(StudyRoomBooking request)
        {
            if (request == null)
            {
                throw new ArgumentNullException(nameof(request));
            }

            StudyRoomBookingResult result = new() {
                FirstName = request.FirstName,
                LastName = request.LastName,
                Email = request.Email,
                Date = request.Date
            };

            IEnumerable<int> bookedRooms = _studyRoomBookingRepository.GetAll(request.Date).Select(u=>u.StudyRoomId);
            IEnumerable<StudyRoom> availableRooms = _studyRoomRepository.GetAll().Where(u => !bookedRooms.Contains(u.Id));
            if (availableRooms.Any())
            {
                StudyRoomBooking studyRoomBooking = new()
                {
                    FirstName = request.FirstName,
                    LastName = request.LastName,
                    Email = request.Email,
                    Date = request.Date
                };
                studyRoomBooking.StudyRoomId = availableRooms.FirstOrDefault().Id;
                _studyRoomBookingRepository.Book(studyRoomBooking);
                result.BookingId = studyRoomBooking.BookingId;
                result.Code = StudyRoomBookingCode.Success;
            }
            else
            {
                result.Code = StudyRoomBookingCode.NoRoomAvailable;
            }

            return result;
        }

        public IEnumerable<StudyRoomBooking> GetAllBooking()
        {
            return _studyRoomBookingRepository.GetAll(null);
        }

    
    }

}

using Study_UnitTesting_App.Core.Services.IServices;
using Microsoft.AspNetCore.Mvc;

namespace Study_UnitTesting_App.Web.Controllers
{
    public class RoomsController : Controller
    {
        private readonly IStudyRoomService _studyRoomService;

        public RoomsController(IStudyRoomService studyRoomService)
        {
            _studyRoomService = studyRoomService;
        }

        public IActionResult Index()
        {
            return View(_studyRoomService.GetAll());
        }       
    }
}

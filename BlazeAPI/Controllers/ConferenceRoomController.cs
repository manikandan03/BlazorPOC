using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BlazeAPI.IRepository;
using BlazeShared;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BlazeAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ConferenceRoomController : ControllerBase
    {
        private readonly IUnitOfWork _unitOfWork;
        public ConferenceRoomController(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        [HttpGet("ConferenceRoomDetails")]
        public IActionResult GetConferenceRoomDetails()
        {
            var userFromRepo = _unitOfWork.ConferenceDetails.GetConferenceRooms();
            return Ok(userFromRepo);
        }
        [HttpGet("GetAllConferences")]
        public IActionResult GetAllConferences()
        {
            var conferencesFromRepo = _unitOfWork.ConferenceDetails.GetAllConferences();
            return Ok(conferencesFromRepo);
        }

        [HttpGet("ConferenceRoomByDate")]
        public IActionResult GetConferenceByDate(DateTime dateTime)
        {
            var userFromRepo = _unitOfWork.ConferenceDetails.GetConferenceRoomsByDate(dateTime);
            return Ok(userFromRepo);
        }
        [HttpGet("GetDepartments")]
        public IActionResult GetDepartments()
        {
            var deptromRepo = _unitOfWork.ConferenceDetails.GetDepartments();
            return Ok(deptromRepo);
        }
        [HttpGet("GetPurpose")]
        public IActionResult GetPurpose()
        {
            var purposeFromRepo = _unitOfWork.ConferenceDetails.GetPurpose();
            return Ok(purposeFromRepo);
        }
        [HttpGet("GetUsers")]
        public IActionResult GetUsers()
        {
            var userFromRepo = _unitOfWork.ConferenceDetails.GetUsers();
            return Ok(userFromRepo);
        }
        [HttpGet("GetProjects")]
        public IActionResult GetProjects()
        {
            var projFromRepo = _unitOfWork.ConferenceDetails.GetProjects();
            return Ok(projFromRepo);
        }
        [HttpPost("AddConferenceBooking")]
        public IActionResult AddConferenceBooking(ConferenceRoomBooking conferenceRoomBooking)
        {
            var projFromRepo = _unitOfWork.ConferenceDetails.AddConferenceBooking(conferenceRoomBooking);
            return Created("booking", projFromRepo);
        }

        [HttpGet("UpdateConferenceBooking")]
        public IActionResult UpdateConferenceBooking(int conferenceId)
        {
            _unitOfWork.ConferenceDetails.UpdateConferenceBooking(conferenceId);
            return NoContent();
        }

        [HttpGet("UpdateConferenceToComplete")]
        public IActionResult UpdateConferenceToComplete(int conferenceId)
        {
            _unitOfWork.ConferenceDetails.UpdateConferenceBookingToComplte(conferenceId);
            return NoContent();
        }
    }
}
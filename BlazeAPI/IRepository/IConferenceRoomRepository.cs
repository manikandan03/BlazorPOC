using BlazeAPI.Context;
using BlazeShared;
using System;
using System.Collections.Generic;

namespace BlazeAPI.IRepository
{
    public interface IConferenceRoomRepository  : IRepository<ConferenceRoom>
    {
        ConferenceRoomModel GetConferenceRooms();
        IEnumerable<ConferenceDetail> GetConferenceRoomsByDate(DateTime dateTime);
        IEnumerable<DepartmentModel> GetDepartments();
        IEnumerable<PurposeModel> GetPurpose();
        IEnumerable<UserModel> GetUsers();
        IEnumerable<ProjectModel> GetProjects();
        ConferenceRoom AddConferenceBooking(ConferenceRoomBooking conferenceRoomBooking);
        void UpdateConferenceBooking(int conferenceId);
        void UpdateConferenceBookingToComplte(int conferenceId);
        List<ConferenceDetail> GetAllConferences();




    }
}

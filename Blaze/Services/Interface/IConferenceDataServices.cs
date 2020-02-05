using Blaze.Shared;
using BlazeShared;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blaze.Services.Interface
{
    public interface IConferenceDataServices
    {
        Task<ConferenceRoomModel> GetAllConference();
        Task<IEnumerable<ConferenceDetail>> GetAllConferences();
        Task<IEnumerable<ConferenceDetail>> ConferenceRoomByDate(DateTime dateTime);
        Task<IEnumerable<DepartmentModel>> GetDepartments();
        Task<IEnumerable<PurposeModel>> GetPurpose();
        Task<IEnumerable<UserModel>> GetUsers();
        Task<IEnumerable<ProjectModel>> GetProjects();
        Task<ConferenceRoomBooking> AddConferenceRoomBooking( ConferenceRoomBooking conferenceRoomBooking);
        Task UpdateConference(int conferenceId);
        Task UpdateConferenceToComplete(int conferenceId);
        //Task<UserModel> GetUserIdBasedOnEmpID(int empId);
    }
}

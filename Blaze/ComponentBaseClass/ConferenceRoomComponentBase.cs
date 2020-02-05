using Blaze.Services.Interface;
using BlazeShared;
using Microsoft.AspNetCore.Components;
using System;
using System.Linq;
using System.Threading.Tasks;

namespace Blaze.ComponentBaseClass
{
    public class ConferenceRoomComponentBase :ComponentBase
    {

        #region Services
        [Inject]
        public IConferenceDataServices ConferenceDataServices { get; set; }
        #endregion

        #region Properties
        public ConferenceRoomModel conferenceRoomModel { get; set; } = new ConferenceRoomModel();
        #endregion

        #region Fields
        protected string VacantTimeSpan = string.Empty;
        #endregion

        #region LifeCycleMethods
        protected override async Task OnInitializedAsync()
        {
           conferenceRoomModel = await ConferenceDataServices.GetAllConference();
            GetVacantTime();
        }
        #endregion
        public void GetVacantTime()
        {
            if(conferenceRoomModel.ConferenceDetail.Count>0)
            {
                var getNextConference = conferenceRoomModel.ConferenceDetail.Where(x => x.BookForm > DateTime.Now).OrderBy(x => x.BookForm).ToList();
                var getNextBookingTime =Convert.ToDateTime( getNextConference.FirstOrDefault().BookForm);
                var startTime = DateTime.Now.ToString("hh:mm tt");
                var endTime = getNextBookingTime.ToString("hh:mm tt");
                VacantTimeSpan = "Available till " + startTime + "-" + endTime;
            }
            else
            {
                VacantTimeSpan = "No Bookings are available for Today";
            }
            
        }
    }
}

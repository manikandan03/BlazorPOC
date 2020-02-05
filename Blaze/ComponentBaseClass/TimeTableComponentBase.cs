using Blaze.Services.Interface;
using BlazeShared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blaze.ComponentBaseClass
{
    public class TimeTableComponentBase : ComponentBase
    {
        #region Services
        [Inject]
        public IConferenceDataServices ConferenceDataServices { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        #endregion

        #region Properties
        public List<ConferenceDetail> conferenceRoomModelByDate { get; set; } = new List<ConferenceDetail>();

        public DateTime DatePickerValue { get; set; }

        #endregion

        #region Fields

        public string duration = string.Empty;
        #endregion

        #region LifeCycleMethods

        protected override async Task OnInitializedAsync()
        {
           await SearchConferenceByDate(DateTime.Now);
            DatePickerValue = DateTime.Now;
        }
        #endregion

        public async Task SearchConferenceByDate(DateTime dateTime)
        {
            conferenceRoomModelByDate = (await ConferenceDataServices.ConferenceRoomByDate(dateTime)).ToList();
        }
        public async Task SearchConfernce()
        {
            var dateValue = DatePickerValue;
            await SearchConferenceByDate(dateValue.Date);
        }
        protected void NavigateNewBookingComponent()
        {
            NavigationManager.NavigateTo("/addConferenceBooking");
        }
        protected void Temp()
        {
            NavigationManager.NavigateTo("/Temp");
        }
        protected void EditBooking(ConferenceDetail conferenceDetail)
        {
            NavigationManager.NavigateTo("/addConferenceBooking");
        }

    }
}

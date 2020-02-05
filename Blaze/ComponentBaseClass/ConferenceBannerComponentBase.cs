using BlazeShared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Blaze.ComponentBaseClass
{
    public class ConferenceBannerComponentBase :ComponentBase
    {
        #region Parameters

        [Parameter]
        public ConferenceRoomModel ConferenceRoomModel { get; set; }

        [Parameter]
        public string VacantTimeSpan { get; set; }

        [Parameter]
        public string Active { get; set; }

        [Parameter]
        public string Floor { get; set; }

        #endregion

        #region Field
        protected ConferenceRoomModel conferenceRoomModel  = new ConferenceRoomModel();
        protected string vacantTimeSpan = string.Empty;
        protected string active = string.Empty;
        protected string floor = string.Empty;

        #endregion

        #region LifeCycleMethod
        protected override void OnParametersSet()
        {
            conferenceRoomModel = ConferenceRoomModel;
            vacantTimeSpan = VacantTimeSpan;
            active = Active;
            floor = Floor;
        }
        #endregion

    }
}

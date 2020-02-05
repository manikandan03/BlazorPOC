using BlazeShared;
using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace Blaze.ComponentBaseClass
{
    public class BookingTileComponentBase:ComponentBase
    {
        #region Services

        #endregion

        #region Properties
        [Parameter]
        public ConferenceDetail conferenceDetail { get; set; }
        #endregion

        #region Fields
        protected ConferenceDetail item = new ConferenceDetail();
        #endregion

        #region LifeCycleMethods
        protected override void OnParametersSet()
        {
            StateHasChanged();
            item = conferenceDetail;
        }
        #endregion
    }
}

using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class ConferenceBookings
    {
        public int ConferenceId { get; set; }
        public int FkFloorId { get; set; }
        public string StartTime { get; set; }
        public string EndTime { get; set; }
        public string FkDepartmentId { get; set; }
        public string Description { get; set; }
        public DateTime BookingDate { get; set; }
        public int FkUserId { get; set; }
        public bool? IsActive { get; set; }
        public string Attendees { get; set; }
        public int? NoOfAttendees { get; set; }
        public int? PurposeId { get; set; }
        public int? ProjectNameId { get; set; }
        public bool? IsNotAvailable { get; set; }
        public bool? IsBooked { get; set; }

        public virtual MasterFloor FkFloor { get; set; }
        public virtual Users FkUser { get; set; }
    }
}

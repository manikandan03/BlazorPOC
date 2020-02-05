using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MettingSchedule
    {
        public int Id { get; set; }
        public int? Week { get; set; }
        public string Day { get; set; }
        public int? ProjectId { get; set; }
        public string TimeSlot { get; set; }
        public string Attendees { get; set; }
        public string EndTime { get; set; }

        public virtual Projects Project { get; set; }
    }
}

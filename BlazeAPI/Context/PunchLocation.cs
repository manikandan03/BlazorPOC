using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class PunchLocation
    {
        public PunchLocation()
        {
            TimeLogDetail = new HashSet<TimeLogDetail>();
        }

        public int PunchLocationId { get; set; }
        public string FloorName { get; set; }

        public virtual ICollection<TimeLogDetail> TimeLogDetail { get; set; }
    }
}

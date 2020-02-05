using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class TimeLogDetail
    {
        public Guid TimeLogDetailId { get; set; }
        public Guid TimeLogId { get; set; }
        public DateTime Date { get; set; }
        public string InTime { get; set; }
        public string OutTime { get; set; }
        public int? TotalTime { get; set; }
        public int PunchLocationId { get; set; }

        public virtual PunchLocation PunchLocation { get; set; }
        public virtual TimeLog TimeLog { get; set; }
    }
}

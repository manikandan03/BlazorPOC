using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class TimeLog
    {
        public TimeLog()
        {
            TimeLogDetail = new HashSet<TimeLogDetail>();
        }

        public Guid TimeLogId { get; set; }
        public string EmployeeId { get; set; }
        public string InTime { get; set; }
        public string OutTime { get; set; }
        public int? InTimeMin { get; set; }
        public int? OutTimeMin { get; set; }
        public DateTime Date { get; set; }
        public int? TotalTime { get; set; }
        public int? BranchId { get; set; }

        public virtual ICollection<TimeLogDetail> TimeLogDetail { get; set; }
    }
}

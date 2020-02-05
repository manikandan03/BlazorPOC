using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class TimeEntry
    {
        public int TimeEntryId { get; set; }
        public string EmpId { get; set; }
        public DateTime Date { get; set; }
        public DateTime? PunchIn { get; set; }
        public DateTime? PunchOut { get; set; }
        public string PunchMode { get; set; }
        public string PunchLocation { get; set; }
        public int? InTimeMin { get; set; }
        public int? OutTimeMin { get; set; }
        public int? TotalTime { get; set; }
        public int? BranchId { get; set; }
    }
}

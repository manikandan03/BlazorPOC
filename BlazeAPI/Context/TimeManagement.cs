using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class TimeManagement
    {
        public int TimeManagement1 { get; set; }
        public string EmpId { get; set; }
        public string InTime { get; set; }
        public string OutTime { get; set; }
        public int? InTimeMin { get; set; }
        public int? OutTimeMin { get; set; }
        public DateTime Date { get; set; }
        public int? TotalTime { get; set; }
        public int? BranchId { get; set; }
    }
}

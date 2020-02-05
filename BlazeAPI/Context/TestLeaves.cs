using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class TestLeaves
    {
        public int Userid { get; set; }
        public int? LeaveRequestId { get; set; }
        public string LeaveType { get; set; }
        public DateTime? DateData { get; set; }
        public double? LeaveDays { get; set; }
        public double Sick { get; set; }
        public double Casual { get; set; }
        public double Earned { get; set; }
        public double Lop { get; set; }
        public double ProbationLeave { get; set; }
    }
}

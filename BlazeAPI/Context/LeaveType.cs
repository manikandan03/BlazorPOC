using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class LeaveType
    {
        public LeaveType()
        {
            LeaveBalanceCount = new HashSet<LeaveBalanceCount>();
            LeaveRequest = new HashSet<LeaveRequest>();
        }

        public byte LeaveTypeId { get; set; }
        public string Name { get; set; }
        public int? DaysAllowed { get; set; }
        public bool? CalculateLeaveDays { get; set; }
        public string ApplicableEmployees { get; set; }

        public virtual ICollection<LeaveBalanceCount> LeaveBalanceCount { get; set; }
        public virtual ICollection<LeaveRequest> LeaveRequest { get; set; }
    }
}

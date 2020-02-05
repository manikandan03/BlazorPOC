using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterLeaveStatus
    {
        public MasterLeaveStatus()
        {
            LeaveRequest = new HashSet<LeaveRequest>();
        }

        public byte LeaveStatusId { get; set; }
        public string Status { get; set; }

        public virtual ICollection<LeaveRequest> LeaveRequest { get; set; }
    }
}

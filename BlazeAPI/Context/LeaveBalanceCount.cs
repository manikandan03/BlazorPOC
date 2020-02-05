using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class LeaveBalanceCount
    {
        public int Id { get; set; }
        public int? UserId { get; set; }
        public byte? LeaveTypeId { get; set; }
        public int? Year { get; set; }
        public double? Value { get; set; }

        public virtual LeaveType LeaveType { get; set; }
    }
}

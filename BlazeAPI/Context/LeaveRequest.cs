using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class LeaveRequest
    {
        public int LeaveRequestId { get; set; }
        public int UserId { get; set; }
        public byte? LeaveTypeId { get; set; }
        public byte? LeaveStatusId { get; set; }
        public DateTime? StartDateTime { get; set; }
        public DateTime? EndDateTime { get; set; }
        public string Comments { get; set; }
        public double? LeaveDays { get; set; }
        public string Details { get; set; }
        public int? ProcessedBy { get; set; }
        public DateTime? ProcessedOn { get; set; }
        public int? ReportingTo { get; set; }
        public DateTime? RequestedDate { get; set; }
        public string WorkedDate { get; set; }
        public double? Lop { get; set; }
        public double? Sick { get; set; }
        public double? Casual { get; set; }
        public double? Earned { get; set; }
        public int? ReportingHrid { get; set; }
        public int? ReportingMarketingId { get; set; }
        public string ClientMailLocation { get; set; }
        public double? SickAfterProbation { get; set; }
        public double? CasualAfterProbation { get; set; }
        public double? ProbationLeave { get; set; }
        public bool? UnInformedLeaveFlag { get; set; }

        public virtual MasterLeaveStatus LeaveStatus { get; set; }
        public virtual LeaveType LeaveType { get; set; }
        public virtual Users ProcessedByNavigation { get; set; }
        public virtual Users User { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class ItreopenHistory
    {
        public int ItreopenId { get; set; }
        public int ItrequestId { get; set; }
        public int Categoryid { get; set; }
        public int Priorityid { get; set; }
        public int RequestedUserId { get; set; }
        public int? ProjectId { get; set; }
        public DateTime? RequestedDate { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
        public int StatusId { get; set; }
        public int? ReportingUserId { get; set; }
        public string EngineerUserId { get; set; }
        public string Description { get; set; }
        public DateTime? ProcessedDate { get; set; }
        public int? RejectedBy { get; set; }
        public string RejectedReason { get; set; }
        public string ReportingComments { get; set; }
        public int? FloorId { get; set; }
        public int? MachineRequestUserId { get; set; }
        public int? ToFloorId { get; set; }
        public int? GitCategory { get; set; }
        public string GitClosedComments { get; set; }
        public bool? IsReportingApproval { get; set; }
        public bool? ItRevoke { get; set; }
        public DateTime? ItRevokedDate { get; set; }
        public int? SoftHardId { get; set; }
        public string HardSoftVersion { get; set; }
        public int? ItrequestHistoryId { get; set; }
        public int? AssignedTo { get; set; }
        public DateTime? AssignedOn { get; set; }
        public int? AssignedBy { get; set; }
        public int? StatusIdHistory { get; set; }
        public DateTime? Closedon { get; set; }
        public string Comments { get; set; }
        public string ClosedComments { get; set; }
        public int? AssignedFrom { get; set; }
        public bool? FromIsActive { get; set; }
        public bool? ToIsActive { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class Itrequest
    {
        public Itrequest()
        {
            ItrequestAttachment = new HashSet<ItrequestAttachment>();
            ItrequestHistory = new HashSet<ItrequestHistory>();
            ItrequestUserComments = new HashSet<ItrequestUserComments>();
        }

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
        public string ReopenReason { get; set; }
        public string FileUploadPath { get; set; }
        public string UploadedFileName { get; set; }
        public int? ServerId { get; set; }
        public string Ipaddress { get; set; }
        public int? Port { get; set; }
        public string ExternalIpaddress { get; set; }
        public string ExtPort { get; set; }
        public string DnsName { get; set; }
        public string HostName { get; set; }
        public string UserClosedComments { get; set; }

        public virtual MasterCategory Category { get; set; }
        public virtual MasterPriority Priority { get; set; }
        public virtual MasterItstatus Status { get; set; }
        public virtual ICollection<ItrequestAttachment> ItrequestAttachment { get; set; }
        public virtual ICollection<ItrequestHistory> ItrequestHistory { get; set; }
        public virtual ICollection<ItrequestUserComments> ItrequestUserComments { get; set; }
    }
}

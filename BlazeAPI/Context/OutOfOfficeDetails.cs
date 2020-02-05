using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class OutOfOfficeDetails
    {
        public OutOfOfficeDetails()
        {
            UserTask = new HashSet<UserTask>();
        }

        public int Odid { get; set; }
        public DateTime? OdstartDate { get; set; }
        public DateTime? OdendDate { get; set; }
        public int? OdworkingDays { get; set; }
        public string OdalternateNo { get; set; }
        public int? OdtypeId { get; set; }
        public int? OdplaceId { get; set; }
        public string Odcomments { get; set; }
        public int? Userid { get; set; }
        public byte? RequestStatusId { get; set; }
        public int? ReportingPersonId { get; set; }
        public string Others { get; set; }
        public int? StatusUpdatedBy { get; set; }
        public string MngrComments { get; set; }
        public DateTime? RequestedDate { get; set; }
        public int? RejectedUserid { get; set; }
        public string RejectedReason { get; set; }
        public DateTime? RejectedDate { get; set; }
        public int? Ireject { get; set; }

        public virtual MasterWfhstatus RequestStatus { get; set; }
        public virtual Users User { get; set; }
        public virtual ICollection<UserTask> UserTask { get; set; }
    }
}

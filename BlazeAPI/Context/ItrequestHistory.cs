using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class ItrequestHistory
    {
        public int ItrequestHistoryId { get; set; }
        public int ItrequestId { get; set; }
        public int AssignedTo { get; set; }
        public DateTime AssignedOn { get; set; }
        public int AssignedBy { get; set; }
        public int StatusId { get; set; }
        public DateTime? Closedon { get; set; }
        public string Comments { get; set; }
        public string ClosedComments { get; set; }
        public int? AssignedFrom { get; set; }
        public bool? FromIsActive { get; set; }
        public bool? ToIsActive { get; set; }

        public virtual Itrequest Itrequest { get; set; }
        public virtual MasterItrequestHistoryStatus Status { get; set; }
    }
}

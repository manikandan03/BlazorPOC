using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterItrequestHistoryStatus
    {
        public MasterItrequestHistoryStatus()
        {
            ItrequestHistory = new HashSet<ItrequestHistory>();
        }

        public int StatusId { get; set; }
        public string Status { get; set; }

        public virtual ICollection<ItrequestHistory> ItrequestHistory { get; set; }
    }
}

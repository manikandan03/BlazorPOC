using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class MasterLoginStatus
    {
        public MasterLoginStatus()
        {
            AuditLoginStatus = new HashSet<AuditLoginStatus>();
        }

        public int LoginStatusId { get; set; }
        public string LoginStatus { get; set; }

        public virtual ICollection<AuditLoginStatus> AuditLoginStatus { get; set; }
    }
}

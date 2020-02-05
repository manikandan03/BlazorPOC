using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class AuditLoginStatus
    {
        public int AuditLoginStatusId { get; set; }
        public string Ipaddress { get; set; }
        public string BrowserVersion { get; set; }
        public DateTime? LogedInDate { get; set; }
        public int? LoginStatusId { get; set; }

        public virtual MasterLoginStatus LoginStatus { get; set; }
    }
}

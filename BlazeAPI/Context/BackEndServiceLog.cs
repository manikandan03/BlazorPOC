using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class BackEndServiceLog
    {
        public BackEndServiceLog()
        {
            BackEndServiceErrorLog = new HashSet<BackEndServiceErrorLog>();
        }

        public int BackEndServiceLogId { get; set; }
        public int BackendServiceTypeId { get; set; }
        public DateTime DateTime { get; set; }
        public bool IsStarted { get; set; }
        public bool IsFailed { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsMailSent { get; set; }
        public int? IdInt { get; set; }
        public Guid? IdUuniqueidentifier { get; set; }

        public virtual MasterBackendServiceType BackendServiceType { get; set; }
        public virtual AuditLog1 IdUuniqueidentifierNavigation { get; set; }
        public virtual ICollection<BackEndServiceErrorLog> BackEndServiceErrorLog { get; set; }
    }
}

using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class AuditLog1
    {
        public AuditLog1()
        {
            BackEndServiceLog = new HashSet<BackEndServiceLog>();
            SonarQubeProjectAuditLog = new HashSet<SonarQubeProjectAuditLog>();
            SourceCodeRepoAuditLog = new HashSet<SourceCodeRepoAuditLog>();
        }

        public Guid AuditLogId { get; set; }
        public int AuditTypeId { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime? CompletionDateTime { get; set; }
        public string AuditName { get; set; }
        public bool IsStarted { get; set; }
        public bool IsFailed { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsMailSent { get; set; }

        public virtual ICollection<BackEndServiceLog> BackEndServiceLog { get; set; }
        public virtual ICollection<SonarQubeProjectAuditLog> SonarQubeProjectAuditLog { get; set; }
        public virtual ICollection<SourceCodeRepoAuditLog> SourceCodeRepoAuditLog { get; set; }
    }
}

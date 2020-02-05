using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class SourceCodeRepoAuditLog
    {
        public long SourceCodeRepoAuditLogId { get; set; }
        public int SourceCodeRepoId { get; set; }
        public string LastCommitBranch { get; set; }
        public string LastCommitDevName { get; set; }
        public string LastCommitMessage { get; set; }
        public DateTime? LastCommitDateTime { get; set; }
        public string MasterBranchName { get; set; }
        public string MasterCommitterName { get; set; }
        public string MasterCommitMessage { get; set; }
        public DateTime? MasterCommitDateTime { get; set; }
        public Guid? AuditLogId { get; set; }
        public int NoofBranchs { get; set; }

        public virtual AuditLog1 AuditLog { get; set; }
        public virtual SourceCodeRepoDetail SourceCodeRepo { get; set; }
    }
}

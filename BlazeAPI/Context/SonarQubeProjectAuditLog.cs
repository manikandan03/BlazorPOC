using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class SonarQubeProjectAuditLog
    {
        public long SonarQubeProjectAuditLogId { get; set; }
        public int SourceCodeRepoId { get; set; }
        public Guid? AuditLogId { get; set; }
        public int? NoOfBugs { get; set; }
        public int? NoOfVulnerabilities { get; set; }
        public int? CodeSmells { get; set; }
        public decimal? Coverage { get; set; }
        public decimal? Duplications { get; set; }
        public int? DuplicatedBlocks { get; set; }
        public int? NewBugs { get; set; }
        public int? NewVulnerabilities { get; set; }
        public int? NewCodeSmells { get; set; }
        public int? NewLinesCoverage { get; set; }
        public decimal? NewCoverage { get; set; }
        public decimal? NewDuplications { get; set; }
        public int? NewLinesDuplication { get; set; }
        public int? CriticalIssues { get; set; }
        public bool SonorqubeStatus { get; set; }
        public DateTime LastAnalysisDate { get; set; }
        public bool JekinsStatus { get; set; }
        public string BugsRating { get; set; }
        public string NewBugsRating { get; set; }
        public string VulnerabilitiesRating { get; set; }
        public string NewVulnerabilitiesRating { get; set; }
        public string DebtRating { get; set; }
        public string NewDebtRating { get; set; }
        public string DuplicationsRating { get; set; }
        public int? Debt { get; set; }
        public int? NewDebt { get; set; }

        public virtual AuditLog1 AuditLog { get; set; }
        public virtual SourceCodeRepoDetail SourceCodeRepo { get; set; }
    }
}

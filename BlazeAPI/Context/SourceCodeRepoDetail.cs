using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class SourceCodeRepoDetail
    {
        public SourceCodeRepoDetail()
        {
            GitAccessDetail = new HashSet<GitAccessDetail>();
            ScmreasonDetails = new HashSet<ScmreasonDetails>();
            SonarQubeProjectAuditLog = new HashSet<SonarQubeProjectAuditLog>();
            SourceCodeRepoAuditLog = new HashSet<SourceCodeRepoAuditLog>();
            SourceRepoBranchDetail = new HashSet<SourceRepoBranchDetail>();
        }

        public int SourceCodeRepoId { get; set; }
        public string SourceCodeRepoName { get; set; }
        public int ProjectId { get; set; }
        public string SourceCodeRepoDescription { get; set; }
        public DateTime? SourceCodeRepoCreatedDateTime { get; set; }
        public string Url { get; set; }
        public string AccessToken { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime? RecordInsertedDate { get; set; }
        public bool? IsActive { get; set; }
        public string OrganizationName { get; set; }
        public int? SourceCodeTypeId { get; set; }
        public string SonarQubeProjectName { get; set; }
        public string JenkinsProjectName { get; set; }
        public int? UploadedBy { get; set; }
        public int? GitLabProjectId { get; set; }

        public virtual Projects Project { get; set; }
        public virtual SourceCodeRepoType SourceCodeType { get; set; }
        public virtual ICollection<GitAccessDetail> GitAccessDetail { get; set; }
        public virtual ICollection<ScmreasonDetails> ScmreasonDetails { get; set; }
        public virtual ICollection<SonarQubeProjectAuditLog> SonarQubeProjectAuditLog { get; set; }
        public virtual ICollection<SourceCodeRepoAuditLog> SourceCodeRepoAuditLog { get; set; }
        public virtual ICollection<SourceRepoBranchDetail> SourceRepoBranchDetail { get; set; }
    }
}

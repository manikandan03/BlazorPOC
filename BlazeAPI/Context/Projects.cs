using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class Projects
    {
        public Projects()
        {
            CheckListMapping = new HashSet<CheckListMapping>();
            DataBaseValues = new HashSet<DataBaseValues>();
            DatabaseReport = new HashSet<DatabaseReport>();
            MettingSchedule = new HashSet<MettingSchedule>();
            MileStoneValues = new HashSet<MileStoneValues>();
            Ormvalues = new HashSet<Ormvalues>();
            ProjectCategoryMapping = new HashSet<ProjectCategoryMapping>();
            ProjectSoftware = new HashSet<ProjectSoftware>();
            ProjectStatusHistory = new HashSet<ProjectStatusHistory>();
            ProjectStatusNavigation = new HashSet<ProjectStatus>();
            ProjectToolDetail = new HashSet<ProjectToolDetail>();
            QaprojectRagStatus = new HashSet<QaprojectRagStatus>();
            QareportQuestionAnswers = new HashSet<QareportQuestionAnswers>();
            RemoveRequest = new HashSet<RemoveRequest>();
            SourceCodeRepoDetail = new HashSet<SourceCodeRepoDetail>();
            SourceControlValues = new HashSet<SourceControlValues>();
            ThirdPartyValues = new HashSet<ThirdPartyValues>();
            TimesheetType = new HashSet<TimesheetType>();
            UserProjects = new HashSet<UserProjects>();
        }

        public int ProjectId { get; set; }
        public string ProjectName { get; set; }
        public string ProjectCode { get; set; }
        public string ProjectDescription { get; set; }
        public int? ProjectTypeId { get; set; }
        public string SvnRepositoryUrl { get; set; }
        public DateTime? DateCreated { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDeleted { get; set; }
        public int? Ragstatus { get; set; }
        public string Ragcomments { get; set; }
        public DateTime? CommentsCreated { get; set; }
        public string Metrix { get; set; }
        public int? CommentedBy { get; set; }
        public DateTime? ProjectStartDate { get; set; }
        public DateTime? ProjectEndDate { get; set; }
        public int? Createdby { get; set; }
        public bool? IsQms { get; set; }
        public int? DepartmentId { get; set; }
        public bool? QacodePopUp { get; set; }
        public bool? DeliveryPopUp { get; set; }
        public int? ProjectStatus { get; set; }
        public int? AccountManagerId { get; set; }
        public int? ReportingPersonId { get; set; }
        public int? DeliveryManagerId { get; set; }
        public string ManagedResourcesId { get; set; }
        public string CustomerName { get; set; }
        public string CustomerInformation { get; set; }
        public int? Reviewtypeid { get; set; }

        public virtual MasterProjectTypes ProjectType { get; set; }
        public virtual ICollection<CheckListMapping> CheckListMapping { get; set; }
        public virtual ICollection<DataBaseValues> DataBaseValues { get; set; }
        public virtual ICollection<DatabaseReport> DatabaseReport { get; set; }
        public virtual ICollection<MettingSchedule> MettingSchedule { get; set; }
        public virtual ICollection<MileStoneValues> MileStoneValues { get; set; }
        public virtual ICollection<Ormvalues> Ormvalues { get; set; }
        public virtual ICollection<ProjectCategoryMapping> ProjectCategoryMapping { get; set; }
        public virtual ICollection<ProjectSoftware> ProjectSoftware { get; set; }
        public virtual ICollection<ProjectStatusHistory> ProjectStatusHistory { get; set; }
        public virtual ICollection<ProjectStatus> ProjectStatusNavigation { get; set; }
        public virtual ICollection<ProjectToolDetail> ProjectToolDetail { get; set; }
        public virtual ICollection<QaprojectRagStatus> QaprojectRagStatus { get; set; }
        public virtual ICollection<QareportQuestionAnswers> QareportQuestionAnswers { get; set; }
        public virtual ICollection<RemoveRequest> RemoveRequest { get; set; }
        public virtual ICollection<SourceCodeRepoDetail> SourceCodeRepoDetail { get; set; }
        public virtual ICollection<SourceControlValues> SourceControlValues { get; set; }
        public virtual ICollection<ThirdPartyValues> ThirdPartyValues { get; set; }
        public virtual ICollection<TimesheetType> TimesheetType { get; set; }
        public virtual ICollection<UserProjects> UserProjects { get; set; }
    }
}

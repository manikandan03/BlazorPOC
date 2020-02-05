using System;
using System.Collections.Generic;

namespace BlazeAPI.Context
{
    public partial class Users
    {
        public Users()
        {
            AllEmpLeaveEntryPermission = new HashSet<AllEmpLeaveEntryPermission>();
            Attachment = new HashSet<Attachment>();
            ChildrensInformation = new HashSet<ChildrensInformation>();
            Communication = new HashSet<Communication>();
            CommunicationEmailLog = new HashSet<CommunicationEmailLog>();
            ConferenceRoom = new HashSet<ConferenceRoom>();
            DatabaseAccessDetail = new HashSet<DatabaseAccessDetail>();
            EmployeeEditedDetails = new HashSet<EmployeeEditedDetails>();
            EmployeeFeedbackQuestionAnswerAnsweredByUser = new HashSet<EmployeeFeedbackQuestionAnswer>();
            EmployeeFeedbackQuestionAnswerUser = new HashSet<EmployeeFeedbackQuestionAnswer>();
            EmployeeGoalsGoalSetByUser = new HashSet<EmployeeGoals>();
            EmployeeGoalsUser = new HashSet<EmployeeGoals>();
            EmployeeRatingRatedByUser = new HashSet<EmployeeRating>();
            EmployeeRatingUser = new HashSet<EmployeeRating>();
            EmployeeRecognitionRecognisedByUser = new HashSet<EmployeeRecognition>();
            EmployeeRecognitionUser = new HashSet<EmployeeRecognition>();
            FeedbackComments = new HashSet<FeedbackComments>();
            GitAccessDetail = new HashSet<GitAccessDetail>();
            ItrequestUserComments = new HashSet<ItrequestUserComments>();
            LeaveRequestProcessedByNavigation = new HashSet<LeaveRequest>();
            LeaveRequestUser = new HashSet<LeaveRequest>();
            ManageTab = new HashSet<ManageTab>();
            OutOfOfficeDetails = new HashSet<OutOfOfficeDetails>();
            PermanentAddress = new HashSet<PermanentAddress>();
            PresentAddress = new HashSet<PresentAddress>();
            ProjectStatusHistory = new HashSet<ProjectStatusHistory>();
            ProjectToolAccessDetail = new HashSet<ProjectToolAccessDetail>();
            QaprojectRagStatus = new HashSet<QaprojectRagStatus>();
            QareportQuestionAnswers = new HashSet<QareportQuestionAnswers>();
            ScmreasonDetails = new HashSet<ScmreasonDetails>();
            Server = new HashSet<Server>();
            ServerAccessInfo = new HashSet<ServerAccessInfo>();
            StarPerformanceDetails = new HashSet<StarPerformanceDetails>();
            TaggedAlbums = new HashSet<TaggedAlbums>();
            TrainingEmailLog = new HashSet<TrainingEmailLog>();
            Trainingabsenteesreason = new HashSet<Trainingabsenteesreason>();
            UserFeedback = new HashSet<UserFeedback>();
            UserHrreporting = new HashSet<UserHrreporting>();
            UserMarketingReporting = new HashSet<UserMarketingReporting>();
            UserProfile = new HashSet<UserProfile>();
            UserProjects = new HashSet<UserProjects>();
            UserReporting = new HashSet<UserReporting>();
            UserRoles = new HashSet<UserRoles>();
            UserSkills = new HashSet<UserSkills>();
            UserSoftwares = new HashSet<UserSoftwares>();
            UserTraining = new HashSet<UserTraining>();
            UsersFeedback = new HashSet<UsersFeedback>();
            WorkFromHomeEntryEnteredByNavigation = new HashSet<WorkFromHomeEntry>();
            WorkFromHomeEntryUser = new HashSet<WorkFromHomeEntry>();
        }

        public int UserId { get; set; }
        public string EmpId { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public DateTime? DateOfJoin { get; set; }
        public string ContactNo { get; set; }
        public string EmailAddress { get; set; }
        public string Ipaddress { get; set; }
        public string MachineName { get; set; }
        public string DirectReportingTo { get; set; }
        public bool? IsUnderProbation { get; set; }
        public bool? IsUnderNoticePeriod { get; set; }
        public bool? IsFirstLogin { get; set; }
        public DateTime? CreatedAt { get; set; }
        public DateTime? LastAccessed { get; set; }
        public bool? IsActive { get; set; }
        public int? DepartmentId { get; set; }
        public int? Gender { get; set; }
        public int? PermanentAddressId { get; set; }
        public int? TemporaryAddressId { get; set; }
        public DateTime? ResignedOn { get; set; }
        public DateTime? LastWorkingDate { get; set; }
        public string Experience { get; set; }
        public bool? IsBoarding { get; set; }
        public string OfficeSkypeId { get; set; }
        public int? Attempts { get; set; }
        public string Key { get; set; }
        public int? PasswordKey { get; set; }
        public int? IsReseted { get; set; }
        public string Workplace { get; set; }
        public int? IsPasswordReseted { get; set; }
        public int? Officeno { get; set; }
        public int? Extension { get; set; }
        public bool? IsExclude { get; set; }
        public int? MaritalStatus { get; set; }
        public int? CreatedUserId { get; set; }
        public int? BranchId { get; set; }
        public int? DesignationId { get; set; }
        public int? UserStatus { get; set; }
        public int? Region { get; set; }
        public int? DepartmentGroup { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string BloodGroup { get; set; }
        public string BirthPlace { get; set; }
        public int? NationalityId { get; set; }
        public int? ReligionId { get; set; }
        public string SpouseName { get; set; }
        public int? NoOfChild { get; set; }
        public DateTime? AnniversaryDate { get; set; }
        public long? EmergencyContact { get; set; }
        public int? RelationshipId { get; set; }
        public string Contactperson { get; set; }
        public byte? RoleId { get; set; }
        public string EmpCode { get; set; }
        public int? Department { get; set; }
        public DateTime? ConfirmationDate { get; set; }
        public DateTime? FatherDob { get; set; }
        public DateTime? MotherDob { get; set; }
        public DateTime? SpouseDob { get; set; }
        public string PersonalEmail { get; set; }
        public string SpouseNumber { get; set; }
        public string AlternateNumber { get; set; }
        public bool? PersonalDetails { get; set; }
        public bool? FathersClaim { get; set; }
        public bool? MothersClaim { get; set; }
        public string FathersLastName { get; set; }
        public string MothersLastName { get; set; }
        public int? FathersPremium { get; set; }
        public int? MothersPremium { get; set; }
        public string MotherInLawFirstName { get; set; }
        public string MotherInLawLastName { get; set; }
        public string FatherInLawFirstName { get; set; }
        public string FatherInLawLastName { get; set; }
        public bool? FatherInLawClaim { get; set; }
        public bool? MotherInLawClaim { get; set; }
        public int? FatherInLawsPremium { get; set; }
        public int? MotherInLawsPremium { get; set; }
        public DateTime? FatherInLawDob { get; set; }
        public DateTime? MotherInLawDob { get; set; }
        public bool? FatherOrMotherClaim { get; set; }
        public bool? FatherInLawOrMotherInLawClaim { get; set; }
        public bool? IsItrequestAccepted { get; set; }
        public int? FloorId { get; set; }
        public string DeliveryManagerId { get; set; }
        public DateTime? AttemptDate { get; set; }
        public string SamsAccountName { get; set; }
        public bool? IsServiceExcluded { get; set; }
        public int UserWfhcount { get; set; }
        public long? TestingDevicePin { get; set; }

        public virtual Department DepartmentNavigation { get; set; }
        public virtual ICollection<AllEmpLeaveEntryPermission> AllEmpLeaveEntryPermission { get; set; }
        public virtual ICollection<Attachment> Attachment { get; set; }
        public virtual ICollection<ChildrensInformation> ChildrensInformation { get; set; }
        public virtual ICollection<Communication> Communication { get; set; }
        public virtual ICollection<CommunicationEmailLog> CommunicationEmailLog { get; set; }
        public virtual ICollection<ConferenceRoom> ConferenceRoom { get; set; }
        public virtual ICollection<DatabaseAccessDetail> DatabaseAccessDetail { get; set; }
        public virtual ICollection<EmployeeEditedDetails> EmployeeEditedDetails { get; set; }
        public virtual ICollection<EmployeeFeedbackQuestionAnswer> EmployeeFeedbackQuestionAnswerAnsweredByUser { get; set; }
        public virtual ICollection<EmployeeFeedbackQuestionAnswer> EmployeeFeedbackQuestionAnswerUser { get; set; }
        public virtual ICollection<EmployeeGoals> EmployeeGoalsGoalSetByUser { get; set; }
        public virtual ICollection<EmployeeGoals> EmployeeGoalsUser { get; set; }
        public virtual ICollection<EmployeeRating> EmployeeRatingRatedByUser { get; set; }
        public virtual ICollection<EmployeeRating> EmployeeRatingUser { get; set; }
        public virtual ICollection<EmployeeRecognition> EmployeeRecognitionRecognisedByUser { get; set; }
        public virtual ICollection<EmployeeRecognition> EmployeeRecognitionUser { get; set; }
        public virtual ICollection<FeedbackComments> FeedbackComments { get; set; }
        public virtual ICollection<GitAccessDetail> GitAccessDetail { get; set; }
        public virtual ICollection<ItrequestUserComments> ItrequestUserComments { get; set; }
        public virtual ICollection<LeaveRequest> LeaveRequestProcessedByNavigation { get; set; }
        public virtual ICollection<LeaveRequest> LeaveRequestUser { get; set; }
        public virtual ICollection<ManageTab> ManageTab { get; set; }
        public virtual ICollection<OutOfOfficeDetails> OutOfOfficeDetails { get; set; }
        public virtual ICollection<PermanentAddress> PermanentAddress { get; set; }
        public virtual ICollection<PresentAddress> PresentAddress { get; set; }
        public virtual ICollection<ProjectStatusHistory> ProjectStatusHistory { get; set; }
        public virtual ICollection<ProjectToolAccessDetail> ProjectToolAccessDetail { get; set; }
        public virtual ICollection<QaprojectRagStatus> QaprojectRagStatus { get; set; }
        public virtual ICollection<QareportQuestionAnswers> QareportQuestionAnswers { get; set; }
        public virtual ICollection<ScmreasonDetails> ScmreasonDetails { get; set; }
        public virtual ICollection<Server> Server { get; set; }
        public virtual ICollection<ServerAccessInfo> ServerAccessInfo { get; set; }
        public virtual ICollection<StarPerformanceDetails> StarPerformanceDetails { get; set; }
        public virtual ICollection<TaggedAlbums> TaggedAlbums { get; set; }
        public virtual ICollection<TrainingEmailLog> TrainingEmailLog { get; set; }
        public virtual ICollection<Trainingabsenteesreason> Trainingabsenteesreason { get; set; }
        public virtual ICollection<UserFeedback> UserFeedback { get; set; }
        public virtual ICollection<UserHrreporting> UserHrreporting { get; set; }
        public virtual ICollection<UserMarketingReporting> UserMarketingReporting { get; set; }
        public virtual ICollection<UserProfile> UserProfile { get; set; }
        public virtual ICollection<UserProjects> UserProjects { get; set; }
        public virtual ICollection<UserReporting> UserReporting { get; set; }
        public virtual ICollection<UserRoles> UserRoles { get; set; }
        public virtual ICollection<UserSkills> UserSkills { get; set; }
        public virtual ICollection<UserSoftwares> UserSoftwares { get; set; }
        public virtual ICollection<UserTraining> UserTraining { get; set; }
        public virtual ICollection<UsersFeedback> UsersFeedback { get; set; }
        public virtual ICollection<WorkFromHomeEntry> WorkFromHomeEntryEnteredByNavigation { get; set; }
        public virtual ICollection<WorkFromHomeEntry> WorkFromHomeEntryUser { get; set; }
    }
}

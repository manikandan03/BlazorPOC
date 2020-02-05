using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace BlazeAPI.Context
{
    public partial class HRMS_TestingContext : DbContext
    {
        public HRMS_TestingContext()
        {
        }

        public HRMS_TestingContext(DbContextOptions<HRMS_TestingContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Actions> Actions { get; set; }
        public virtual DbSet<AddHoliday> AddHoliday { get; set; }
        public virtual DbSet<AddHolidayLog> AddHolidayLog { get; set; }
        public virtual DbSet<Album> Album { get; set; }
        public virtual DbSet<AlbumAccess> AlbumAccess { get; set; }
        public virtual DbSet<AlbumPermission> AlbumPermission { get; set; }
        public virtual DbSet<AlbumPhotos> AlbumPhotos { get; set; }
        public virtual DbSet<AllEmpLeaveEntryPermission> AllEmpLeaveEntryPermission { get; set; }
        public virtual DbSet<Assessment> Assessment { get; set; }
        public virtual DbSet<AssetType> AssetType { get; set; }
        public virtual DbSet<Attachment> Attachment { get; set; }
        public virtual DbSet<AttachmentType> AttachmentType { get; set; }
        public virtual DbSet<AuditLog> AuditLog { get; set; }
        public virtual DbSet<AuditLog1> AuditLog1 { get; set; }
        public virtual DbSet<AuditLoginStatus> AuditLoginStatus { get; set; }
        public virtual DbSet<BackEndServiceErrorLog> BackEndServiceErrorLog { get; set; }
        public virtual DbSet<BackEndServiceLog> BackEndServiceLog { get; set; }
        public virtual DbSet<BookingPurpose> BookingPurpose { get; set; }
        public virtual DbSet<CalendarYear> CalendarYear { get; set; }
        public virtual DbSet<Category> Category { get; set; }
        public virtual DbSet<CheckList> CheckList { get; set; }
        public virtual DbSet<CheckListMapping> CheckListMapping { get; set; }
        public virtual DbSet<CheckUninformedEntryMiss> CheckUninformedEntryMiss { get; set; }
        public virtual DbSet<ChildrensInformation> ChildrensInformation { get; set; }
        public virtual DbSet<Communication> Communication { get; set; }
        public virtual DbSet<CommunicationAttachment> CommunicationAttachment { get; set; }
        public virtual DbSet<CommunicationEmailLog> CommunicationEmailLog { get; set; }
        public virtual DbSet<Compoffmail> Compoffmail { get; set; }
        public virtual DbSet<ComputerAssigned> ComputerAssigned { get; set; }
        public virtual DbSet<Computermanagement> Computermanagement { get; set; }
        public virtual DbSet<ConferenceRoom> ConferenceRoom { get; set; }
        public virtual DbSet<ConfirmationFeedback> ConfirmationFeedback { get; set; }
        public virtual DbSet<ConfirmationRating> ConfirmationRating { get; set; }
        public virtual DbSet<ContactDetails> ContactDetails { get; set; }
        public virtual DbSet<DataBaseValues> DataBaseValues { get; set; }
        public virtual DbSet<DatabaseAccessDetail> DatabaseAccessDetail { get; set; }
        public virtual DbSet<DatabaseReport> DatabaseReport { get; set; }
        public virtual DbSet<DefaultAlbumUser> DefaultAlbumUser { get; set; }
        public virtual DbSet<DefaultFunctionPrecedanceOrder> DefaultFunctionPrecedanceOrder { get; set; }
        public virtual DbSet<DefaultModulePrecedanceOrder> DefaultModulePrecedanceOrder { get; set; }
        public virtual DbSet<DeliveryManagers> DeliveryManagers { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<DepartmentGroup> DepartmentGroup { get; set; }
        public virtual DbSet<DepartmentGroupMapping> DepartmentGroupMapping { get; set; }
        public virtual DbSet<DeviceManagement> DeviceManagement { get; set; }
        public virtual DbSet<Dictionary> Dictionary { get; set; }
        public virtual DbSet<EmailPurpose> EmailPurpose { get; set; }
        public virtual DbSet<EmailPurposeLog> EmailPurposeLog { get; set; }
        public virtual DbSet<EmailTemplate> EmailTemplate { get; set; }
        public virtual DbSet<EmployeeEditedDetails> EmployeeEditedDetails { get; set; }
        public virtual DbSet<EmployeeFeedbackQuestionAnswer> EmployeeFeedbackQuestionAnswer { get; set; }
        public virtual DbSet<EmployeeGoalProgress> EmployeeGoalProgress { get; set; }
        public virtual DbSet<EmployeeGoals> EmployeeGoals { get; set; }
        public virtual DbSet<EmployeeRating> EmployeeRating { get; set; }
        public virtual DbSet<EmployeeRatingDetail> EmployeeRatingDetail { get; set; }
        public virtual DbSet<EmployeeRecognition> EmployeeRecognition { get; set; }
        public virtual DbSet<EmployeeRevokeEmailLog> EmployeeRevokeEmailLog { get; set; }
        public virtual DbSet<EngineerContactDetails> EngineerContactDetails { get; set; }
        public virtual DbSet<ExceptionLog> ExceptionLog { get; set; }
        public virtual DbSet<Expenditure> Expenditure { get; set; }
        public virtual DbSet<Experiances> Experiances { get; set; }
        public virtual DbSet<FeedbackAttachment> FeedbackAttachment { get; set; }
        public virtual DbSet<FeedbackComments> FeedbackComments { get; set; }
        public virtual DbSet<FileUploads> FileUploads { get; set; }
        public virtual DbSet<FunctionModules> FunctionModules { get; set; }
        public virtual DbSet<FunctionPrecedanceOrder> FunctionPrecedanceOrder { get; set; }
        public virtual DbSet<Functions> Functions { get; set; }
        public virtual DbSet<GetClientVisitForm> GetClientVisitForm { get; set; }
        public virtual DbSet<GitAccessDetail> GitAccessDetail { get; set; }
        public virtual DbSet<IncidentDepartment> IncidentDepartment { get; set; }
        public virtual DbSet<IncidentManagement> IncidentManagement { get; set; }
        public virtual DbSet<IncidentManagementHistory> IncidentManagementHistory { get; set; }
        public virtual DbSet<IncidentPriority> IncidentPriority { get; set; }
        public virtual DbSet<Income> Income { get; set; }
        public virtual DbSet<InterviewSkillsRating> InterviewSkillsRating { get; set; }
        public virtual DbSet<ItRequestSoftHardItems> ItRequestSoftHardItems { get; set; }
        public virtual DbSet<ItTrackMail> ItTrackMail { get; set; }
        public virtual DbSet<ItreopenHistory> ItreopenHistory { get; set; }
        public virtual DbSet<Itrequest> Itrequest { get; set; }
        public virtual DbSet<ItrequestAttachment> ItrequestAttachment { get; set; }
        public virtual DbSet<ItrequestHistory> ItrequestHistory { get; set; }
        public virtual DbSet<ItrequestUserComments> ItrequestUserComments { get; set; }
        public virtual DbSet<LeaveBalanceCount> LeaveBalanceCount { get; set; }
        public virtual DbSet<LeaveRequest> LeaveRequest { get; set; }
        public virtual DbSet<LeaveType> LeaveType { get; set; }
        public virtual DbSet<Location> Location { get; set; }
        public virtual DbSet<ManageTab> ManageTab { get; set; }
        public virtual DbSet<ManageTabGrids> ManageTabGrids { get; set; }
        public virtual DbSet<MasterApplicationSettings> MasterApplicationSettings { get; set; }
        public virtual DbSet<MasterBackendServiceType> MasterBackendServiceType { get; set; }
        public virtual DbSet<MasterBloodGroup> MasterBloodGroup { get; set; }
        public virtual DbSet<MasterBranches> MasterBranches { get; set; }
        public virtual DbSet<MasterCategory> MasterCategory { get; set; }
        public virtual DbSet<MasterCity> MasterCity { get; set; }
        public virtual DbSet<MasterColumnTypes> MasterColumnTypes { get; set; }
        public virtual DbSet<MasterComponent> MasterComponent { get; set; }
        public virtual DbSet<MasterCountry> MasterCountry { get; set; }
        public virtual DbSet<MasterDataBaseTechnolgy> MasterDataBaseTechnolgy { get; set; }
        public virtual DbSet<MasterDays> MasterDays { get; set; }
        public virtual DbSet<MasterDesignation> MasterDesignation { get; set; }
        public virtual DbSet<MasterDeviceStatus> MasterDeviceStatus { get; set; }
        public virtual DbSet<MasterDifferentZone> MasterDifferentZone { get; set; }
        public virtual DbSet<MasterEmailTemplateCategory> MasterEmailTemplateCategory { get; set; }
        public virtual DbSet<MasterFeedBackQuestions> MasterFeedBackQuestions { get; set; }
        public virtual DbSet<MasterFloor> MasterFloor { get; set; }
        public virtual DbSet<MasterGender> MasterGender { get; set; }
        public virtual DbSet<MasterGitcategory> MasterGitcategory { get; set; }
        public virtual DbSet<MasterHoliday> MasterHoliday { get; set; }
        public virtual DbSet<MasterIsOpen> MasterIsOpen { get; set; }
        public virtual DbSet<MasterItfloor> MasterItfloor { get; set; }
        public virtual DbSet<MasterItrequestAttachmentType> MasterItrequestAttachmentType { get; set; }
        public virtual DbSet<MasterItrequestHistoryStatus> MasterItrequestHistoryStatus { get; set; }
        public virtual DbSet<MasterItstatus> MasterItstatus { get; set; }
        public virtual DbSet<MasterLdapSettings> MasterLdapSettings { get; set; }
        public virtual DbSet<MasterLeaveStatus> MasterLeaveStatus { get; set; }
        public virtual DbSet<MasterLoginStatus> MasterLoginStatus { get; set; }
        public virtual DbSet<MasterMaritalStatus> MasterMaritalStatus { get; set; }
        public virtual DbSet<MasterMemberTypes> MasterMemberTypes { get; set; }
        public virtual DbSet<MasterMileStones> MasterMileStones { get; set; }
        public virtual DbSet<MasterNationality> MasterNationality { get; set; }
        public virtual DbSet<MasterOrm> MasterOrm { get; set; }
        public virtual DbSet<MasterOs> MasterOs { get; set; }
        public virtual DbSet<MasterOutOfOfficePlaces> MasterOutOfOfficePlaces { get; set; }
        public virtual DbSet<MasterOutOfOfficeTypes> MasterOutOfOfficeTypes { get; set; }
        public virtual DbSet<MasterPermissions> MasterPermissions { get; set; }
        public virtual DbSet<MasterPremium> MasterPremium { get; set; }
        public virtual DbSet<MasterPriority> MasterPriority { get; set; }
        public virtual DbSet<MasterProjectResearchType> MasterProjectResearchType { get; set; }
        public virtual DbSet<MasterProjectStatus> MasterProjectStatus { get; set; }
        public virtual DbSet<MasterProjectTools> MasterProjectTools { get; set; }
        public virtual DbSet<MasterProjectTypes> MasterProjectTypes { get; set; }
        public virtual DbSet<MasterRatingCriteria> MasterRatingCriteria { get; set; }
        public virtual DbSet<MasterRecognition> MasterRecognition { get; set; }
        public virtual DbSet<MasterRelationship> MasterRelationship { get; set; }
        public virtual DbSet<MasterReligious> MasterReligious { get; set; }
        public virtual DbSet<MasterReportType> MasterReportType { get; set; }
        public virtual DbSet<MasterRequestStatus> MasterRequestStatus { get; set; }
        public virtual DbSet<MasterRoles> MasterRoles { get; set; }
        public virtual DbSet<MasterSkillStatus> MasterSkillStatus { get; set; }
        public virtual DbSet<MasterSoftwares> MasterSoftwares { get; set; }
        public virtual DbSet<MasterSourceControl> MasterSourceControl { get; set; }
        public virtual DbSet<MasterStates> MasterStates { get; set; }
        public virtual DbSet<MasterTab> MasterTab { get; set; }
        public virtual DbSet<MasterTabGrids> MasterTabGrids { get; set; }
        public virtual DbSet<MasterTeamMonths> MasterTeamMonths { get; set; }
        public virtual DbSet<MasterTechnologies> MasterTechnologies { get; set; }
        public virtual DbSet<MasterThemeColors> MasterThemeColors { get; set; }
        public virtual DbSet<MasterThirdParty> MasterThirdParty { get; set; }
        public virtual DbSet<MasterTrainingLevel> MasterTrainingLevel { get; set; }
        public virtual DbSet<MasterTrainingPurpose> MasterTrainingPurpose { get; set; }
        public virtual DbSet<MasterTrainingStatus> MasterTrainingStatus { get; set; }
        public virtual DbSet<MasterTrainingTechnology> MasterTrainingTechnology { get; set; }
        public virtual DbSet<MasterTrainingType> MasterTrainingType { get; set; }
        public virtual DbSet<MasterTsrMonth> MasterTsrMonth { get; set; }
        public virtual DbSet<MasterTypes> MasterTypes { get; set; }
        public virtual DbSet<MasterTypesofEmployees> MasterTypesofEmployees { get; set; }
        public virtual DbSet<MasterUserStatus> MasterUserStatus { get; set; }
        public virtual DbSet<MasterWeeks> MasterWeeks { get; set; }
        public virtual DbSet<MasterWfhstatus> MasterWfhstatus { get; set; }
        public virtual DbSet<MasterWorkPlace> MasterWorkPlace { get; set; }
        public virtual DbSet<MeetingGuids> MeetingGuids { get; set; }
        public virtual DbSet<MettingSchedule> MettingSchedule { get; set; }
        public virtual DbSet<MileStoneValues> MileStoneValues { get; set; }
        public virtual DbSet<MissingTemplates> MissingTemplates { get; set; }
        public virtual DbSet<ModulePages> ModulePages { get; set; }
        public virtual DbSet<ModulePrecedanceOrder> ModulePrecedanceOrder { get; set; }
        public virtual DbSet<Modules> Modules { get; set; }
        public virtual DbSet<Ormvalues> Ormvalues { get; set; }
        public virtual DbSet<OutOfOfficeDetails> OutOfOfficeDetails { get; set; }
        public virtual DbSet<Pages> Pages { get; set; }
        public virtual DbSet<PermanentAddress> PermanentAddress { get; set; }
        public virtual DbSet<PresentAddress> PresentAddress { get; set; }
        public virtual DbSet<ProjectCategoryMapping> ProjectCategoryMapping { get; set; }
        public virtual DbSet<ProjectMetrics> ProjectMetrics { get; set; }
        public virtual DbSet<ProjectPayment> ProjectPayment { get; set; }
        public virtual DbSet<ProjectSoftware> ProjectSoftware { get; set; }
        public virtual DbSet<ProjectStatus> ProjectStatus { get; set; }
        public virtual DbSet<ProjectStatusHistory> ProjectStatusHistory { get; set; }
        public virtual DbSet<ProjectToolAccessDetail> ProjectToolAccessDetail { get; set; }
        public virtual DbSet<ProjectToolDetail> ProjectToolDetail { get; set; }
        public virtual DbSet<ProjectUtilization> ProjectUtilization { get; set; }
        public virtual DbSet<Projects> Projects { get; set; }
        public virtual DbSet<PunchLocation> PunchLocation { get; set; }
        public virtual DbSet<QaprojectRagStatus> QaprojectRagStatus { get; set; }
        public virtual DbSet<QareportQuestionAnswers> QareportQuestionAnswers { get; set; }
        public virtual DbSet<QareportQuestionType> QareportQuestionType { get; set; }
        public virtual DbSet<QareportQuestions> QareportQuestions { get; set; }
        public virtual DbSet<QasprintReview> QasprintReview { get; set; }
        public virtual DbSet<QuickAccessMenu> QuickAccessMenu { get; set; }
        public virtual DbSet<QuickEnroll> QuickEnroll { get; set; }
        public virtual DbSet<RaiseRequestDetails> RaiseRequestDetails { get; set; }
        public virtual DbSet<RaiseRequestRoleRelationShip> RaiseRequestRoleRelationShip { get; set; }
        public virtual DbSet<Release> Release { get; set; }
        public virtual DbSet<RemainingEarnedLeaves> RemainingEarnedLeaves { get; set; }
        public virtual DbSet<RemoveRequest> RemoveRequest { get; set; }
        public virtual DbSet<ReportingPersonsRollId> ReportingPersonsRollId { get; set; }
        public virtual DbSet<ReportingUsers> ReportingUsers { get; set; }
        public virtual DbSet<Reports> Reports { get; set; }
        public virtual DbSet<ResearchDetails> ResearchDetails { get; set; }
        public virtual DbSet<ResearchTeamMember> ResearchTeamMember { get; set; }
        public virtual DbSet<ReviewType> ReviewType { get; set; }
        public virtual DbSet<RoleFunctionPrivileges> RoleFunctionPrivileges { get; set; }
        public virtual DbSet<RoleFunctions> RoleFunctions { get; set; }
        public virtual DbSet<ScmreasonDetails> ScmreasonDetails { get; set; }
        public virtual DbSet<Server> Server { get; set; }
        public virtual DbSet<ServerAccessInfo> ServerAccessInfo { get; set; }
        public virtual DbSet<ServerOs> ServerOs { get; set; }
        public virtual DbSet<ServerPatchInfo> ServerPatchInfo { get; set; }
        public virtual DbSet<ServerPort> ServerPort { get; set; }
        public virtual DbSet<ServiceMailSendingCheck> ServiceMailSendingCheck { get; set; }
        public virtual DbSet<SkillSpecificationMapping> SkillSpecificationMapping { get; set; }
        public virtual DbSet<Skills> Skills { get; set; }
        public virtual DbSet<SkillsSpecification> SkillsSpecification { get; set; }
        public virtual DbSet<SkillsTechnology> SkillsTechnology { get; set; }
        public virtual DbSet<SonarQubeProjectAuditLog> SonarQubeProjectAuditLog { get; set; }
        public virtual DbSet<SourceCodeRepoAuditLog> SourceCodeRepoAuditLog { get; set; }
        public virtual DbSet<SourceCodeRepoDetail> SourceCodeRepoDetail { get; set; }
        public virtual DbSet<SourceCodeRepoType> SourceCodeRepoType { get; set; }
        public virtual DbSet<SourceControlValues> SourceControlValues { get; set; }
        public virtual DbSet<SourceRepoBranchDetail> SourceRepoBranchDetail { get; set; }
        public virtual DbSet<StarPerformanceDetails> StarPerformanceDetails { get; set; }
        public virtual DbSet<Status> Status { get; set; }
        public virtual DbSet<TaggedAlbums> TaggedAlbums { get; set; }
        public virtual DbSet<TaskSource> TaskSource { get; set; }
        public virtual DbSet<TaskStatus> TaskStatus { get; set; }
        public virtual DbSet<TeamLunchRequest> TeamLunchRequest { get; set; }
        public virtual DbSet<TechnologyValues> TechnologyValues { get; set; }
        public virtual DbSet<TempUsers> TempUsers { get; set; }
        public virtual DbSet<TestLeaves> TestLeaves { get; set; }
        public virtual DbSet<TestMailIds> TestMailIds { get; set; }
        public virtual DbSet<ThirdPartyValues> ThirdPartyValues { get; set; }
        public virtual DbSet<TimeLog> TimeLog { get; set; }
        public virtual DbSet<TimeLogDetail> TimeLogDetail { get; set; }
        public virtual DbSet<TimeManagement> TimeManagement { get; set; }
        public virtual DbSet<TimeZone> TimeZone { get; set; }
        public virtual DbSet<TimesheetType> TimesheetType { get; set; }
        public virtual DbSet<Training> Training { get; set; }
        public virtual DbSet<TrainingCompletion> TrainingCompletion { get; set; }
        public virtual DbSet<TrainingDeliveryLog> TrainingDeliveryLog { get; set; }
        public virtual DbSet<TrainingEmailLog> TrainingEmailLog { get; set; }
        public virtual DbSet<TrainingFeedBackCalc> TrainingFeedBackCalc { get; set; }
        public virtual DbSet<TrainingFeedbackAggregate> TrainingFeedbackAggregate { get; set; }
        public virtual DbSet<TrainingInstructors> TrainingInstructors { get; set; }
        public virtual DbSet<TrainingMailPurpose> TrainingMailPurpose { get; set; }
        public virtual DbSet<TrainingNomination> TrainingNomination { get; set; }
        public virtual DbSet<TrainingPermission> TrainingPermission { get; set; }
        public virtual DbSet<TrainingWeightage> TrainingWeightage { get; set; }
        public virtual DbSet<Trainingabsenteesreason> Trainingabsenteesreason { get; set; }
        public virtual DbSet<UserDeviceHistory> UserDeviceHistory { get; set; }
        public virtual DbSet<UserFeedback> UserFeedback { get; set; }
        public virtual DbSet<UserHrreporting> UserHrreporting { get; set; }
        public virtual DbSet<UserMarketingReporting> UserMarketingReporting { get; set; }
        public virtual DbSet<UserProfile> UserProfile { get; set; }
        public virtual DbSet<UserProjects> UserProjects { get; set; }
        public virtual DbSet<UserQuickAccessMenu> UserQuickAccessMenu { get; set; }
        public virtual DbSet<UserReporting> UserReporting { get; set; }
        public virtual DbSet<UserRoleQuickAccessMenu> UserRoleQuickAccessMenu { get; set; }
        public virtual DbSet<UserRoles> UserRoles { get; set; }
        public virtual DbSet<UserSkills> UserSkills { get; set; }
        public virtual DbSet<UserSoftwares> UserSoftwares { get; set; }
        public virtual DbSet<UserTask> UserTask { get; set; }
        public virtual DbSet<UserTraining> UserTraining { get; set; }
        public virtual DbSet<Users> Users { get; set; }
        public virtual DbSet<UsersFeedback> UsersFeedback { get; set; }
        public virtual DbSet<ViewEmail> ViewEmail { get; set; }
        public virtual DbSet<ViewallProjectPermission> ViewallProjectPermission { get; set; }
        public virtual DbSet<WindowsAuthentication> WindowsAuthentication { get; set; }
        public virtual DbSet<WorkFromHomeEntry> WorkFromHomeEntry { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Data Source=DSRCWIN2016\\SQLEXPRESS2017;Database=Blaze;Trusted_Connection=False;user id=HRMS_Testing;password=hrm5$testing123;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actions>(entity =>
            {
                entity.HasKey(e => e.ActionId)
                    .HasName("PK__Actions__FFE3F4B9236943A5");

                entity.HasComment("This table contains the details of a action process status which is complete or rescheduled or not complete.");

                entity.Property(e => e.ActionId).HasColumnName("ActionID");

                entity.Property(e => e.ActionName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AddHoliday>(entity =>
            {
                entity.HasKey(e => e.HolidayId)
                    .HasName("PK_USHolidays");

                entity.HasComment("This table used to store the Holiday details for the office.Employees can easily look up their upcoming holidays use of this section");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EnteredBy).IsUnicode(false);

                entity.Property(e => e.HolidayName).IsUnicode(false);
            });

            modelBuilder.Entity<AddHolidayLog>(entity =>
            {
                entity.HasKey(e => e.AuditId)
                    .HasName("PK__AddHolid__A17F23981DB06A4F");

                entity.HasComment("This table has the information about adding the holidays list.It is used to find the last updated holiday time.");

                entity.Property(e => e.ColumnChanged)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CurrentValue)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PeviousValue)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Album>(entity =>
            {
                entity.HasComment("Album part is used to store the user image details and image path.Each user keep their photos and album in their profile. Users can make a album with their uploaded photos.");

                entity.Property(e => e.AlbumId).HasColumnName("AlbumID");

                entity.Property(e => e.AlbumCoverPhotoPath).HasMaxLength(200);

                entity.Property(e => e.AlbumDescription).HasMaxLength(200);

                entity.Property(e => e.AlbumTitle).HasMaxLength(200);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EventDate).HasColumnType("datetime");
            });

            modelBuilder.Entity<AlbumAccess>(entity =>
            {
                entity.HasComment("Users can give the security to their albums by providing the user id in it. Albums can not open by unauthorised persons.");

                entity.Property(e => e.AlbumAccessId).HasColumnName("AlbumAccessID");

                entity.Property(e => e.AlbumId).HasColumnName("AlbumID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
            });

            modelBuilder.Entity<AlbumPermission>(entity =>
            {
                entity.HasComment("Users album cannot open by the other users and unknown persons. Each albums highly secure by providing some user id");
            });

            modelBuilder.Entity<AlbumPhotos>(entity =>
            {
                entity.HasKey(e => e.AlbumPhotoId)
                    .HasName("PK__AlbumPho__8407D82C54CB950F");

                entity.HasComment("We can see our photos and albums in GALLERY page.This table contains the details of the uploaded image and albums");

                entity.Property(e => e.AlbumPhotoId).HasColumnName("AlbumPhotoID");

                entity.Property(e => e.AlbumId).HasColumnName("AlbumID");

                entity.Property(e => e.AlbumPhotoDescription)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.AlbumPhotoPath)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.AlbumPhotoTitle)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Album)
                    .WithMany(p => p.AlbumPhotos)
                    .HasForeignKey(d => d.AlbumId)
                    .HasConstraintName("FK_AlbumPhotos_Album1");
            });

            modelBuilder.Entity<AllEmpLeaveEntryPermission>(entity =>
            {
                entity.Property(e => e.AllEmpLeaveEntryPermissionId).HasColumnName("AllEmpLeaveEntryPermissionID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.AllEmpLeaveEntryPermission)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__AllEmpLea__UserI__25E8EAF9");
            });

            modelBuilder.Entity<Assessment>(entity =>
            {
                entity.HasComment("Users can see their assessment in Assessment Management Page. This assessment table values is used to store the details in user assessment table. Users can see their assessment details in My Assessment  Part.");

                entity.Property(e => e.AssessmentId).HasColumnName("AssessmentID");

                entity.Property(e => e.AssessmentDate).HasColumnType("datetime");

                entity.Property(e => e.AssessmentDescription)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.AssessmentName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");
            });

            modelBuilder.Entity<AssetType>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.AssetName)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Attachment>(entity =>
            {
                entity.ToTable("Attachment", "Attachment");

                entity.Property(e => e.AttachmentId).ValueGeneratedNever();

                entity.Property(e => e.FileName)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.UploadedDateTime).HasColumnType("datetime");

                entity.HasOne(d => d.AttachmentType)
                    .WithMany(p => p.Attachment)
                    .HasForeignKey(d => d.AttachmentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Attachment_AttachmentTypeId");

                entity.HasOne(d => d.UploadedUser)
                    .WithMany(p => p.Attachment)
                    .HasForeignKey(d => d.UploadedUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Attachment_UploadedUserId");
            });

            modelBuilder.Entity<AttachmentType>(entity =>
            {
                entity.ToTable("AttachmentType", "Attachment");

                entity.Property(e => e.FolderName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<AuditLog>(entity =>
            {
                entity.HasComment("This table contains the details about user log in history and user log out time and user location details.");

                entity.Property(e => e.BrowserVersion).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.IpAddress).HasMaxLength(100);

                entity.Property(e => e.Location)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.LogedInDate).HasColumnType("datetime");

                entity.Property(e => e.LoggedOutDate).HasColumnType("datetime");

                entity.Property(e => e.LoginId)
                    .HasColumnName("LoginID")
                    .HasMaxLength(100);

                entity.Property(e => e.OsVersion).HasMaxLength(50);

                entity.Property(e => e.Roles).HasMaxLength(50);
            });

            modelBuilder.Entity<AuditLog1>(entity =>
            {
                entity.HasKey(e => e.AuditLogId);

                entity.ToTable("AuditLog", "Dev-Ops");

                entity.Property(e => e.AuditLogId).HasDefaultValueSql("(newid())");

                entity.Property(e => e.AuditName).HasMaxLength(500);

                entity.Property(e => e.AuditTypeId).HasColumnName("AuditTypeID");

                entity.Property(e => e.CompletionDateTime).HasColumnType("datetime");

                entity.Property(e => e.CreationDateTime)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");
            });

            modelBuilder.Entity<AuditLoginStatus>(entity =>
            {
                entity.ToTable("Audit_LoginStatus");

                entity.HasComment("This table contains audit_Login Status and the ip address and user browser details.It also contains   logged in time and logged in status.");

                entity.Property(e => e.AuditLoginStatusId).HasColumnName("AuditLoginStatusID");

                entity.Property(e => e.BrowserVersion)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LogedInDate).HasColumnType("datetime");

                entity.Property(e => e.LoginStatusId).HasColumnName("LoginStatusID");

                entity.HasOne(d => d.LoginStatus)
                    .WithMany(p => p.AuditLoginStatus)
                    .HasForeignKey(d => d.LoginStatusId)
                    .HasConstraintName("FK__Audit_Log__Login__5C2D8B0C");
            });

            modelBuilder.Entity<BackEndServiceErrorLog>(entity =>
            {
                entity.Property(e => e.BackEndServiceErrorLogId).HasColumnName("BackEndServiceErrorLogID");

                entity.Property(e => e.Datetime).HasColumnType("datetime");

                entity.Property(e => e.ExceptionMessage)
                    .IsRequired()
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.MethodName)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(2000)
                    .IsUnicode(false);

                entity.Property(e => e.StackTrace)
                    .IsRequired()
                    .HasMaxLength(7000)
                    .IsUnicode(false);

                entity.HasOne(d => d.BackEndServiceLog)
                    .WithMany(p => p.BackEndServiceErrorLog)
                    .HasForeignKey(d => d.BackEndServiceLogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BackEndSe__BackE__3C623BFD");
            });

            modelBuilder.Entity<BackEndServiceLog>(entity =>
            {
                entity.Property(e => e.BackendServiceTypeId).HasColumnName("BackendServiceTypeID");

                entity.Property(e => e.DateTime).HasColumnType("datetime");

                entity.Property(e => e.IdInt).HasColumnName("ID_Int");

                entity.Property(e => e.IdUuniqueidentifier).HasColumnName("ID_Uuniqueidentifier");

                entity.HasOne(d => d.BackendServiceType)
                    .WithMany(p => p.BackEndServiceLog)
                    .HasForeignKey(d => d.BackendServiceTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__BackEndSe__Backe__379D86E0");

                entity.HasOne(d => d.IdUuniqueidentifierNavigation)
                    .WithMany(p => p.BackEndServiceLog)
                    .HasForeignKey(d => d.IdUuniqueidentifier)
                    .HasConstraintName("FK_AuditLog_ID_Uuniqueidentifier");
            });

            modelBuilder.Entity<BookingPurpose>(entity =>
            {
                entity.HasKey(e => e.PurposeId)
                    .HasName("PK__BookingP__79E6A1941A77384D");

                entity.Property(e => e.PurposeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CalendarYear>(entity =>
            {
                entity.HasComment("This table contains the structure for the calendar.It is provide some details about starting month end month details.");
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.HasComment("This part contains all the details about Test Category and its category id.We can see the details in Project Management Part");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<CheckList>(entity =>
            {
                entity.HasComment("Checklist part in Manage Checklist Section.It shows all the category in Project Management Part.");

                entity.Property(e => e.CheckListId).HasColumnName("CheckListID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CheckListName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.CheckList)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__CheckList__Categ__5C050488");
            });

            modelBuilder.Entity<CheckListMapping>(entity =>
            {
                entity.HasComment(@"This mapping section provides all the details about assigned projects 
 for the user.We can see this details in Project Management Part.");

                entity.Property(e => e.CheckListMappingId).HasColumnName("CheckListMapping_ID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.CheckListId).HasColumnName("CheckListID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.CheckListMapping)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__CheckList__Categ__6C9B5F04");

                entity.HasOne(d => d.CheckList)
                    .WithMany(p => p.CheckListMapping)
                    .HasForeignKey(d => d.CheckListId)
                    .HasConstraintName("FK__CheckList__Check__6D8F833D");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.CheckListMapping)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__CheckList__Proje__6E83A776");
            });

            modelBuilder.Entity<CheckUninformedEntryMiss>(entity =>
            {
                entity.HasKey(e => e.Date)
                    .HasName("PK__CheckUni__77387D061A0D23F9");

                entity.Property(e => e.Date).HasColumnType("datetime");
            });

            modelBuilder.Entity<ChildrensInformation>(entity =>
            {
                entity.ToTable("Childrens_Information");

                entity.Property(e => e.ChildDob)
                    .HasColumnName("ChildDOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.ChildName).IsUnicode(false);

                entity.HasOne(d => d.GenderNavigation)
                    .WithMany(p => p.ChildrensInformation)
                    .HasForeignKey(d => d.Gender)
                    .HasConstraintName("FK_Child_Gender");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ChildrensInformation)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_Child_uid");
            });

            modelBuilder.Entity<Communication>(entity =>
            {
                entity.ToTable("Communication", "Mail");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EmailBody)
                    .IsRequired()
                    .HasColumnName("EMailBody")
                    .HasMaxLength(4000);

                entity.Property(e => e.EmailSubject)
                    .IsRequired()
                    .HasColumnName("EMailSubject")
                    .HasMaxLength(2000);

                entity.Property(e => e.ExeculdeUserIdList).HasMaxLength(2000);

                entity.Property(e => e.ScheduledDate).HasColumnType("datetime");

                entity.Property(e => e.SelectedList).HasMaxLength(2000);

                entity.Property(e => e.SendByUserId).HasColumnName("SendByUserID");

                entity.HasOne(d => d.SendByUser)
                    .WithMany(p => p.Communication)
                    .HasForeignKey(d => d.SendByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mail_SendByUserID");
            });

            modelBuilder.Entity<CommunicationAttachment>(entity =>
            {
                entity.ToTable("CommunicationAttachment", "Mail");

                entity.HasOne(d => d.Attachment)
                    .WithMany(p => p.CommunicationAttachment)
                    .HasForeignKey(d => d.AttachmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mail_AttachmentId");

                entity.HasOne(d => d.Communication)
                    .WithMany(p => p.CommunicationAttachment)
                    .HasForeignKey(d => d.CommunicationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Mail_CommunicationId");
            });

            modelBuilder.Entity<CommunicationEmailLog>(entity =>
            {
                entity.HasKey(e => e.CommunicationEmailLog1)
                    .HasName("PK__Communic__F09350F20DA74D14");

                entity.Property(e => e.CommunicationEmailLog1).HasColumnName("CommunicationEmailLog");

                entity.Property(e => e.Body)
                    .IsRequired()
                    .HasColumnName("body");

                entity.Property(e => e.CommunicationId).HasColumnName("CommunicationID");

                entity.Property(e => e.DeliveredDate).HasColumnType("datetime");

                entity.Property(e => e.InsertedDate).HasColumnType("datetime");

                entity.Property(e => e.MailDroppedEmployeeName).HasMaxLength(500);

                entity.Property(e => e.Subject)
                    .IsRequired()
                    .HasColumnName("subject");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.CommunicationEmailLog)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_CommunicationEmailLog_UserId");
            });

            modelBuilder.Entity<Compoffmail>(entity =>
            {
                entity.HasKey(e => e.CompId)
                    .HasName("prcomp");

                entity.ToTable("compoffmail");

                entity.Property(e => e.FilePath).IsUnicode(false);

                entity.Property(e => e.Fname).IsUnicode(false);

                entity.Property(e => e.LeaveRequestId)
                    .HasColumnName("LeaveRequestID")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ComputerAssigned>(entity =>
            {
                entity.HasKey(e => e.Assignid)
                    .HasName("PK__Computer__9FFC40C75D2BD0E6");

                entity.HasComment("This table contain all the details about assigned computers and other Pen drive details.It is used in Asset Management Page");

                entity.Property(e => e.ComponentId)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExtraDevices)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.InsertedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Isdelete).HasColumnName("ISDelete");

                entity.Property(e => e.LastEditedby)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PendriveAccess)
                    .HasColumnName("pendriveAccess")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.PendriveAccessnew)
                    .HasColumnName("pendriveAccessnew")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Upsid)
                    .HasColumnName("UPSID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.WorkStation)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Computermanagement>(entity =>
            {
                entity.HasKey(e => e.Managementid)
                    .HasName("PK__computer__51D3B789778AC167");

                entity.ToTable("computermanagement");

                entity.HasComment("This part has all the assigned computer properties,memory details,os version in the Manage Computers page inside the Asset Management page.");

                entity.Property(e => e.Managementid).HasColumnName("managementid");

                entity.Property(e => e.ComputerName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ComputerStatus).HasDefaultValueSql("((0))");

                entity.Property(e => e.ComputerStatusNew)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Cpu)
                    .HasColumnName("cpu")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Cpuid)
                    .HasColumnName("CPUID")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.DeletedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.InsertedBy)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Ip)
                    .HasColumnName("IP")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Isdelete)
                    .HasColumnName("ISDelete")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LastEditedby)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Manufacturer)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Memory)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.MonitorId)
                    .HasColumnName("MonitorID")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Os)
                    .HasColumnName("OS")
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ConferenceRoom>(entity =>
            {
                entity.HasKey(e => e.ConferenceId)
                    .HasName("PK__Conferen__4A95F5735F56727F");

                entity.Property(e => e.Attendees).IsUnicode(false);

                entity.Property(e => e.BookingDate).HasColumnType("datetime");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.EndTime)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FkDepartmentId)
                    .HasColumnName("fk_DepartmentId")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.FkFloorId).HasColumnName("fk_FloorId");

                entity.Property(e => e.FkUserId).HasColumnName("fk_UserId");

                entity.Property(e => e.StartTime)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.FkFloor)
                    .WithMany(p => p.ConferenceRoom)
                    .HasForeignKey(d => d.FkFloorId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Conferenc__fk_Fl__6232DF2A");

                entity.HasOne(d => d.FkUser)
                    .WithMany(p => p.ConferenceRoom)
                    .HasForeignKey(d => d.FkUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Conferenc__fk_Us__63270363");
            });

            modelBuilder.Entity<ConfirmationFeedback>(entity =>
            {
                entity.HasKey(e => e.FeedbackId)
                    .HasName("PK__Confirma__6A4BEDF622D77424");

                entity.ToTable("Confirmation_Feedback");

                entity.Property(e => e.FeedbackId).HasColumnName("FeedbackID");

                entity.Property(e => e.Appreciation).HasColumnName("appreciation");

                entity.Property(e => e.ClientCordination).HasColumnName("Client_Cordination");

                entity.Property(e => e.ExtendedDate).HasColumnType("datetime");

                entity.Property(e => e.FeedbackLater).HasColumnName("Feedback_Later");

                entity.Property(e => e.FeedbackNow).HasColumnName("Feedback_Now");

                entity.Property(e => e.FeedbackPopUp).HasColumnName("Feedback_PopUp");

                entity.Property(e => e.OtherComments).HasColumnName("Other_Comments");

                entity.Property(e => e.ReportingUserId).HasColumnName("Reporting_UserID");

                entity.Property(e => e.TeamCordination).HasColumnName("Team_Cordination");

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("Updated_Date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<ConfirmationRating>(entity =>
            {
                entity.HasKey(e => e.RatingId)
                    .HasName("PK__Confirma__FCCDF85C26A80508");

                entity.ToTable("Confirmation_Rating");

                entity.Property(e => e.RatingId).HasColumnName("RatingID");
            });

            modelBuilder.Entity<ContactDetails>(entity =>
            {
                entity.HasKey(e => e.ContactDetailId)
                    .HasName("PK__Contact___AD92658A2A438BC2");

                entity.ToTable("Contact_Details");

                entity.Property(e => e.ContactDetailId).HasColumnName("Contact_DetailId");

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.NearestExtension).HasColumnName("Nearest_Extension");

                entity.Property(e => e.PurposeDescription)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<DataBaseValues>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DatabaseToolsId).HasColumnName("Database_Tools_ID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.HasOne(d => d.DatabaseTools)
                    .WithMany(p => p.DataBaseValues)
                    .HasForeignKey(d => d.DatabaseToolsId)
                    .HasConstraintName("FK_DataBaseValues_DataBaseTechnolgy");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.DataBaseValues)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_DataBaseValues_Projects");
            });

            modelBuilder.Entity<DatabaseAccessDetail>(entity =>
            {
                entity.ToTable("DatabaseAccessDetail", "Project");

                entity.Property(e => e.Createddate).HasColumnType("datetime");

                entity.HasOne(d => d.DatabaseReport)
                    .WithMany(p => p.DatabaseAccessDetail)
                    .HasForeignKey(d => d.DatabaseReportId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_DatabaseReport");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.DatabaseAccessDetail)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserId");
            });

            modelBuilder.Entity<DatabaseReport>(entity =>
            {
                entity.ToTable("DatabaseReport", "Project");

                entity.Property(e => e.DatabaseName)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ServerName)
                    .IsRequired()
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.DatabaseReport)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectID");
            });

            modelBuilder.Entity<DefaultAlbumUser>(entity =>
            {
                entity.HasKey(e => e.AccessId)
                    .HasName("PK__DefaultA__4130D0BF01142BA1");

                entity.HasComment("It contains all the album details and each album user id details.");

                entity.Property(e => e.AccessId).HasColumnName("AccessID");

                entity.Property(e => e.AlbumId).HasColumnName("AlbumID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<DefaultFunctionPrecedanceOrder>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FunctionId).HasColumnName("FunctionID");

                entity.Property(e => e.PreceedingId).HasColumnName("PreceedingID");
            });

            modelBuilder.Entity<DefaultModulePrecedanceOrder>(entity =>
            {
                entity.HasKey(e => e.SubPreceedingId)
                    .HasName("pk_DefaultModulePrecedanceOrder_SubpreceedingID");

                entity.HasComment("It contains the sub preceeding details and page module details.");

                entity.Property(e => e.SubPreceedingId).HasColumnName("SubPreceedingID");

                entity.Property(e => e.PageModuleId).HasColumnName("PageModuleID");
            });

            modelBuilder.Entity<DeliveryManagers>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.EmpId).HasColumnName("EmpID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.HasComment("It contains all department name and id and its active status.");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.DepartmentName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.UnderDevelopment).HasColumnName("Under_Development");
            });

            modelBuilder.Entity<DepartmentGroup>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .HasName("PK__Departme__149AF30A116A8EFB");

                entity.HasComment("Each department has its number of groups.We can see that departments while adding the new employee.");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.Property(e => e.GroupName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<DepartmentGroupMapping>(entity =>
            {
                entity.HasKey(e => e.GroupMappingId)
                    .HasName("PK__Departme__99F4FAEE162F4418");

                entity.HasComment("It has the details about the departments and its group infromation");

                entity.Property(e => e.GroupMappingId).HasColumnName("GroupMappingID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.GroupId).HasColumnName("GroupID");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.DepartmentGroupMapping)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_DepartmentGroupMapping_Master_Department");

                entity.HasOne(d => d.Group)
                    .WithMany(p => p.DepartmentGroupMapping)
                    .HasForeignKey(d => d.GroupId)
                    .HasConstraintName("FK_DepartmentGroupMapping_DepartmentGroup");
            });

            modelBuilder.Entity<DeviceManagement>(entity =>
            {
                entity.HasKey(e => e.DeviceId)
                    .HasName("PK_DeviceId");

                entity.HasIndex(e => e.DeviceName)
                    .HasName("UC_DeviceName")
                    .IsUnique();

                entity.Property(e => e.AssignedOn).HasColumnType("datetime");

                entity.Property(e => e.DeviceDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DeviceName)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.Model)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.TrackingId)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Dictionary>(entity =>
            {
                entity.HasComment("Dictionary contains the present departments name and its previous name.");

                entity.Property(e => e.Name).HasMaxLength(50);

                entity.Property(e => e.PreviousName)
                    .HasColumnName("Previous Name")
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<EmailPurpose>(entity =>
            {
                entity.HasNoKey();

                entity.HasComment(@"It has the information for all the email functions and its purposes. Email functions used in many process.
Its used in Administration Setup Page.");

                entity.Property(e => e.Bcc)
                    .HasColumnName("BCC")
                    .IsUnicode(false);

                entity.Property(e => e.Cc)
                    .HasColumnName("CC")
                    .IsUnicode(false);

                entity.Property(e => e.EmailPurposeId)
                    .HasColumnName("EmailPurposeID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.EmailPurposeName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmailTemplateCategoryId).HasColumnName("EmailTemplateCategoryID");

                entity.Property(e => e.EmailTemplateId).HasColumnName("EmailTemplateID");

                entity.Property(e => e.Subject)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.To)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmailPurposeLog>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.Content)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Datetimestamp).HasColumnType("datetime");

                entity.Property(e => e.EmailPurposeId).HasColumnName("EmailPurposeID");

                entity.Property(e => e.LogId).HasColumnName("LogID");

                entity.Property(e => e.ParameterChanges)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedUserId).HasColumnName("UpdatedUserID");
            });

            modelBuilder.Entity<EmailTemplate>(entity =>
            {
                entity.HasComment("It contains the information for the email templates and its location details.Each template used for specific purposes.Its used in Administration Setup Page.");

                entity.Property(e => e.EmailTemplateId).HasColumnName("EmailTemplateID");

                entity.Property(e => e.ModuleName).IsUnicode(false);

                entity.Property(e => e.TemplatePath)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TemplatePurpose)
                    .IsRequired()
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EmployeeEditedDetails>(entity =>
            {
                entity.Property(e => e.FieldsAccessed).HasMaxLength(1000);

                entity.Property(e => e.LastAccessedDate).HasColumnType("datetime");

                entity.HasOne(d => d.LastAccessedByNavigation)
                    .WithMany(p => p.EmployeeEditedDetails)
                    .HasForeignKey(d => d.LastAccessedBy)
                    .HasConstraintName("FK__EmployeeE__LastA__735D6B2C");
            });

            modelBuilder.Entity<EmployeeFeedbackQuestionAnswer>(entity =>
            {
                entity.ToTable("EmployeeFeedbackQuestionAnswer", "EmployeeFeedback");

                entity.Property(e => e.EmployeeFeedbackQuestionAnswerId).HasColumnName("EmployeeFeedbackQuestionAnswerID");

                entity.Property(e => e.AnsweredByUserId).HasColumnName("Answered_ByUserID");

                entity.Property(e => e.EmployeeRatingId).HasColumnName("EmployeeRatingID");

                entity.Property(e => e.FeedbackDate).HasColumnType("datetime");

                entity.Property(e => e.FeedbackQuestionId).HasColumnName("FeedbackQuestionID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.AnsweredByUser)
                    .WithMany(p => p.EmployeeFeedbackQuestionAnswerAnsweredByUser)
                    .HasForeignKey(d => d.AnsweredByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmployeeF__Answe__7A5F6E76");

                entity.HasOne(d => d.EmployeeRating)
                    .WithMany(p => p.EmployeeFeedbackQuestionAnswer)
                    .HasForeignKey(d => d.EmployeeRatingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmployeeF__Emplo__7B5392AF");

                entity.HasOne(d => d.FeedbackQuestion)
                    .WithMany(p => p.EmployeeFeedbackQuestionAnswer)
                    .HasForeignKey(d => d.FeedbackQuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmployeeF__Feedb__7C47B6E8");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.EmployeeFeedbackQuestionAnswerUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmployeeF__UserI__796B4A3D");
            });

            modelBuilder.Entity<EmployeeGoalProgress>(entity =>
            {
                entity.HasKey(e => e.EmployeeGoalProgress1)
                    .HasName("PK__Employee__B6DA3F4204DCFCE9");

                entity.ToTable("EmployeeGoalProgress", "EmployeeFeedback");

                entity.Property(e => e.EmployeeGoalProgress1).HasColumnName("EmployeeGoalProgress");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.EmployeeGoalId).HasColumnName("EmployeeGoalID");

                entity.Property(e => e.GoalComments).HasMaxLength(500);

                entity.HasOne(d => d.EmployeeGoal)
                    .WithMany(p => p.EmployeeGoalProgress)
                    .HasForeignKey(d => d.EmployeeGoalId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmployeeG__Emplo__06C5455B");
            });

            modelBuilder.Entity<EmployeeGoals>(entity =>
            {
                entity.HasKey(e => e.EmployeeGoalId)
                    .HasName("PK__Employee__092BD92B7F242393");

                entity.ToTable("EmployeeGoals", "EmployeeFeedback");

                entity.Property(e => e.EmployeeGoalId).HasColumnName("EmployeeGoalID");

                entity.Property(e => e.GoalCreatedDate).HasColumnType("datetime");

                entity.Property(e => e.GoalDescription).IsRequired();

                entity.Property(e => e.GoalEndDate).HasColumnType("datetime");

                entity.Property(e => e.GoalName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.GoalSetByUserId).HasColumnName("GoalSet_ByUserID");

                entity.Property(e => e.GoalStartDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.GoalSetByUser)
                    .WithMany(p => p.EmployeeGoalsGoalSetByUser)
                    .HasForeignKey(d => d.GoalSetByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmployeeG__GoalS__0200903E");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.EmployeeGoalsUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmployeeG__UserI__010C6C05");
            });

            modelBuilder.Entity<EmployeeRating>(entity =>
            {
                entity.ToTable("EmployeeRating", "EmployeeFeedback");

                entity.Property(e => e.EmployeeRatingId).HasColumnName("EmployeeRatingID");

                entity.Property(e => e.FeedbackDate).HasColumnType("datetime");

                entity.Property(e => e.OverAllComments).IsRequired();

                entity.Property(e => e.OverAllRating).HasMaxLength(2000);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.RatedByUserId).HasColumnName("Rated_ByUserID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.RatedByUser)
                    .WithMany(p => p.EmployeeRatingRatedByUser)
                    .HasForeignKey(d => d.RatedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmployeeR__Rated__6840BE3B");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.EmployeeRatingUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmployeeR__Feedb__674C9A02");
            });

            modelBuilder.Entity<EmployeeRatingDetail>(entity =>
            {
                entity.ToTable("EmployeeRatingDetail", "EmployeeFeedback");

                entity.Property(e => e.EmployeeRatingDetailId).HasColumnName("EmployeeRatingDetailID");

                entity.Property(e => e.EmployeeRatingId).HasColumnName("EmployeeRatingID");

                entity.Property(e => e.RatingCriteriaId).HasColumnName("RatingCriteriaID");

                entity.Property(e => e.RatingValue).HasMaxLength(2000);

                entity.HasOne(d => d.EmployeeRating)
                    .WithMany(p => p.EmployeeRatingDetail)
                    .HasForeignKey(d => d.EmployeeRatingId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmployeeR__Emplo__6D057358");

                entity.HasOne(d => d.RatingCriteria)
                    .WithMany(p => p.EmployeeRatingDetail)
                    .HasForeignKey(d => d.RatingCriteriaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmployeeR__Ratin__6DF99791");
            });

            modelBuilder.Entity<EmployeeRecognition>(entity =>
            {
                entity.ToTable("EmployeeRecognition", "EmployeeFeedback");

                entity.Property(e => e.EmployeeRecognitionId).HasColumnName("EmployeeRecognitionID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.RecognisedByUserId).HasColumnName("Recognised_ByUserID");

                entity.Property(e => e.RecognisedDate).HasColumnType("datetime");

                entity.Property(e => e.RecognitionId).HasColumnName("RecognitionID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.RecognisedByUser)
                    .WithMany(p => p.EmployeeRecognitionRecognisedByUser)
                    .HasForeignKey(d => d.RecognisedByUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmployeeR__Recog__73B270E7");

                entity.HasOne(d => d.Recognition)
                    .WithMany(p => p.EmployeeRecognition)
                    .HasForeignKey(d => d.RecognitionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmployeeR__Recog__74A69520");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.EmployeeRecognitionUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__EmployeeR__UserI__72BE4CAE");
            });

            modelBuilder.Entity<EmployeeRevokeEmailLog>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.LastworkingDate)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasColumnName("UserID")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<EngineerContactDetails>(entity =>
            {
                entity.HasKey(e => e.ContactId)
                    .HasName("PK__Engineer__5C66259B2672FADE");

                entity.ToTable("EngineerContact_Details");

                entity.Property(e => e.DutyTime)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmailAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.NearestExtension).HasColumnName("Nearest_Extension");

                entity.Property(e => e.ShiftDetails)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<ExceptionLog>(entity =>
            {
                entity.HasComment("It contains all the exception details and exception message.");

                entity.Property(e => e.ExceptionDate).HasColumnType("datetime");

                entity.Property(e => e.ExceptionMessage)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.MethodName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Source)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.StackTrace)
                    .IsRequired()
                    .HasMaxLength(7000)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<Expenditure>(entity =>
            {
                entity.HasKey(e => e.ExpenseId)
                    .HasName("PK__Expendit__1445CFF306CD04F7");

                entity.HasComment("It has the expense description and expense created time.");

                entity.Property(e => e.ExpenseId).HasColumnName("ExpenseID");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.ExpenseDate).HasColumnType("datetime");

                entity.Property(e => e.ExpenseDescription).IsUnicode(false);
            });

            modelBuilder.Entity<Experiances>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.F10).HasMaxLength(255);

                entity.Property(e => e.F3).HasColumnType("datetime");

                entity.Property(e => e.F4).HasMaxLength(255);

                entity.Property(e => e.F5).HasMaxLength(255);

                entity.Property(e => e.F6).HasMaxLength(255);

                entity.Property(e => e.F7).HasMaxLength(255);
            });

            modelBuilder.Entity<FeedbackAttachment>(entity =>
            {
                entity.ToTable("FeedbackAttachment", "Feedback");

                entity.HasOne(d => d.Attachment)
                    .WithMany(p => p.FeedbackAttachment)
                    .HasForeignKey(d => d.AttachmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Attachment_AttachmentTypeId");

                entity.HasOne(d => d.Feedback)
                    .WithMany(p => p.FeedbackAttachment)
                    .HasForeignKey(d => d.FeedbackId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Feedback_FeedbackId");
            });

            modelBuilder.Entity<FeedbackComments>(entity =>
            {
                entity.ToTable("FeedbackComments", "Feedback");

                entity.Property(e => e.CommentedDatetime).HasColumnType("datetime");

                entity.Property(e => e.Comments)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.HasOne(d => d.CommentedbyUser)
                    .WithMany(p => p.FeedbackComments)
                    .HasForeignKey(d => d.CommentedbyUserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Feedback_CommentedbyUserId");

                entity.HasOne(d => d.UserFeedback)
                    .WithMany(p => p.FeedbackComments)
                    .HasForeignKey(d => d.UserFeedbackId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Feedback_UserFeedbackCommentId");
            });

            modelBuilder.Entity<FileUploads>(entity =>
            {
                entity.HasKey(e => e.FileId)
                    .HasName("Files");

                entity.Property(e => e.FilePath).IsUnicode(false);

                entity.Property(e => e.Fname).IsUnicode(false);

                entity.Property(e => e.Purpose)
                    .HasMaxLength(1000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<FunctionModules>(entity =>
            {
                entity.HasKey(e => e.FunctionModuleId)
                    .HasName("pk_FunctionModules_FunctionModuleID");

                entity.HasComment("It has the function modules and page modules id information.");

                entity.Property(e => e.FunctionModuleId).HasColumnName("FunctionModuleID");

                entity.Property(e => e.FunctionId).HasColumnName("FunctionID");

                entity.Property(e => e.PageModuleId).HasColumnName("PageModuleID");

                entity.HasOne(d => d.Function)
                    .WithMany(p => p.FunctionModules)
                    .HasForeignKey(d => d.FunctionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_FunctionModules_FunctionId__Functions_FunctionId");

                entity.HasOne(d => d.PageModule)
                    .WithMany(p => p.FunctionModules)
                    .HasForeignKey(d => d.PageModuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("fk_FunctionModules_PageModuleId__Modules_PageModuleId");
            });

            modelBuilder.Entity<FunctionPrecedanceOrder>(entity =>
            {
                entity.HasKey(e => e.PreceedingId);

                entity.HasComment("It has each function precedance order details and role details.");

                entity.Property(e => e.PreceedingId).HasColumnName("PreceedingID");

                entity.Property(e => e.FunctionId).HasColumnName("FunctionID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Function)
                    .WithMany(p => p.FunctionPrecedanceOrder)
                    .HasForeignKey(d => d.FunctionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FunctionPrecedanceOrder_FunctionPrecedanceOrder");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.FunctionPrecedanceOrder)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_FunctionPrecedanceOrder_Roles");
            });

            modelBuilder.Entity<Functions>(entity =>
            {
                entity.HasKey(e => e.FunctionId);

                entity.HasComment("It has the function details and its description and active status.");

                entity.Property(e => e.FunctionId)
                    .HasColumnName("FunctionID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FunctionDescription).HasMaxLength(100);

                entity.Property(e => e.FunctionName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.Style).HasMaxLength(150);
            });

            modelBuilder.Entity<GetClientVisitForm>(entity =>
            {
                entity.Property(e => e.Address)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Client)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ClientCompany)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.ClientMailId).IsUnicode(false);

                entity.Property(e => e.EmpId)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.EndDate)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.PurposeOfVisit)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.StartDate)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.UserName)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<GitAccessDetail>(entity =>
            {
                entity.ToTable("GitAccessDetail", "Project");

                entity.Property(e => e.Createddate).HasColumnType("datetime");

                entity.HasOne(d => d.SourceCodeRepo)
                    .WithMany(p => p.GitAccessDetail)
                    .HasForeignKey(d => d.SourceCodeRepoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GitAccessDetail_SourceCodeRepoId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.GitAccessDetail)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_GitAccessDetail_UserId");
            });

            modelBuilder.Entity<IncidentDepartment>(entity =>
            {
                entity.HasKey(e => e.DeptId)
                    .HasName("PK__Incident__014881AE76C3E7BC");

                entity.ToTable("Incident_Department");

                entity.Property(e => e.DeptName)
                    .IsRequired()
                    .HasMaxLength(5000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IncidentManagement>(entity =>
            {
                entity.HasKey(e => e.IncidentId)
                    .HasName("PK__Incident__3D8053B272F356D8");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(5000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<IncidentManagementHistory>(entity =>
            {
                entity.HasKey(e => e.HistoryId)
                    .HasName("PK__Incident__4D7B4ABD7A9478A0");

                entity.Property(e => e.ImpactOccured)
                    .HasColumnName("Impact_Occured")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.PreviousDepartmentId).HasColumnName("Previous_DepartmentId");

                entity.Property(e => e.ProcessedDate).HasColumnType("datetime");

                entity.Property(e => e.ReassignedBy).HasColumnName("Reassigned_By");

                entity.Property(e => e.ReassignedDate).HasColumnType("datetime");

                entity.Property(e => e.ResolutionTaken)
                    .HasColumnName("Resolution_Taken")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.HasOne(d => d.Incident)
                    .WithMany(p => p.IncidentManagementHistory)
                    .HasForeignKey(d => d.IncidentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__IncidentM__Incid__7C7CC112");

                entity.HasOne(d => d.ResponsibleDepartment)
                    .WithMany(p => p.IncidentManagementHistory)
                    .HasForeignKey(d => d.ResponsibleDepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__IncidentM__Respo__7D70E54B");
            });

            modelBuilder.Entity<IncidentPriority>(entity =>
            {
                entity.ToTable("Incident_Priority");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(5000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Income>(entity =>
            {
                entity.HasComment("It contains the user income details,income amount,income date.Its used in Accounts Management Page.");

                entity.Property(e => e.IncomeId).HasColumnName("IncomeID");

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.IncomeDate).HasColumnType("datetime");

                entity.Property(e => e.IncomeDescription).IsUnicode(false);
            });

            modelBuilder.Entity<InterviewSkillsRating>(entity =>
            {
                entity.Property(e => e.Experiance)
                    .HasColumnName("experiance")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.TechnologyId).HasColumnName("TechnologyID");

                entity.Property(e => e.UpdatedDate).HasColumnType("datetime");

                entity.HasOne(d => d.SpecializationNavigation)
                    .WithMany(p => p.InterviewSkillsRating)
                    .HasForeignKey(d => d.Specialization)
                    .HasConstraintName("FK__InterviewSkills__Speciali__4C214075");

                entity.HasOne(d => d.Technology)
                    .WithMany(p => p.InterviewSkillsRating)
                    .HasForeignKey(d => d.TechnologyId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__InterviewSkills__Tech__4C214075");
            });

            modelBuilder.Entity<ItRequestSoftHardItems>(entity =>
            {
                entity.ToTable("IT_Request_SoftHardItems");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SoftHardName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ItTrackMail>(entity =>
            {
                entity.HasKey(e => e.ItrequestId)
                    .HasName("PK__IT_Track__61C1D6F84FAA1A9B");

                entity.ToTable("IT_TrackMail");

                entity.Property(e => e.ItrequestId)
                    .HasColumnName("ITRequestID")
                    .ValueGeneratedNever();

                entity.Property(e => e.IsEngineerTeam).HasColumnName("Is_EngineerTeam");

                entity.Property(e => e.IsGitaccess).HasColumnName("Is_GITAccess");

                entity.Property(e => e.IsIthead).HasColumnName("Is_ITHead");

                entity.Property(e => e.IsMachineMovement).HasColumnName("Is_MachineMovement");

                entity.Property(e => e.IsReportingApproval).HasColumnName("Is_ReportingApproval");

                entity.Property(e => e.IsReportingMail).HasColumnName("Is_ReportingMail");

                entity.Property(e => e.IsRequestClose).HasColumnName("Is_RequestClose");

                entity.Property(e => e.IsRequestRejected).HasColumnName("Is_RequestRejected");

                entity.Property(e => e.IsRequestRevoke).HasColumnName("Is_RequestRevoke");
            });

            modelBuilder.Entity<ItreopenHistory>(entity =>
            {
                entity.HasKey(e => e.ItreopenId)
                    .HasName("PK__ITReopen__D6C83C0E22A269FA");

                entity.ToTable("ITReopenHistory");

                entity.Property(e => e.ItreopenId).HasColumnName("ITReopenId");

                entity.Property(e => e.AssignedOn).HasColumnType("datetime");

                entity.Property(e => e.Closedon).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.FromIsActive).HasColumnName("From_IsActive");

                entity.Property(e => e.GitCategory).HasColumnName("GIT_Category");

                entity.Property(e => e.GitClosedComments).HasColumnName("GIT_ClosedComments");

                entity.Property(e => e.HardSoftVersion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ItRevoke).HasColumnName("IT_Revoke");

                entity.Property(e => e.ItRevokedDate)
                    .HasColumnName("IT_RevokedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ItrequestHistoryId).HasColumnName("ITRequestHistoryId");

                entity.Property(e => e.ItrequestId).HasColumnName("ITRequestId");

                entity.Property(e => e.ProcessedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.RequestedDate).HasColumnType("datetime");

                entity.Property(e => e.RequestedUserId).HasColumnName("RequestedUserID");

                entity.Property(e => e.SoftHardId).HasColumnName("SoftHardID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.StatusIdHistory).HasColumnName("StatusId_History");

                entity.Property(e => e.ToIsActive).HasColumnName("To_IsActive");
            });

            modelBuilder.Entity<Itrequest>(entity =>
            {
                entity.ToTable("ITRequest");

                entity.Property(e => e.ItrequestId).HasColumnName("ITRequestId");

                entity.Property(e => e.DnsName)
                    .HasColumnName("DNS_Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ExtPort)
                    .HasColumnName("Ext_Port")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalIpaddress)
                    .HasColumnName("External_IPAddress")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FileUploadPath).IsUnicode(false);

                entity.Property(e => e.GitCategory).HasColumnName("GIT_Category");

                entity.Property(e => e.GitClosedComments).HasColumnName("GIT_ClosedComments");

                entity.Property(e => e.HardSoftVersion)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.HostName)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.ItRevoke).HasColumnName("IT_Revoke");

                entity.Property(e => e.ItRevokedDate)
                    .HasColumnName("IT_RevokedDate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProcessedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ReopenReason)
                    .HasColumnName("Reopen_Reason")
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.RequestedDate).HasColumnType("datetime");

                entity.Property(e => e.RequestedUserId).HasColumnName("RequestedUserID");

                entity.Property(e => e.SoftHardId).HasColumnName("SoftHardID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UploadedFileName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.UserClosedComments).HasMaxLength(2000);

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.Itrequest)
                    .HasForeignKey(d => d.Categoryid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ITRequest__Categ__79D55E91");

                entity.HasOne(d => d.Priority)
                    .WithMany(p => p.Itrequest)
                    .HasForeignKey(d => d.Priorityid)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ITRequest__Prior__7AC982CA");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Itrequest)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ITRequest__Statu__7BBDA703");
            });

            modelBuilder.Entity<ItrequestAttachment>(entity =>
            {
                entity.ToTable("ITRequestAttachment");

                entity.Property(e => e.ItrequestAttachmentId).HasColumnName("ITRequestAttachmentId");

                entity.Property(e => e.ItrequestAttachmentTypeId).HasColumnName("ITRequestAttachmentTypeId");

                entity.Property(e => e.ItrequestId).HasColumnName("ITRequestId");

                entity.HasOne(d => d.Attachment)
                    .WithMany(p => p.ItrequestAttachment)
                    .HasForeignKey(d => d.AttachmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ITRequest_AttachmentId");

                entity.HasOne(d => d.ItrequestAttachmentType)
                    .WithMany(p => p.ItrequestAttachment)
                    .HasForeignKey(d => d.ItrequestAttachmentTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ITRequest_ITRequestAttachmentTypeId");

                entity.HasOne(d => d.Itrequest)
                    .WithMany(p => p.ItrequestAttachment)
                    .HasForeignKey(d => d.ItrequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ITRequest_ITRequestId");
            });

            modelBuilder.Entity<ItrequestHistory>(entity =>
            {
                entity.ToTable("ITRequestHistory");

                entity.Property(e => e.ItrequestHistoryId).HasColumnName("ITRequestHistoryId");

                entity.Property(e => e.AssignedOn).HasColumnType("datetime");

                entity.Property(e => e.Closedon).HasColumnType("datetime");

                entity.Property(e => e.FromIsActive).HasColumnName("From_IsActive");

                entity.Property(e => e.ItrequestId).HasColumnName("ITRequestId");

                entity.Property(e => e.ToIsActive).HasColumnName("To_IsActive");

                entity.HasOne(d => d.Itrequest)
                    .WithMany(p => p.ItrequestHistory)
                    .HasForeignKey(d => d.ItrequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ITRequest__ITReq__00825C20");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.ItrequestHistory)
                    .HasForeignKey(d => d.StatusId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ITRequest__Statu__01768059");
            });

            modelBuilder.Entity<ItrequestUserComments>(entity =>
            {
                entity.ToTable("ITRequestUserComments");

                entity.Property(e => e.Comments).HasMaxLength(2000);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.ItrequestId).HasColumnName("ITRequestID");

                entity.Property(e => e.UpdateDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Itrequest)
                    .WithMany(p => p.ItrequestUserComments)
                    .HasForeignKey(d => d.ItrequestId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ITRequest__ITReq__1765C178");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ItrequestUserComments)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ITRequest__UserI__16719D3F");
            });

            modelBuilder.Entity<LeaveBalanceCount>(entity =>
            {
                entity.HasComment("It has the user leave details and leave types.Its used in Leave Management Page.");

                entity.HasOne(d => d.LeaveType)
                    .WithMany(p => p.LeaveBalanceCount)
                    .HasForeignKey(d => d.LeaveTypeId)
                    .HasConstraintName("FK_LeaveBalanceCount_LeaveType");
            });

            modelBuilder.Entity<LeaveRequest>(entity =>
            {
                entity.HasComment("It contains the full information for all the user leave request and their leave reasons.Its used in Leave Management Page.");

                entity.HasIndex(e => new { e.UserId, e.LeaveTypeId, e.LeaveStatusId })
                    .HasName("NCI_LeaveRequest_UserIdLeaveTypeIdLeaveStatusId");

                entity.HasIndex(e => new { e.UserId, e.StartDateTime, e.EndDateTime, e.LeaveStatusId })
                    .HasName("NCI_LeaveRequest_LeaveStatusId");

                entity.Property(e => e.ClientMailLocation).IsUnicode(false);

                entity.Property(e => e.Comments).HasMaxLength(250);

                entity.Property(e => e.Details).HasMaxLength(250);

                entity.Property(e => e.EndDateTime).HasColumnType("datetime");

                entity.Property(e => e.Lop).HasColumnName("LOP");

                entity.Property(e => e.ProcessedOn).HasColumnType("datetime");

                entity.Property(e => e.ReportingHrid).HasColumnName("ReportingHRID");

                entity.Property(e => e.ReportingMarketingId).HasColumnName("ReportingMarketingID");

                entity.Property(e => e.RequestedDate).HasColumnType("datetime");

                entity.Property(e => e.StartDateTime).HasColumnType("datetime");

                entity.Property(e => e.WorkedDate).IsUnicode(false);

                entity.HasOne(d => d.LeaveStatus)
                    .WithMany(p => p.LeaveRequest)
                    .HasForeignKey(d => d.LeaveStatusId)
                    .HasConstraintName("FK_LeaveRequest_LeaveStatus");

                entity.HasOne(d => d.LeaveType)
                    .WithMany(p => p.LeaveRequest)
                    .HasForeignKey(d => d.LeaveTypeId)
                    .HasConstraintName("FK_LeaveRequest_LeaveType");

                entity.HasOne(d => d.ProcessedByNavigation)
                    .WithMany(p => p.LeaveRequestProcessedByNavigation)
                    .HasForeignKey(d => d.ProcessedBy)
                    .HasConstraintName("FK_LeaveRequest_ProcessedBy");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.LeaveRequestUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LeaveRequest_User");
            });

            modelBuilder.Entity<LeaveType>(entity =>
            {
                entity.HasComment("There are some leave types available for all users.It contains the leave types details.Its used in Leave Management Page.");

                entity.Property(e => e.LeaveTypeId).ValueGeneratedOnAdd();

                entity.Property(e => e.ApplicableEmployees).HasMaxLength(6);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<Location>(entity =>
            {
                entity.ToTable("location");

                entity.HasComment("It has the information for the user location details.");

                entity.Property(e => e.Locationid)
                    .HasColumnName("locationid")
                    .ValueGeneratedNever();

                entity.Property(e => e.LocationName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<ManageTab>(entity =>
            {
                entity.HasComment("It contains user tab details and its active status.");

                entity.Property(e => e.ManageTabId).HasColumnName("ManageTabID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.TabId).HasColumnName("TabID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.ManageTab)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__ManageTab__RoleI__5A9A4855");

                entity.HasOne(d => d.Tab)
                    .WithMany(p => p.ManageTab)
                    .HasForeignKey(d => d.TabId)
                    .HasConstraintName("FK__ManageTab__TabID__58B1FFE3");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ManageTab)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__ManageTab__UserI__59A6241C");
            });

            modelBuilder.Entity<ManageTabGrids>(entity =>
            {
                entity.HasKey(e => e.ManageGridId)
                    .HasName("PK__ManageTa__FD05C9E95B7007AB");

                entity.HasComment("It has the grid details and managed grid id details.");

                entity.Property(e => e.ManageGridId).HasColumnName("ManageGridID");

                entity.Property(e => e.GridId).HasColumnName("GridID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<MasterApplicationSettings>(entity =>
            {
                entity.HasKey(e => e.AppId)
                    .HasName("PK__Master_A__8E2CF7D94D2A7347");

                entity.ToTable("Master_ApplicationSettings");

                entity.HasComment("It contains all the basic information about the servers, host name, etc.");

                entity.Property(e => e.AppId).HasColumnName("AppID");

                entity.Property(e => e.AppKey)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AppValue).IsUnicode(false);
            });

            modelBuilder.Entity<MasterBackendServiceType>(entity =>
            {
                entity.HasKey(e => e.BackendServiceTypeId)
                    .HasName("PK__Master_B__44C6B9CB31E4AD8A");

                entity.ToTable("Master_BackendServiceType");

                entity.Property(e => e.BackendServiceTypeId).HasColumnName("BackendServiceTypeID");

                entity.Property(e => e.Actionvia)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.Purpose)
                    .IsRequired()
                    .HasMaxLength(5000)
                    .IsUnicode(false);

                entity.Property(e => e.ServiceTypeName)
                    .IsRequired()
                    .HasMaxLength(5000)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterBloodGroup>(entity =>
            {
                entity.HasKey(e => e.BloodGroupId)
                    .HasName("PK__Master_B__4398C6AF7100216E");

                entity.ToTable("Master_BloodGroup");

                entity.HasComment("Contains all the blood groups.");

                entity.Property(e => e.BloodGroupId).HasColumnName("BloodGroupID");

                entity.Property(e => e.BloodGroupName).HasMaxLength(50);
            });

            modelBuilder.Entity<MasterBranches>(entity =>
            {
                entity.HasKey(e => e.BranchId)
                    .HasName("PK__Master_B__A1682FA54959E263");

                entity.ToTable("Master_Branches");

                entity.HasComment("It contains all the branches list.");

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.BranchName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterCategory>(entity =>
            {
                entity.HasKey(e => e.Categoryid)
                    .HasName("PK__Master_C__190606236C7B6373");

                entity.ToTable("Master_Category");

                entity.HasComment("It contains  the category name for hardware request in asset management page.");

                entity.Property(e => e.Categoryid).ValueGeneratedNever();

                entity.Property(e => e.CategoryName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MasterCity>(entity =>
            {
                entity.HasKey(e => e.CityId)
                    .HasName("PK__Master_C__F2D21A966C3B6C51");

                entity.ToTable("Master_City");

                entity.HasComment("Contains the default cities name.");

                entity.Property(e => e.CityId).HasColumnName("CityID");

                entity.Property(e => e.CityName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.HasOne(d => d.State)
                    .WithMany(p => p.MasterCity)
                    .HasForeignKey(d => d.StateId)
                    .HasConstraintName("FK__Master_Ci__State__6E23B4C3");
            });

            modelBuilder.Entity<MasterColumnTypes>(entity =>
            {
                entity.HasKey(e => e.ColumnTypeId)
                    .HasName("PK_ColumnTypes");

                entity.ToTable("Master_ColumnTypes");

                entity.Property(e => e.ColumnTypeId).HasColumnName("ColumnTypeID");

                entity.Property(e => e.ColumnTypeName).HasMaxLength(50);
            });

            modelBuilder.Entity<MasterComponent>(entity =>
            {
                entity.ToTable("Master_Component");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Description).HasMaxLength(50);
            });

            modelBuilder.Entity<MasterCountry>(entity =>
            {
                entity.HasKey(e => e.CountryId)
                    .HasName("PK__Master_C__10D160BF63A62650");

                entity.ToTable("Master_Country");

                entity.HasComment("Contains the list of countries used in Manage employee page.");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.CountryName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterDataBaseTechnolgy>(entity =>
            {
                entity.ToTable("Master_DataBaseTechnolgy");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.DatabaseTools)
                    .IsRequired()
                    .HasColumnName("Database_Tools")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterDays>(entity =>
            {
                entity.ToTable("Master_Days");

                entity.HasComment("Contains the list of weekdays in a week.");

                entity.Property(e => e.Days).IsUnicode(false);
            });

            modelBuilder.Entity<MasterDesignation>(entity =>
            {
                entity.HasKey(e => e.DesignationId)
                    .HasName("PK__Master_D__BABD603E345EC57D");

                entity.ToTable("Master_Designation");

                entity.HasComment("Contains the list of designations used in Manage employee bulk upload and profile page.");

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");

                entity.Property(e => e.DesignationDescription)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DesignationName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterDeviceStatus>(entity =>
            {
                entity.HasKey(e => e.DeviceStatusId)
                    .HasName("PK__Master_D__17D8CDD2346C147A");

                entity.ToTable("Master_DeviceStatus");

                entity.Property(e => e.DeviceStatus)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterDifferentZone>(entity =>
            {
                entity.ToTable("Master_DifferentZone");

                entity.HasComment("Contains the list of zones(IST,US,Uk) used in Holiday pages.");

                entity.Property(e => e.Zone).IsUnicode(false);
            });

            modelBuilder.Entity<MasterEmailTemplateCategory>(entity =>
            {
                entity.HasKey(e => e.EmailTemplateCategoryId)
                    .HasName("PK__Master_E__696EAC39301B9552");

                entity.ToTable("Master_EmailTemplateCategory");

                entity.HasComment("Contains the list of default Email templates used in administration setup page.");

                entity.Property(e => e.EmailTemplateCategoryId).HasColumnName("EmailTemplateCategoryID");

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterFeedBackQuestions>(entity =>
            {
                entity.HasKey(e => e.FeedbackQuestionId)
                    .HasName("PK__Master_F__139102865DC32FC8");

                entity.ToTable("Master_FeedBackQuestions", "EmployeeFeedback");

                entity.Property(e => e.FeedbackQuestionId)
                    .HasColumnName("FeedbackQuestionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.FeedbackQuestion).IsRequired();
            });

            modelBuilder.Entity<MasterFloor>(entity =>
            {
                entity.HasKey(e => e.FloorId)
                    .HasName("PK__Master_F__49D1E84B5B85E19B");

                entity.ToTable("Master_Floor");

                entity.Property(e => e.FloorName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterGender>(entity =>
            {
                entity.HasKey(e => e.GenderId)
                    .HasName("PK__Master_G__4E24E8172EA5EC27");

                entity.ToTable("Master_Gender");

                entity.HasComment("Contains the default gender(Male, Female) types.");

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.GenderName)
                    .HasMaxLength(25)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterGitcategory>(entity =>
            {
                entity.HasKey(e => e.GitId)
                    .HasName("PK__Master_G__8CAAFB0C10B8C3E9");

                entity.ToTable("Master_GITCategory");

                entity.Property(e => e.GitId)
                    .HasColumnName("GIT_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CategoryName)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterHoliday>(entity =>
            {
                entity.HasKey(e => e.HolidayId)
                    .HasName("PK_Holiday");

                entity.ToTable("Master_holiday");

                entity.HasComment("Contains the list of holidays used in Holidays Pages.");

                entity.Property(e => e.HolidayId).ValueGeneratedOnAdd();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Detail).HasMaxLength(50);
            });

            modelBuilder.Entity<MasterIsOpen>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PK_IsOpen");

                entity.ToTable("Master_IsOpen");

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<MasterItfloor>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Master_ITFloor");

                entity.Property(e => e.FloorId)
                    .HasColumnName("FloorID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.FloorName)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MasterItrequestAttachmentType>(entity =>
            {
                entity.HasKey(e => e.ItrequestAttachmentTypeId)
                    .HasName("PK_AttachmentTypeId");

                entity.ToTable("Master_ITRequestAttachmentType");

                entity.Property(e => e.ItrequestAttachmentTypeId).HasColumnName("ITRequestAttachmentTypeId");

                entity.Property(e => e.AttachmentTypeName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterItrequestHistoryStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PK__Master_I__C8EE2063741C853B");

                entity.ToTable("Master_ITRequestHistoryStatus");
            });

            modelBuilder.Entity<MasterItstatus>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PK__Master_I__C8EE206368AAD28F");

                entity.ToTable("Master_ITStatus");
            });

            modelBuilder.Entity<MasterLdapSettings>(entity =>
            {
                entity.HasKey(e => e.AppId)
                    .HasName("PK__Master_L__8E2CF7D935803444");

                entity.ToTable("Master_LdapSettings");

                entity.Property(e => e.AppId).HasColumnName("AppID");

                entity.Property(e => e.AppKey)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.AppValue).IsUnicode(false);
            });

            modelBuilder.Entity<MasterLeaveStatus>(entity =>
            {
                entity.HasKey(e => e.LeaveStatusId)
                    .HasName("PK_LeaveStatus");

                entity.ToTable("Master_LeaveStatus");

                entity.HasComment("Contains the status of the leave applied in Leave management pages.");

                entity.Property(e => e.LeaveStatusId).ValueGeneratedOnAdd();

                entity.Property(e => e.Status)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MasterLoginStatus>(entity =>
            {
                entity.HasKey(e => e.LoginStatusId)
                    .HasName("PK__Master_L__2D041B803F914C5E");

                entity.ToTable("Master_LoginStatus");

                entity.HasComment("Contains the list of Login statuses while users entering into the login page.");

                entity.Property(e => e.LoginStatusId).HasColumnName("LoginStatusID");

                entity.Property(e => e.LoginStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterMaritalStatus>(entity =>
            {
                entity.HasKey(e => e.MaritalStatusId)
                    .HasName("PK__Master_M__C8B1BA522334397B");

                entity.ToTable("Master_MaritalStatus");

                entity.HasComment("Contains the Marital status of the employees (Married, Unmarried) in Employee Management Pages.");

                entity.Property(e => e.MaritalStatusId).HasColumnName("MaritalStatusID");

                entity.Property(e => e.MaritalStatusType)
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterMemberTypes>(entity =>
            {
                entity.HasKey(e => e.MemberTypeId)
                    .HasName("PK_MemberTypes");

                entity.ToTable("Master_MemberTypes");

                entity.HasComment("Contains the list of member types used in project management pages.");

                entity.Property(e => e.MemberTypeId).HasColumnName("MemberTypeID");

                entity.Property(e => e.MemberType)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MasterMileStones>(entity =>
            {
                entity.HasKey(e => e.MileStoneId)
                    .HasName("PK__Master_M__F00A20DA1B9317B3");

                entity.ToTable("Master_MileStones");

                entity.HasComment("Contains the list of phases used in Project Management pages.");

                entity.Property(e => e.MileStoneId).HasColumnName("MileStoneID");

                entity.Property(e => e.MileStoneName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterNationality>(entity =>
            {
                entity.HasKey(e => e.NationalityId)
                    .HasName("PK__Master_N__10D160BF4ADA7886");

                entity.ToTable("Master_Nationality");

                entity.HasComment("Contains the list of Nationalities used in Employee Management pages.");

                entity.Property(e => e.NationalityId).HasColumnName("NationalityID");

                entity.Property(e => e.NationalityName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterOrm>(entity =>
            {
                entity.ToTable("Master_ORM");

                entity.HasComment("Contains the list of ORM_tools used in project management pages.");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OrmTools)
                    .IsRequired()
                    .HasColumnName("ORM_Tools")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterOs>(entity =>
            {
                entity.HasKey(e => e.OsId)
                    .HasName("PK__Master_O__E2A6C5B31209AD79");

                entity.ToTable("Master_Os");

                entity.HasComment("Contains the list of OS Names used in Asset Management pages.");

                entity.Property(e => e.OsName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterOutOfOfficePlaces>(entity =>
            {
                entity.HasKey(e => e.OdplaceId)
                    .HasName("PK__Master_O__A895C1E30E391C95");

                entity.ToTable("Master_OutOfOfficePlaces");

                entity.HasComment(@"Contains
the list of OutofOffice places used in Out
Of Office Assistance Request
in
Leave management page. ");

                entity.Property(e => e.OdplaceId).HasColumnName("ODPlaceID");

                entity.Property(e => e.Odcountry)
                    .HasColumnName("ODCountry")
                    .IsUnicode(false);

                entity.Property(e => e.Odlocation)
                    .HasColumnName("ODLocation")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterOutOfOfficeTypes>(entity =>
            {
                entity.HasKey(e => e.OdtypeId)
                    .HasName("PK__Master_O__9CEFF7CC0A688BB1");

                entity.ToTable("Master_OutOfOfficeTypes");

                entity.HasComment("Contains the list of OutofOffice types used in Out Of Office Assistance Request in Leave management page.");

                entity.Property(e => e.OdtypeId).HasColumnName("ODTypeId");

                entity.Property(e => e.OdtypeName)
                    .HasColumnName("ODTypeName")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterPermissions>(entity =>
            {
                entity.HasKey(e => e.Permissionid)
                    .HasName("PK__Master_p__EFB7C077774DF7A1");

                entity.ToTable("Master_permissions", "Project");

                entity.Property(e => e.PermissionName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterPremium>(entity =>
            {
                entity.HasKey(e => e.Pno)
                    .HasName("PK__Master_P__C5773DCF057C1B67");

                entity.ToTable("Master_Premium");

                entity.Property(e => e.Pno)
                    .HasColumnName("PNO")
                    .ValueGeneratedNever();

                entity.Property(e => e.Pvalues)
                    .HasColumnName("PValues")
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterPriority>(entity =>
            {
                entity.HasKey(e => e.Priorityid)
                    .HasName("PK__Master_P__D0BCD4E6704BF457");

                entity.ToTable("Master_Priority");

                entity.HasComment("Contains the list of Priorities used in Hardware Request page.");

                entity.Property(e => e.Priorityid).ValueGeneratedNever();

                entity.Property(e => e.PriorityName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MasterProjectResearchType>(entity =>
            {
                entity.HasKey(e => e.ResearchTypeId)
                    .HasName("PK__Master_P__B36580D8352B2E89");

                entity.ToTable("Master_ProjectResearchType");

                entity.Property(e => e.ResearchTypeId)
                    .HasColumnName("ResearchTypeID")
                    .ValueGeneratedNever();

                entity.Property(e => e.ResearchType)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterProjectStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PK__Master_P__C8EE20432A7895EC");

                entity.ToTable("Master_ProjectStatus");

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(30)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterProjectTools>(entity =>
            {
                entity.HasKey(e => e.ProjectToolId)
                    .HasName("ProjectToolId");

                entity.ToTable("Master_ProjectTools", "Project");

                entity.Property(e => e.ProjectToolName)
                    .IsRequired()
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterProjectTypes>(entity =>
            {
                entity.HasKey(e => e.ProjectTypeId)
                    .HasName("PK_ProjectTypes");

                entity.ToTable("Master_ProjectTypes");

                entity.HasComment("Contains the list of project types name used in Project management pages");

                entity.Property(e => e.ProjectTypeId).HasColumnName("ProjectTypeID");

                entity.Property(e => e.ProjectTypeName).HasMaxLength(250);
            });

            modelBuilder.Entity<MasterRatingCriteria>(entity =>
            {
                entity.HasKey(e => e.RatingCriteriaId)
                    .HasName("PK__Master_R__86BA75BC59F29EE4");

                entity.ToTable("Master_RatingCriteria", "EmployeeFeedback");

                entity.Property(e => e.RatingCriteriaId)
                    .HasColumnName("RatingCriteriaID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.RatingCriteria)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterRecognition>(entity =>
            {
                entity.HasKey(e => e.RecognitionId)
                    .HasName("PK__Master_R__4E43A9046193C0AC");

                entity.ToTable("Master_Recognition", "EmployeeFeedback");

                entity.Property(e => e.RecognitionId)
                    .HasColumnName("RecognitionID")
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Recognition)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<MasterRelationship>(entity =>
            {
                entity.HasKey(e => e.RelationshipId)
                    .HasName("PK__Master_R__31FEB8614EAB096A");

                entity.ToTable("Master_Relationship");

                entity.HasComment("Contains the list of relationship names used in Employee Management pages.");

                entity.Property(e => e.RelationshipId).HasColumnName("RelationshipID");

                entity.Property(e => e.RelationshipName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterReligious>(entity =>
            {
                entity.HasKey(e => e.ReligiousId)
                    .HasName("PK__Master_R__507A2FF94709E7A2");

                entity.ToTable("Master_Religious");

                entity.HasComment("Contains the list of Religions names used in Employee Management pages.");

                entity.Property(e => e.ReligiousId).HasColumnName("ReligiousID");

                entity.Property(e => e.ReligiousName)
                    .HasMaxLength(80)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterReportType>(entity =>
            {
                entity.HasKey(e => e.ReportTypeId)
                    .HasName("PK_ReportTypeId");

                entity.ToTable("Master_ReportType", "QA");

                entity.Property(e => e.ReportTypeDescription)
                    .IsRequired()
                    .HasMaxLength(400)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterRequestStatus>(entity =>
            {
                entity.HasKey(e => e.RequestStatusId)
                    .HasName("PK_RequestStatus");

                entity.ToTable("Master_RequestStatus");

                entity.HasComment("Contains the list of Request Status used in Hardware Request page.");

                entity.Property(e => e.RequestStatusId).ValueGeneratedOnAdd();

                entity.Property(e => e.RequestStatus)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MasterRoles>(entity =>
            {
                entity.HasKey(e => e.RoleId)
                    .HasName("PK_Roles");

                entity.ToTable("Master_Roles");

                entity.HasComment("Contains the list of Role Names & Role description of the user who is logging in the Portal.");

                entity.Property(e => e.RoleId)
                    .HasColumnName("RoleID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.RoleDescription).HasMaxLength(100);

                entity.Property(e => e.RoleName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<MasterSkillStatus>(entity =>
            {
                entity.HasKey(e => e.AssessmentStatusId)
                    .HasName("PK__Master_S__F24C01773965D3C1");

                entity.ToTable("Master_SkillStatus");

                entity.Property(e => e.AssessmentStatusId).HasColumnName("AssessmentStatusID");

                entity.Property(e => e.AssessmentStatus)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterSoftwares>(entity =>
            {
                entity.HasKey(e => e.SoftwareId)
                    .HasName("PK__Master_S__25EDB8BC6AE820BC");

                entity.ToTable("Master_Softwares");

                entity.Property(e => e.SoftwareName)
                    .IsRequired()
                    .HasMaxLength(600)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterSourceControl>(entity =>
            {
                entity.ToTable("Master_SourceControl");

                entity.HasComment("Contains the list of Source control Tools used in Project Management Pages.");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.SourceControlTools)
                    .IsRequired()
                    .HasColumnName("SourceControl_Tools")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterStates>(entity =>
            {
                entity.HasKey(e => e.StateId)
                    .HasName("PK__Master_S__C3BA3B5A6776B734");

                entity.ToTable("Master_States");

                entity.HasComment("Contains the list of States used in Manage employee page.");

                entity.Property(e => e.StateId).HasColumnName("StateID");

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.States)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Country)
                    .WithMany(p => p.MasterStates)
                    .HasForeignKey(d => d.CountryId)
                    .HasConstraintName("FK__Master_St__Count__695EFFA6");
            });

            modelBuilder.Entity<MasterTab>(entity =>
            {
                entity.HasKey(e => e.TabId)
                    .HasName("PK__Master_T__80E37C3852F9268D");

                entity.ToTable("Master_Tab");

                entity.HasComment("It contains the list of Tab Names used in Dashboard Page.");

                entity.Property(e => e.TabId).HasColumnName("TabID");

                entity.Property(e => e.TabName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterTabGrids>(entity =>
            {
                entity.HasKey(e => e.GridId)
                    .HasName("PK__Master_T__FB2F3BAE579F76C7");

                entity.ToTable("Master_Tab_Grids");

                entity.HasComment("It contains the list of Grid Names used in Dashboard Page.");

                entity.Property(e => e.GridId).HasColumnName("GridID");

                entity.Property(e => e.GridName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterTeamMonths>(entity =>
            {
                entity.ToTable("Master_TeamMonths");

                entity.HasComment("It contains the month name and its ID used in Time Management Page");

                entity.Property(e => e.Months).IsUnicode(false);
            });

            modelBuilder.Entity<MasterTechnologies>(entity =>
            {
                entity.ToTable("Master_Technologies");

                entity.HasComment("It contains the Technology Name and its ID used in Employee Management Page");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Tecnology)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterThemeColors>(entity =>
            {
                entity.HasKey(e => e.ColorId)
                    .HasName("PK_ThemeSetting");

                entity.ToTable("Master_ThemeColors");

                entity.HasComment("It contains the Color and its Id used for setting the Theme color In Configuration Page.");

                entity.Property(e => e.ColorName).IsUnicode(false);
            });

            modelBuilder.Entity<MasterThirdParty>(entity =>
            {
                entity.ToTable("Master_ThirdParty");

                entity.HasComment("It contains the list of Third_Party_ Tools used in Project Management Pages.");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ThirdPartyTools)
                    .IsRequired()
                    .HasColumnName("ThirdParty_Tools")
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterTrainingLevel>(entity =>
            {
                entity.HasKey(e => e.LevelId)
                    .HasName("PK__Master_T__09F03C2659C55456");

                entity.ToTable("Master_TrainingLevel");

                entity.HasComment("It contains the level Name and its Id used in Learning & development page.");

                entity.Property(e => e.LevelName)
                    .HasMaxLength(300)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterTrainingPurpose>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Master_TrainingPurpose");

                entity.HasComment("It contains the list of training Purpose Name used in Learning & development page.");

                entity.Property(e => e.Purpose)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.PurposeId).ValueGeneratedOnAdd();
            });

            modelBuilder.Entity<MasterTrainingStatus>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PK__Master_T__C8EE206355009F39");

                entity.ToTable("Master_TrainingStatus");

                entity.HasComment("It contains the Training status Name that is used in Learning & development page.");

                entity.Property(e => e.StatusName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterTrainingTechnology>(entity =>
            {
                entity.HasKey(e => e.TechnologyId)
                    .HasName("PK__Master_T__7057015851300E55");

                entity.ToTable("Master_TrainingTechnology");

                entity.HasComment("It contains the Training Technology Name that is used in Learning & development page.");

                entity.Property(e => e.TechnologyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterTrainingType>(entity =>
            {
                entity.HasKey(e => e.TrainingTypeId)
                    .HasName("PK__Master_T__A312FFE84D5F7D71");

                entity.ToTable("Master_TrainingType");

                entity.HasComment("It contains the Training Type Name that is used in Learning & development page.");

                entity.Property(e => e.TypeName)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterTsrMonth>(entity =>
            {
                entity.ToTable("Master_TSR_Month");

                entity.Property(e => e.Month).IsUnicode(false);
            });

            modelBuilder.Entity<MasterTypes>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PK_Types");

                entity.ToTable("Master_Types");

                entity.HasComment("It contains the member type name and Id used in Project Mapping Page.");

                entity.Property(e => e.MemberTypes).IsUnicode(false);
            });

            modelBuilder.Entity<MasterTypesofEmployees>(entity =>
            {
                entity.ToTable("Master_TypesofEmployees");

                entity.HasComment("It contains the Employee type name used in Employee Management Page.");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.Types).IsUnicode(false);
            });

            modelBuilder.Entity<MasterUserStatus>(entity =>
            {
                entity.HasKey(e => e.UserStatusId);

                entity.ToTable("Master_UserStatus");

                entity.HasComment("It contains the UserStatus Id and Their status Name used in Employee Management Page.");

                entity.Property(e => e.UserStatus)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterWeeks>(entity =>
            {
                entity.HasKey(e => e.WeekId)
                    .HasName("PK__Master_W__C814A5C12BC1BFE0");

                entity.ToTable("Master_Weeks", "QA");

                entity.Property(e => e.Legends)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterWfhstatus>(entity =>
            {
                entity.HasKey(e => e.StatusId)
                    .HasName("PK__Master_W__C8EE2063485DFE8E");

                entity.ToTable("Master_WFHStatus");

                entity.Property(e => e.StatusId).ValueGeneratedOnAdd();

                entity.Property(e => e.StatusName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MasterWorkPlace>(entity =>
            {
                entity.HasKey(e => e.WorkPlaceId)
                    .HasName("PK__Master_W__0C3674E63A4CA8FD");

                entity.ToTable("Master_WorkPlace");

                entity.Property(e => e.WorkPlaceId).HasColumnName("WorkPlaceID");

                entity.Property(e => e.WorkPlaceName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<MeetingGuids>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.FirstName).IsUnicode(false);
            });

            modelBuilder.Entity<MettingSchedule>(entity =>
            {
                entity.HasComment("This information available in Project Management page.");

                entity.Property(e => e.Attendees).IsUnicode(false);

                entity.Property(e => e.Day)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EndTime).IsUnicode(false);

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.TimeSlot).IsUnicode(false);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.MettingSchedule)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_MettingSchedule_Projects");
            });

            modelBuilder.Entity<MileStoneValues>(entity =>
            {
                entity.HasComment("It has the details of project's milestone information and its starting and ending time.");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ActualEndDate).HasColumnType("datetime");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.MileStoneId).HasColumnName("MileStoneID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.HasOne(d => d.MileStone)
                    .WithMany(p => p.MileStoneValues)
                    .HasForeignKey(d => d.MileStoneId)
                    .HasConstraintName("FK_MileStoneValues_MileStones");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.MileStoneValues)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_MileStoneValues_Projects");
            });

            modelBuilder.Entity<MissingTemplates>(entity =>
            {
                entity.HasKey(e => e.MissingTemplateId)
                    .HasName("PK__MissingT__D2F1A6131EA6F08D");

                entity.HasComment("It contains information for Missing Templates name and its processed date.");

                entity.Property(e => e.MissingTemplateId).HasColumnName("MissingTemplateID");

                entity.Property(e => e.MissedProcess)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessedBy)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProcessedDate).HasColumnType("datetime");

                entity.Property(e => e.TemplateName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ModulePages>(entity =>
            {
                entity.HasKey(e => e.ModulePageId);

                entity.HasComment("It has the information for all the page modules and page details.");

                entity.Property(e => e.PageModuleId).HasColumnName("PageModuleID");

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.ModulePages)
                    .HasForeignKey(d => d.PageId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ModulePages_Pages");

                entity.HasOne(d => d.PageModule)
                    .WithMany(p => p.ModulePages)
                    .HasForeignKey(d => d.PageModuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ModulePages_Modules");
            });

            modelBuilder.Entity<ModulePrecedanceOrder>(entity =>
            {
                entity.HasKey(e => e.SubPreceedingId);

                entity.HasComment("It contains all page module and sub preceeding id details and precedance order.");

                entity.Property(e => e.SubPreceedingId).HasColumnName("SubPreceedingID");

                entity.Property(e => e.PageModuleId).HasColumnName("PageModuleID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.PageModule)
                    .WithMany(p => p.ModulePrecedanceOrder)
                    .HasForeignKey(d => d.PageModuleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LDModulePrecedanceOrder_LDModules");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.ModulePrecedanceOrder)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_LDModulePrecedanceOrder_LDModulePrecedanceOrder");
            });

            modelBuilder.Entity<Modules>(entity =>
            {
                entity.HasKey(e => e.PageModuleId);

                entity.HasComment("It has all the details about page modules and its description.");

                entity.Property(e => e.PageModuleId)
                    .HasColumnName("PageModuleID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.InitialPage)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleDescription)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ModuleName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Style).HasMaxLength(150);
            });

            modelBuilder.Entity<Ormvalues>(entity =>
            {
                entity.ToTable("ORMValues");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.OrmToolsId).HasColumnName("ORM_Tools_ID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.HasOne(d => d.OrmTools)
                    .WithMany(p => p.Ormvalues)
                    .HasForeignKey(d => d.OrmToolsId)
                    .HasConstraintName("FK_ORMValues_ORM");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.Ormvalues)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_ORMValues_Projects");
            });

            modelBuilder.Entity<OutOfOfficeDetails>(entity =>
            {
                entity.HasKey(e => e.Odid)
                    .HasName("PK__OutOfOff__AD346FF53CBF0154");

                entity.HasComment("Out of office details are used in Leave Management Page.It has the details about out of office activities.");

                entity.Property(e => e.Odid).HasColumnName("ODId");

                entity.Property(e => e.MngrComments).IsUnicode(false);

                entity.Property(e => e.OdalternateNo)
                    .HasColumnName("ODAlternateNo")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Odcomments)
                    .HasColumnName("ODComments")
                    .IsUnicode(false);

                entity.Property(e => e.OdendDate)
                    .HasColumnName("ODEndDate")
                    .HasColumnType("date");

                entity.Property(e => e.OdplaceId).HasColumnName("ODPlaceID");

                entity.Property(e => e.OdstartDate)
                    .HasColumnName("ODStartDate")
                    .HasColumnType("date");

                entity.Property(e => e.OdtypeId).HasColumnName("ODTypeID");

                entity.Property(e => e.OdworkingDays).HasColumnName("ODWorkingDays");

                entity.Property(e => e.Others)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.RejectedDate).HasColumnType("datetime");

                entity.Property(e => e.RejectedReason).IsUnicode(false);

                entity.Property(e => e.RequestedDate).HasColumnType("datetime");

                entity.HasOne(d => d.RequestStatus)
                    .WithMany(p => p.OutOfOfficeDetails)
                    .HasForeignKey(d => d.RequestStatusId)
                    .HasConstraintName("fk_OOOnDutyDetails_RequestStatusId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.OutOfOfficeDetails)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("fk_OOOnDutyDetails_UserId");
            });

            modelBuilder.Entity<Pages>(entity =>
            {
                entity.HasKey(e => e.PageId);

                entity.HasComment("It has all the details of  pages and its url path.");

                entity.Property(e => e.PageId).HasColumnName("PageID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.PageName)
                    .IsRequired()
                    .HasMaxLength(50);

                entity.Property(e => e.PageUrl)
                    .HasColumnName("PageURL")
                    .HasMaxLength(250);
            });

            modelBuilder.Entity<PermanentAddress>(entity =>
            {
                entity.HasComment("It has the user permanent address details and its used in employee management page.");

                entity.Property(e => e.PermanentAddressId).HasColumnName("PermanentAddressID");

                entity.Property(e => e.Address1).HasColumnName("Address_1");

                entity.Property(e => e.Address2).HasColumnName("Address_2");

                entity.Property(e => e.Address3).HasColumnName("Address_3");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PermanentAddress)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__Permanent__UserID");
            });

            modelBuilder.Entity<PresentAddress>(entity =>
            {
                entity.HasComment("It has the user present address details and its used in employee management page.");

                entity.Property(e => e.PresentAddressId).HasColumnName("PresentAddressID");

                entity.Property(e => e.Address1).HasColumnName("Address_1");

                entity.Property(e => e.Address2).HasColumnName("Address_2");

                entity.Property(e => e.Address3).HasColumnName("Address_3");

                entity.Property(e => e.City)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CountryId).HasColumnName("CountryID");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.State)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.PresentAddress)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__PresentAd__UserI__0B1FE624");
            });

            modelBuilder.Entity<ProjectCategoryMapping>(entity =>
            {
                entity.HasComment("It contains all the project details which is used in Project Management Page.");

                entity.Property(e => e.ProjectCategoryMappingId).HasColumnName("ProjectCategoryMapping_ID");

                entity.Property(e => e.CategoryId).HasColumnName("CategoryID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.HasOne(d => d.Category)
                    .WithMany(p => p.ProjectCategoryMapping)
                    .HasForeignKey(d => d.CategoryId)
                    .HasConstraintName("FK__ProjectCa__Categ__469FD34E");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectCategoryMapping)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__ProjectCa__Proje__4793F787");
            });

            modelBuilder.Entity<ProjectMetrics>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Metrics)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProjectPayment>(entity =>
            {
                entity.HasKey(e => e.PaymentId)
                    .HasName("PK__ProjectP__9B556A583A6CA48E");

                entity.HasComment("It has the assigned projects and its payment details.These details are used in Project Management page.");

                entity.Property(e => e.PaymentId).HasColumnName("PaymentID");

                entity.Property(e => e.CustomerName)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ProjectSoftware>(entity =>
            {
                entity.ToTable("ProjectSoftware", "Project");

                entity.Property(e => e.RequestedDate).HasColumnType("datetime");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectSoftware)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Project_SoftwareId");

                entity.HasOne(d => d.Software)
                    .WithMany(p => p.ProjectSoftware)
                    .HasForeignKey(d => d.SoftwareId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectSoftware_SoftwareId");
            });

            modelBuilder.Entity<ProjectStatus>(entity =>
            {
                entity.HasComment("It has the project status report and its active status.These details are used in Project Management Page.");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.CommentsCreated).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.StatusComments).IsRequired();

                entity.Property(e => e.StatusId).HasColumnName("StatusID");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectStatusNavigation)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_Project Status_Projects");
            });

            modelBuilder.Entity<ProjectStatusHistory>(entity =>
            {
                entity.Property(e => e.Id).ValueGeneratedOnAdd();

                entity.Property(e => e.EnteredDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.HasOne(d => d.EnteredByNavigation)
                    .WithMany(p => p.ProjectStatusHistory)
                    .HasForeignKey(d => d.EnteredBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectHistoryuserId");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectStatusHistory)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectHistoryProjectId");
            });

            modelBuilder.Entity<ProjectToolAccessDetail>(entity =>
            {
                entity.ToTable("ProjectToolAccessDetail", "Project");

                entity.Property(e => e.Createddate).HasColumnType("datetime");

                entity.HasOne(d => d.ProjectToolDetail)
                    .WithMany(p => p.ProjectToolAccessDetail)
                    .HasForeignKey(d => d.ProjectToolDetailId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectToolAccessDetail_ProjectToolDetailId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ProjectToolAccessDetail)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectToolAccessDetail_ProjectID");
            });

            modelBuilder.Entity<ProjectToolDetail>(entity =>
            {
                entity.ToTable("ProjectToolDetail", "Project");

                entity.Property(e => e.ToolProjectName)
                    .IsRequired()
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.ToolUrl)
                    .IsRequired()
                    .HasColumnName("ToolURL")
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ProjectToolDetail)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectToolDetail_ProjectID");

                entity.HasOne(d => d.ProjectTool)
                    .WithMany(p => p.ProjectToolDetail)
                    .HasForeignKey(d => d.ProjectToolId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectToolDetail_ProjectToolId");
            });

            modelBuilder.Entity<ProjectUtilization>(entity =>
            {
                entity.HasKey(e => e.UtilizationId)
                    .HasName("PK__ProjectU__F910D21510EDCE13");

                entity.Property(e => e.IsActive)
                    .IsRequired()
                    .HasDefaultValueSql("((1))");
            });

            modelBuilder.Entity<Projects>(entity =>
            {
                entity.HasKey(e => e.ProjectId);

                entity.HasComment("It contains the information about all projects and its description and its time management details.");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.CommentsCreated).HasColumnType("datetime");

                entity.Property(e => e.Createdby).HasColumnName("createdby");

                entity.Property(e => e.DateCreated).HasColumnType("datetime");

                entity.Property(e => e.DeliveryPopUp).HasColumnName("Delivery_PopUp");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.IsQms).HasColumnName("IsQMS");

                entity.Property(e => e.ManagedResourcesId)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Metrix).IsUnicode(false);

                entity.Property(e => e.ProjectCode).HasMaxLength(50);

                entity.Property(e => e.ProjectEndDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectStartDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectTypeId).HasColumnName("ProjectTypeID");

                entity.Property(e => e.QacodePopUp).HasColumnName("QACode_PopUp");

                entity.Property(e => e.Ragcomments).HasColumnName("RAGComments");

                entity.Property(e => e.Ragstatus).HasColumnName("RAGStatus");

                entity.Property(e => e.SvnRepositoryUrl).HasMaxLength(255);

                entity.HasOne(d => d.ProjectType)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.ProjectTypeId)
                    .HasConstraintName("FK_Projects_ProjectTypes");
            });

            modelBuilder.Entity<PunchLocation>(entity =>
            {
                entity.Property(e => e.FloorName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QaprojectRagStatus>(entity =>
            {
                entity.ToTable("QAProjectRagStatus", "QA");

                entity.Property(e => e.Id).HasColumnName("id");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.SubmittedDate).HasColumnType("datetime");

                entity.HasOne(d => d.MemberType)
                    .WithMany(p => p.QaprojectRagStatus)
                    .HasForeignKey(d => d.MemberTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rag_MemberTypeId");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.QaprojectRagStatus)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rag_ProjectId");

                entity.HasOne(d => d.ReviewWeek)
                    .WithMany(p => p.QaprojectRagStatus)
                    .HasForeignKey(d => d.ReviewWeekId)
                    .HasConstraintName("FK_QAProjectRagStatus_ReviewWeekId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.QaprojectRagStatus)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Rag_UserId");
            });

            modelBuilder.Entity<QareportQuestionAnswers>(entity =>
            {
                entity.HasKey(e => e.AnswerId)
                    .HasName("PK_AnswerId");

                entity.ToTable("QAReportQuestionAnswers", "QA");

                entity.Property(e => e.AnswerCreatedDate).HasColumnType("datetime");

                entity.Property(e => e.AnswerDescription)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.SprintId).HasColumnName("SprintID");

                entity.Property(e => e.Submitteddate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.QareportQuestionAnswers)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectId");

                entity.HasOne(d => d.Question)
                    .WithMany(p => p.QareportQuestionAnswers)
                    .HasForeignKey(d => d.QuestionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_AnswerQuestionId");

                entity.HasOne(d => d.ReviewWeek)
                    .WithMany(p => p.QareportQuestionAnswers)
                    .HasForeignKey(d => d.ReviewWeekId)
                    .HasConstraintName("FK_ReviewWeekId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.QareportQuestionAnswers)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectUserId");
            });

            modelBuilder.Entity<QareportQuestionType>(entity =>
            {
                entity.HasKey(e => e.QuestionTypeId)
                    .HasName("PK_QuestionTypeId");

                entity.ToTable("QAReportQuestionType", "QA");

                entity.Property(e => e.QuestionTypeDescription)
                    .IsRequired()
                    .HasMaxLength(40)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<QareportQuestions>(entity =>
            {
                entity.HasKey(e => e.QuestionId)
                    .HasName("PK_QuestionId");

                entity.ToTable("QAReportQuestions", "QA");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.QuestionDescription)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.HasOne(d => d.MemberType)
                    .WithMany(p => p.QareportQuestions)
                    .HasForeignKey(d => d.MemberTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_MemberTypeId");

                entity.HasOne(d => d.ProjectType)
                    .WithMany(p => p.QareportQuestions)
                    .HasForeignKey(d => d.ProjectTypeId)
                    .HasConstraintName("FK_QAReportQuestions_ProjectTypeId");

                entity.HasOne(d => d.QuestionType)
                    .WithMany(p => p.QareportQuestions)
                    .HasForeignKey(d => d.QuestionTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_QuestionId");

                entity.HasOne(d => d.ReportType)
                    .WithMany(p => p.QareportQuestions)
                    .HasForeignKey(d => d.ReportTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ReportTypeId");
            });

            modelBuilder.Entity<QasprintReview>(entity =>
            {
                entity.ToTable("QASprintReview", "QA");

                entity.Property(e => e.Enddate).HasColumnType("datetime");

                entity.Property(e => e.ProjectId).HasColumnName("projectId");

                entity.Property(e => e.Sprint)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Startdate).HasColumnType("datetime");
            });

            modelBuilder.Entity<QuickAccessMenu>(entity =>
            {
                entity.ToTable("QuickAccessMenu", "Master");

                entity.Property(e => e.CreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.IconStyleClass).HasMaxLength(500);

                entity.HasOne(d => d.Page)
                    .WithMany(p => p.QuickAccessMenu)
                    .HasForeignKey(d => d.PageId)
                    .HasConstraintName("FK_QuickAccessMenu_PageId_Pages_PageID");
            });

            modelBuilder.Entity<QuickEnroll>(entity =>
            {
                entity.HasKey(e => e.QuickEnroll1)
                    .HasName("PK__QuickEnr__E99853BD1B9E04AB");

                entity.HasComment("It contains the information about user details.We can see the every user details in Quick Enroll section in Employee Management Page .");

                entity.Property(e => e.QuickEnroll1).HasColumnName("QuickEnroll");

                entity.Property(e => e.Address)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.Comments)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.DateOfEnquiry).HasColumnType("date");

                entity.Property(e => e.DateOfJoin).HasColumnType("datetime");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.Experience)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GenderId).HasColumnName("GenderID");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Location)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PersonalMailAddress)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.QuickEnroll)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK__QuickEnro__Branc__54C30A1C");

                entity.HasOne(d => d.DepartmentGroupNavigation)
                    .WithMany(p => p.QuickEnroll)
                    .HasForeignKey(d => d.DepartmentGroup)
                    .HasConstraintName("FK__QuickEnro__Depar__21E0EDE6");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.QuickEnroll)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK__QuickEnro__Depar__20ECC9AD");

                entity.HasOne(d => d.Gender)
                    .WithMany(p => p.QuickEnroll)
                    .HasForeignKey(d => d.GenderId)
                    .HasConstraintName("FK__QuickEnro__Gende__72E869E0");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.QuickEnroll)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK__QuickEnro__RoleI__73DC8E19");
            });

            modelBuilder.Entity<RaiseRequestDetails>(entity =>
            {
                entity.HasKey(e => e.RaiseRequestId)
                    .HasName("PK__RaiseReq__C6D0E29403C8DD1F");

                entity.Property(e => e.RaiseRequestId).HasColumnName("RaiseRequestID");

                entity.Property(e => e.Description)
                    .HasColumnName("DESCRIPTION")
                    .IsUnicode(false);

                entity.Property(e => e.ProjectLeadName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectName)
                    .IsRequired()
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RaiseRequestRoleRelationShip>(entity =>
            {
                entity.Property(e => e.Avgexperience)
                    .HasColumnName("AVGExperience")
                    .HasColumnType("decimal(18, 2)");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ExpectedStartDate).HasColumnType("datetime");

                entity.Property(e => e.IsAdditional).HasColumnName("Is_Additional");

                entity.Property(e => e.IsCompleted).HasColumnName("Is_Completed");

                entity.Property(e => e.RaiseRequestId).HasColumnName("RaiseRequestID");

                entity.Property(e => e.RoleName)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.UserId)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.HasOne(d => d.RaiseRequest)
                    .WithMany(p => p.RaiseRequestRoleRelationShip)
                    .HasForeignKey(d => d.RaiseRequestId)
                    .HasConstraintName("FK__RaiseRequ__Raise__0981B675");
            });

            modelBuilder.Entity<Release>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.ReleaseDate).HasColumnType("datetime");

                entity.Property(e => e.ReleaseId)
                    .HasColumnName("ReleaseID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.Version)
                    .IsRequired()
                    .HasMaxLength(40);

                entity.Property(e => e.VersionLabel)
                    .IsRequired()
                    .HasMaxLength(40);
            });

            modelBuilder.Entity<RemainingEarnedLeaves>(entity =>
            {
                entity.ToTable("Remaining_Earned_Leaves");
            });

            modelBuilder.Entity<RemoveRequest>(entity =>
            {
                entity.HasKey(e => e.RequestId)
                    .HasName("PK__Remove_R__33A8517A652F4766");

                entity.ToTable("Remove_Request");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.RemoveRequest)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Project_ProjectId");

                entity.HasOne(d => d.UserProject)
                    .WithMany(p => p.RemoveRequest)
                    .HasForeignKey(d => d.UserProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Project_UserProjectid");
            });

            modelBuilder.Entity<ReportingPersonsRollId>(entity =>
            {
                entity.ToTable("ReportingPersonsRollID");

                entity.Property(e => e.ReportingPersonRollId).HasColumnName("ReportingPersonRollID");

                entity.HasOne(d => d.ReportingPersonRoll)
                    .WithMany(p => p.ReportingPersonsRollId)
                    .HasForeignKey(d => d.ReportingPersonRollId)
                    .HasConstraintName("FK_ReportingPersonsRollID_Roles");
            });

            modelBuilder.Entity<ReportingUsers>(entity =>
            {
                entity.HasKey(e => e.ReportingId);

                entity.HasComment("It has the information about user reporting details.Each report has a unique id and user id.");

                entity.Property(e => e.ReportingId).HasColumnName("ReportingID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");
            });

            modelBuilder.Entity<Reports>(entity =>
            {
                entity.HasKey(e => e.ReportId);

                entity.HasComment("This reports details are used in Custom Reports Page.");
            });

            modelBuilder.Entity<ResearchDetails>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.DepartmentId).HasColumnName("DepartmentID");

                entity.Property(e => e.Description).IsUnicode(false);

                entity.Property(e => e.ResearchTopic)
                    .IsRequired()
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ResearchTypeId).HasColumnName("ResearchTypeID");

                entity.Property(e => e.ScheduledEndDate).HasColumnType("datetime");

                entity.Property(e => e.ScheduledStartDate).HasColumnType("datetime");

                entity.Property(e => e.TechnologyId).HasColumnName("TechnologyID");
            });

            modelBuilder.Entity<ResearchTeamMember>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.AdminId).HasColumnName("AdminID");

                entity.Property(e => e.ResearchDetailId).HasColumnName("ResearchDetailID");

                entity.Property(e => e.ScheduledEndDate).HasColumnType("datetime");

                entity.Property(e => e.ScheduledStartDate).HasColumnType("datetime");

                entity.Property(e => e.TechnologyId).HasColumnName("TechnologyID");

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<ReviewType>(entity =>
            {
                entity.ToTable("ReviewType", "QA");

                entity.Property(e => e.ReviewTypeName)
                    .IsRequired()
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<RoleFunctionPrivileges>(entity =>
            {
                entity.HasKey(e => e.RoleFunctionPrivilegeId)
                    .HasName("PK_RoleFunctionPrivilieges");

                entity.HasComment("It has the role function details and the page id which functions are used in that page.");

                entity.Property(e => e.RoleFunctionPrivilegeId).HasColumnName("RoleFunctionPrivilegeID");

                entity.Property(e => e.FunctionId).HasColumnName("FunctionID");

                entity.Property(e => e.PageModuleId).HasColumnName("PageModuleID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Function)
                    .WithMany(p => p.RoleFunctionPrivileges)
                    .HasForeignKey(d => d.FunctionId)
                    .HasConstraintName("FK_RoleFunctionPrivileges_Functions");

                entity.HasOne(d => d.PageModule)
                    .WithMany(p => p.RoleFunctionPrivileges)
                    .HasForeignKey(d => d.PageModuleId)
                    .HasConstraintName("FK_RoleFunctionPrivileges_RoleFunctionPrivileges");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleFunctionPrivileges)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_RoleFunctionPrivileges_Roles");
            });

            modelBuilder.Entity<RoleFunctions>(entity =>
            {
                entity.HasKey(e => e.RoleFunctionId);

                entity.Property(e => e.RoleFunctionId).HasColumnName("RoleFunctionID");

                entity.Property(e => e.FunctionId).HasColumnName("FunctionID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.HasOne(d => d.Function)
                    .WithMany(p => p.RoleFunctions)
                    .HasForeignKey(d => d.FunctionId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RoleFunctions_Functions");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.RoleFunctions)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_RoleFunctions_Roles");
            });

            modelBuilder.Entity<ScmreasonDetails>(entity =>
            {
                entity.HasKey(e => e.Scmid)
                    .HasName("PK_AttachmentTypeId");

                entity.ToTable("SCMReasonDetails", "Project");

                entity.Property(e => e.Scmid).HasColumnName("SCMId");

                entity.Property(e => e.Datetime).HasColumnType("datetime");

                entity.Property(e => e.Reason)
                    .IsRequired()
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.WeekDatetime).HasColumnType("datetime");

                entity.HasOne(d => d.SourceCodeRepo)
                    .WithMany(p => p.ScmreasonDetails)
                    .HasForeignKey(d => d.SourceCodeRepoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SCMReasonDetail_RepoId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ScmreasonDetails)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SCMReasonDetail_UserId");
            });

            modelBuilder.Entity<Server>(entity =>
            {
                entity.ToTable("Server", "ServerMgmt");

                entity.Property(e => e.AssetId).HasMaxLength(500);

                entity.Property(e => e.AssignToId).HasColumnName("AssignTo_Id");

                entity.Property(e => e.Connection)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("createdDate")
                    .HasColumnType("date");

                entity.Property(e => e.FloorId).HasColumnName("FloorID");

                entity.Property(e => e.Hddsize)
                    .HasColumnName("HDDSize")
                    .HasMaxLength(500);

                entity.Property(e => e.IpAddresss)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Os).HasColumnName("OS");

                entity.Property(e => e.Port)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Processor)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.ProjectIds)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.RackNo).HasMaxLength(500);

                entity.Property(e => e.Raid).HasMaxLength(500);

                entity.Property(e => e.Ram)
                    .HasColumnName("RAM")
                    .HasMaxLength(500);

                entity.Property(e => e.ServerDescription).HasMaxLength(2000);

                entity.Property(e => e.ServerEdition).HasMaxLength(500);

                entity.Property(e => e.ServerMake).HasMaxLength(500);

                entity.Property(e => e.ServerModel).HasMaxLength(500);

                entity.Property(e => e.ServerName).HasMaxLength(500);

                entity.Property(e => e.Type)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.AssignTo)
                    .WithMany(p => p.Server)
                    .HasForeignKey(d => d.AssignToId)
                    .HasConstraintName("FK__Server__AssignTo__70A0FA12");
            });

            modelBuilder.Entity<ServerAccessInfo>(entity =>
            {
                entity.ToTable("ServerAccessInfo", "ServerMgmt");

                entity.Property(e => e.AssignedOn).HasColumnType("date");

                entity.Property(e => e.ReleasedDate).HasColumnType("date");

                entity.Property(e => e.RequestedDate).HasColumnType("date");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Server)
                    .WithMany(p => p.ServerAccessInfo)
                    .HasForeignKey(d => d.ServerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Server_ServerIDAccess");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.ServerAccessInfo)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Users_UserIDAccess");
            });

            modelBuilder.Entity<ServerOs>(entity =>
            {
                entity.ToTable("ServerOS", "ServerMgmt");

                entity.Property(e => e.ServerOsid).HasColumnName("ServerOSId");

                entity.Property(e => e.ServerOsname)
                    .HasColumnName("ServerOSName")
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ServerPatchInfo>(entity =>
            {
                entity.ToTable("ServerPatchInfo", "ServerMgmt");

                entity.Property(e => e.CreatedDate).HasColumnType("date");

                entity.Property(e => e.Description)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FileName).IsUnicode(false);

                entity.Property(e => e.FilePath).IsUnicode(false);

                entity.Property(e => e.PatchName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Server)
                    .WithMany(p => p.ServerPatchInfo)
                    .HasForeignKey(d => d.ServerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Server_ServerIDPatch");
            });

            modelBuilder.Entity<ServerPort>(entity =>
            {
                entity.ToTable("ServerPort", "ServerMgmt");

                entity.Property(e => e.AssignedDate).HasColumnType("date");

                entity.Property(e => e.Comments)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Dnsname)
                    .HasColumnName("DNSName")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.EndDate).HasColumnType("date");

                entity.Property(e => e.ExternalIp)
                    .HasColumnName("ExternalIP")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.ExternalPort)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.InternalIp)
                    .HasColumnName("InternalIP")
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.InternalPort)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.Property(e => e.StartDate).HasColumnType("date");

                entity.HasOne(d => d.Server)
                    .WithMany(p => p.ServerPort)
                    .HasForeignKey(d => d.ServerId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Server_ServerId");
            });

            modelBuilder.Entity<ServiceMailSendingCheck>(entity =>
            {
                entity.HasKey(e => e.Checkid)
                    .HasName("PK__ServiceM__86804B1E537AAB7F");

                entity.Property(e => e.MailSentDate).HasColumnType("datetime");

                entity.Property(e => e.MailTemplateName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SkillSpecificationMapping>(entity =>
            {
                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.SkillSpecificationMapping)
                    .HasForeignKey(d => d.SkillId)
                    .HasConstraintName("fk_SkillSpecificationMapping_SkillId");

                entity.HasOne(d => d.Specification)
                    .WithMany(p => p.SkillSpecificationMapping)
                    .HasForeignKey(d => d.SpecificationId)
                    .HasConstraintName("fk_SkillSpecificationMapping_SpecificationId");
            });

            modelBuilder.Entity<Skills>(entity =>
            {
                entity.Property(e => e.ApprovedDate).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Experiance)
                    .HasColumnName("experiance")
                    .HasMaxLength(5)
                    .IsUnicode(false);

                entity.Property(e => e.RejectedReason)
                    .HasColumnName("Rejected_Reason")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Status).HasColumnName("status");

                entity.HasOne(d => d.SpecializationNavigation)
                    .WithMany(p => p.Skills)
                    .HasForeignKey(d => d.Specialization)
                    .HasConstraintName("FK__Skills__Speciali__4C214075");
            });

            modelBuilder.Entity<SkillsSpecification>(entity =>
            {
                entity.HasKey(e => e.SpecificationId)
                    .HasName("PK__Specific__A384CDFD45F365D3");

                entity.Property(e => e.Specification)
                    .IsRequired()
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SkillsTechnology>(entity =>
            {
                entity.HasKey(e => e.SkillId)
                    .HasName("PK__Master_S__DFA091876FB49575");

                entity.HasComment("Contains the list of Skill Names used in Skills Pages.");

                entity.Property(e => e.SkillName)
                    .IsRequired()
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<SonarQubeProjectAuditLog>(entity =>
            {
                entity.ToTable("SonarQubeProjectAuditLog", "Dev-Ops");

                entity.Property(e => e.BugsRating)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Coverage).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DebtRating)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.Duplications).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.DuplicationsRating)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.LastAnalysisDate).HasColumnType("datetime");

                entity.Property(e => e.NewBugsRating)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NewCoverage).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NewDebtRating)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.NewDuplications).HasColumnType("decimal(5, 2)");

                entity.Property(e => e.NewVulnerabilitiesRating)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.Property(e => e.VulnerabilitiesRating)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .IsFixedLength();

                entity.HasOne(d => d.AuditLog)
                    .WithMany(p => p.SonarQubeProjectAuditLog)
                    .HasForeignKey(d => d.AuditLogId)
                    .HasConstraintName("FK_SonarQubeProjectAuditLog_AuditLog");

                entity.HasOne(d => d.SourceCodeRepo)
                    .WithMany(p => p.SonarQubeProjectAuditLog)
                    .HasForeignKey(d => d.SourceCodeRepoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SonarQubeProjectAuditLog_SonarQubeProject");
            });

            modelBuilder.Entity<SourceCodeRepoAuditLog>(entity =>
            {
                entity.ToTable("SourceCodeRepoAuditLog", "Dev-Ops");

                entity.Property(e => e.LastCommitBranch).HasMaxLength(500);

                entity.Property(e => e.LastCommitDateTime).HasColumnType("datetime");

                entity.Property(e => e.LastCommitDevName).HasMaxLength(500);

                entity.Property(e => e.MasterBranchName).HasMaxLength(500);

                entity.Property(e => e.MasterCommitDateTime).HasColumnType("datetime");

                entity.Property(e => e.MasterCommitMessage).HasMaxLength(500);

                entity.Property(e => e.MasterCommitterName).HasMaxLength(500);

                entity.HasOne(d => d.AuditLog)
                    .WithMany(p => p.SourceCodeRepoAuditLog)
                    .HasForeignKey(d => d.AuditLogId)
                    .HasConstraintName("FK_SourceCodeRepoAuditLogId");

                entity.HasOne(d => d.SourceCodeRepo)
                    .WithMany(p => p.SourceCodeRepoAuditLog)
                    .HasForeignKey(d => d.SourceCodeRepoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SourceCodeRepoId");
            });

            modelBuilder.Entity<SourceCodeRepoDetail>(entity =>
            {
                entity.HasKey(e => e.SourceCodeRepoId)
                    .HasName("PK_SourceCodeRepoId");

                entity.ToTable("SourceCodeRepoDetail", "Dev-Ops");

                entity.Property(e => e.AccessToken).HasMaxLength(1000);

                entity.Property(e => e.GitLabProjectId).HasColumnName("GitLabProjectID");

                entity.Property(e => e.JenkinsProjectName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.OrganizationName)
                    .HasMaxLength(300)
                    .IsUnicode(false);

                entity.Property(e => e.Password).HasMaxLength(1000);

                entity.Property(e => e.RecordInsertedDate).HasColumnType("datetime");

                entity.Property(e => e.SonarQubeProjectName)
                    .HasMaxLength(4000)
                    .IsUnicode(false);

                entity.Property(e => e.SourceCodeRepoCreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.SourceCodeRepoName)
                    .IsRequired()
                    .HasMaxLength(500);

                entity.Property(e => e.SourceCodeTypeId).HasColumnName("SourceCodeTypeID");

                entity.Property(e => e.Url).HasColumnName("URL");

                entity.Property(e => e.UserName).HasMaxLength(1000);

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.SourceCodeRepoDetail)
                    .HasForeignKey(d => d.ProjectId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_ProjectId");

                entity.HasOne(d => d.SourceCodeType)
                    .WithMany(p => p.SourceCodeRepoDetail)
                    .HasForeignKey(d => d.SourceCodeTypeId)
                    .HasConstraintName("FK_SourceCodeTypeID");
            });

            modelBuilder.Entity<SourceCodeRepoType>(entity =>
            {
                entity.ToTable("SourceCodeRepoType", "Dev-Ops");

                entity.Property(e => e.SourceCodeRepoName)
                    .IsRequired()
                    .HasMaxLength(2000);
            });

            modelBuilder.Entity<SourceControlValues>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.SourceControlId).HasColumnName("SourceControlID");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.SourceControlValues)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_SourceControlValues_Projects");

                entity.HasOne(d => d.SourceControl)
                    .WithMany(p => p.SourceControlValues)
                    .HasForeignKey(d => d.SourceControlId)
                    .HasConstraintName("FK_SourceControlValues_SourceControl");
            });

            modelBuilder.Entity<SourceRepoBranchDetail>(entity =>
            {
                entity.HasKey(e => e.SourceRepoBranchDetail1);

                entity.ToTable("SourceRepoBranchDetail", "Dev-Ops");

                entity.Property(e => e.SourceRepoBranchDetail1).HasColumnName("SourceRepoBranchDetail");

                entity.Property(e => e.BranchCreatedDateTime).HasColumnType("datetime");

                entity.Property(e => e.LastCommittedDate).HasColumnType("datetime");

                entity.Property(e => e.SourceRepoId).HasColumnName("SourceRepoID");

                entity.HasOne(d => d.SourceRepo)
                    .WithMany(p => p.SourceRepoBranchDetail)
                    .HasForeignKey(d => d.SourceRepoId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_SourceRepoID");
            });

            modelBuilder.Entity<StarPerformanceDetails>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.MonthandYear)
                    .IsRequired()
                    .HasColumnName("Monthand Year")
                    .HasMaxLength(50);

                entity.Property(e => e.Reason).HasMaxLength(4000);

                entity.HasOne(d => d.User)
                    .WithMany(p => p.StarPerformanceDetails)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__StarPerfo__UserI__44035DC5");
            });

            modelBuilder.Entity<Status>(entity =>
            {
                entity.Property(e => e.Statusid).ValueGeneratedNever();

                entity.Property(e => e.StatusName)
                    .IsRequired()
                    .HasMaxLength(50);
            });

            modelBuilder.Entity<TaggedAlbums>(entity =>
            {
                entity.HasKey(e => e.TaggedAlbumId);

                entity.HasOne(d => d.Album)
                    .WithMany(p => p.TaggedAlbums)
                    .HasForeignKey(d => d.AlbumId)
                    .HasConstraintName("FK_TaggedAlbums_Album");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TaggedAlbums)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_TaggedAlbums_Users");
            });

            modelBuilder.Entity<TaskSource>(entity =>
            {
                entity.ToTable("Task_Source");

                entity.Property(e => e.TaskSource1)
                    .HasColumnName("Task Source")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TaskStatus>(entity =>
            {
                entity.ToTable("Task_Status");

                entity.Property(e => e.Status).IsUnicode(false);
            });

            modelBuilder.Entity<TeamLunchRequest>(entity =>
            {
                entity.HasKey(e => e.TlrequestId)
                    .HasName("PK__TeamLunc__C414FE5A40BCDCC6");

                entity.Property(e => e.TlrequestId).HasColumnName("TLRequestId");

                entity.Property(e => e.Amount)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Comments).HasMaxLength(2000);

                entity.Property(e => e.PlannedDate).HasColumnType("datetime");

                entity.Property(e => e.ProjectId)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.RequestedDate).HasColumnType("datetime");

                entity.Property(e => e.RescheduledDate).HasColumnType("datetime");

                entity.Property(e => e.TeamMembersId)
                    .HasMaxLength(200)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TechnologyValues>(entity =>
            {
                entity.HasOne(d => d.Tecnology)
                    .WithMany(p => p.TechnologyValues)
                    .HasForeignKey(d => d.TecnologyId)
                    .HasConstraintName("FK_TechnologyValues_Technologies");
            });

            modelBuilder.Entity<TempUsers>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.BranchId).HasColumnName("BranchID");

                entity.Property(e => e.UserEmpId)
                    .HasColumnName("UserEmpID")
                    .HasMaxLength(255);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserName).HasMaxLength(255);
            });

            modelBuilder.Entity<TestLeaves>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("TEST_LEAVES");

                entity.Property(e => e.DateData).HasColumnType("datetime");

                entity.Property(e => e.LeaveType).HasMaxLength(51);

                entity.Property(e => e.Lop).HasColumnName("LOP");

                entity.Property(e => e.Userid).HasColumnName("userid");
            });

            modelBuilder.Entity<TestMailIds>(entity =>
            {
                entity.HasKey(e => e.MailId)
                    .HasName("PK__TestMail__09A874FA2D27B809");

                entity.ToTable("TestMailIDs");

                entity.Property(e => e.MailId).HasColumnName("MailID");

                entity.Property(e => e.MailAddress)
                    .HasMaxLength(500)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<ThirdPartyValues>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.ThirdPartyToolsId).HasColumnName("ThirdParty_Tools_ID");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.ThirdPartyValues)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_ThirdPartyValues_Projects");

                entity.HasOne(d => d.ThirdPartyTools)
                    .WithMany(p => p.ThirdPartyValues)
                    .HasForeignKey(d => d.ThirdPartyToolsId)
                    .HasConstraintName("FK_ThirdPartyValues_ThirdParty");
            });

            modelBuilder.Entity<TimeLog>(entity =>
            {
                entity.Property(e => e.TimeLogId).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EmployeeId)
                    .IsRequired()
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OutTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TimeLogDetail>(entity =>
            {
                entity.Property(e => e.TimeLogDetailId).ValueGeneratedNever();

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.InTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OutTime)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.PunchLocation)
                    .WithMany(p => p.TimeLogDetail)
                    .HasForeignKey(d => d.PunchLocationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TimeLogDetail_PunchLocationId");

                entity.HasOne(d => d.TimeLog)
                    .WithMany(p => p.TimeLogDetail)
                    .HasForeignKey(d => d.TimeLogId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TimeLogDetail_TimeLogId");
            });

            modelBuilder.Entity<TimeManagement>(entity =>
            {
                entity.HasKey(e => e.TimeManagement1);

                entity.Property(e => e.TimeManagement1).HasColumnName("TimeManagement");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.EmpId)
                    .IsRequired()
                    .HasColumnName("EmpID")
                    .HasMaxLength(20);

                entity.Property(e => e.InTime).HasMaxLength(6);

                entity.Property(e => e.OutTime).HasMaxLength(6);
            });

            modelBuilder.Entity<TimeZone>(entity =>
            {
                entity.Property(e => e.Zone).IsUnicode(false);
            });

            modelBuilder.Entity<TimesheetType>(entity =>
            {
                entity.Property(e => e.TimesheetTypeId).HasColumnName("TimesheetTypeID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.TimesheetType)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_TimesheetType_Projects");
            });

            modelBuilder.Entity<Training>(entity =>
            {
                entity.Property(e => e.EndTime)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.Flag).HasDefaultValueSql("((0))");

                entity.Property(e => e.InitiatedBy)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InitiatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.MailDepartments)
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.NotifyUsers)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.RecheduledDate).HasColumnType("datetime");

                entity.Property(e => e.Repository)
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.Roleid).HasColumnName("roleid");

                entity.Property(e => e.ScheduledDate).HasColumnType("date");

                entity.Property(e => e.ScheduledEndDate).HasColumnType("date");

                entity.Property(e => e.StartTime)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.Level)
                    .WithMany(p => p.Training)
                    .HasForeignKey(d => d.LevelId)
                    .HasConstraintName("FK__Training__LevelI__269AB60B");

                entity.HasOne(d => d.Status)
                    .WithMany(p => p.Training)
                    .HasForeignKey(d => d.StatusId)
                    .HasConstraintName("FK__Training__Status__297722B6");

                entity.HasOne(d => d.Technology)
                    .WithMany(p => p.Training)
                    .HasForeignKey(d => d.TechnologyId)
                    .HasConstraintName("FK__Training__Techno__3118447E");

                entity.HasOne(d => d.TrainingType)
                    .WithMany(p => p.Training)
                    .HasForeignKey(d => d.TrainingTypeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK__Training__Traini__34E8D562");
            });

            modelBuilder.Entity<TrainingCompletion>(entity =>
            {
                entity.HasKey(e => e.CompletionId)
                    .HasName("PK__Training__77FA708F25869641");

                entity.Property(e => e.Attendece)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.Material)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingName)
                    .HasMaxLength(250)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrainingDeliveryLog>(entity =>
            {
                entity.HasKey(e => e.DeliveryLogId)
                    .HasName("PK__Training__D6A7BA8E52BB9170");

                entity.Property(e => e.DeliveryLogId).HasColumnName("DeliveryLogID");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.TrainingId).HasColumnName("TrainingID");

                entity.HasOne(d => d.EmailTemplate)
                    .WithMany(p => p.TrainingDeliveryLog)
                    .HasForeignKey(d => d.EmailTemplateId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_TrainingDeliveryLog_EmailTemplateId");
            });

            modelBuilder.Entity<TrainingEmailLog>(entity =>
            {
                entity.HasKey(e => e.TrainingEmailLog1)
                    .HasName("PK__Training__FB4C358858746AC6");

                entity.Property(e => e.TrainingEmailLog1).HasColumnName("TrainingEmailLog");

                entity.Property(e => e.DeliveredDate).HasColumnType("datetime");

                entity.Property(e => e.InsertedDate).HasColumnType("datetime");

                entity.Property(e => e.UserEmail).HasMaxLength(510);

                entity.HasOne(d => d.DeliveryLog)
                    .WithMany(p => p.TrainingEmailLog)
                    .HasForeignKey(d => d.DeliveryLogId)
                    .HasConstraintName("FK_TrainingEmailLog_DeliveryLogId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.TrainingEmailLog)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_TrainingEmailLog_UserId");
            });

            modelBuilder.Entity<TrainingFeedBackCalc>(entity =>
            {
                entity.HasKey(e => e.FeedbackId)
                    .HasName("PK__Training__6A4BEDD61DE57479");

                entity.Property(e => e.FacultyAssistance).HasColumnName("facultyAssistance");

                entity.Property(e => e.FeedBackSentOn).HasColumnType("datetime");
            });

            modelBuilder.Entity<TrainingFeedbackAggregate>(entity =>
            {
                entity.HasKey(e => e.Faid)
                    .HasName("PK__Training__96DFF7AB21B6055D");

                entity.Property(e => e.Faid).HasColumnName("FAId");

                entity.Property(e => e.FacultyQrating).HasColumnName("FacultyQRating");

                entity.Property(e => e.NoOfAttendees).HasColumnName("No_Of_Attendees");
            });

            modelBuilder.Entity<TrainingInstructors>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.InstructorId).ValueGeneratedOnAdd();

                entity.Property(e => e.InstructorName)
                    .HasMaxLength(80)
                    .IsUnicode(false);

                entity.Property(e => e.Userid).HasColumnName("USERID");
            });

            modelBuilder.Entity<TrainingMailPurpose>(entity =>
            {
                entity.HasKey(e => e.TrainingId)
                    .HasName("PK__Training__E8D71D8215A53433");

                entity.Property(e => e.EndTime)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.InitiatedOn).HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.ScheduledDate).HasColumnType("date");

                entity.Property(e => e.ScheduledEndDate).HasColumnType("date");

                entity.Property(e => e.StartTime)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingName)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.HasOne(d => d.Technology)
                    .WithMany(p => p.TrainingMailPurpose)
                    .HasForeignKey(d => d.TechnologyId)
                    .HasConstraintName("FK__TrainingM__Techn__38B96646");
            });

            modelBuilder.Entity<TrainingNomination>(entity =>
            {
                entity.HasKey(e => e.NominationId)
                    .HasName("PK__Training__8E9B8A50145C0A3F");

                entity.Property(e => e.EmailId)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmpId)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.EmpName)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((0))");

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Project)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ProjectWon)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Purpose)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Reason).IsUnicode(false);

                entity.Property(e => e.SupervisorId)
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.SupervisorName)
                    .HasMaxLength(100)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TrainingPermission>(entity =>
            {
                entity.HasNoKey();

                entity.Property(e => e.PermissionId).HasColumnName("PermissionID");

                entity.Property(e => e.TrainingId)
                    .HasColumnName("TrainingID")
                    .ValueGeneratedOnAdd();

                entity.Property(e => e.UserId).HasColumnName("UserID");
            });

            modelBuilder.Entity<TrainingWeightage>(entity =>
            {
                entity.HasKey(e => e.WeightageId)
                    .HasName("PK__Training__B836402F0CBAE877");
            });

            modelBuilder.Entity<Trainingabsenteesreason>(entity =>
            {
                entity.HasKey(e => e.Reasonid)
                    .HasName("PK__Training__A4F9DC8F4D02B81A");

                entity.Property(e => e.Flag).HasColumnName("flag");

                entity.Property(e => e.Reason).HasMaxLength(100);

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Training)
                    .WithMany(p => p.Trainingabsenteesreason)
                    .HasForeignKey(d => d.Trainingid)
                    .HasConstraintName("FK_Trainingabsenteesreason_TrainingId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.Trainingabsenteesreason)
                    .HasForeignKey(d => d.Userid)
                    .HasConstraintName("FK_Trainingabsenteesreason_UserId");
            });

            modelBuilder.Entity<UserDeviceHistory>(entity =>
            {
                entity.HasKey(e => e.DeviceHistoryId)
                    .HasName("PK__UserDevi__90E8205D383CA55E");

                entity.Property(e => e.ReceivedDate).HasColumnType("datetime");

                entity.Property(e => e.ReleasedDate).HasColumnType("datetime");

                entity.Property(e => e.RequestedDate).HasColumnType("datetime");

                entity.Property(e => e.Userid).HasColumnName("userid");

                entity.HasOne(d => d.Device)
                    .WithMany(p => p.UserDeviceHistory)
                    .HasForeignKey(d => d.DeviceId)
                    .HasConstraintName("FK_DeviceIds");

                entity.HasOne(d => d.DeviceStatusNavigation)
                    .WithMany(p => p.UserDeviceHistory)
                    .HasForeignKey(d => d.DeviceStatus)
                    .HasConstraintName("FK_DeviceStatus");
            });

            modelBuilder.Entity<UserFeedback>(entity =>
            {
                entity.ToTable("UserFeedback", "Feedback");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasMaxLength(2000);

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserFeedback)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Feedback_UserFeedbackId");
            });

            modelBuilder.Entity<UserHrreporting>(entity =>
            {
                entity.HasKey(e => e.Hrid);

                entity.ToTable("UserHRReporting");

                entity.Property(e => e.Hrid).HasColumnName("HRID");

                entity.Property(e => e.ReportingHrid).HasColumnName("ReportingHRID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserHrreporting)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserHRReporting_Users");
            });

            modelBuilder.Entity<UserMarketingReporting>(entity =>
            {
                entity.HasKey(e => e.MarketingId);

                entity.Property(e => e.MarketingId).HasColumnName("MarketingID");

                entity.Property(e => e.ReportingMarketingId).HasColumnName("ReportingMarketingID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserMarketingReporting)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserMarketingReporting_Users");
            });

            modelBuilder.Entity<UserProfile>(entity =>
            {
                entity.HasComment("It contains the list of Users and their Photo used in Organisation Chart Page.");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserProfile)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserProfile_Users");
            });

            modelBuilder.Entity<UserProjects>(entity =>
            {
                entity.HasKey(e => e.UserProjectId);

                entity.HasComment("It contains the List of Projects and the users assigned to the particular Project.");

                entity.Property(e => e.UserProjectId).HasColumnName("UserProjectID");

                entity.Property(e => e.IsCritical).HasColumnName("Is_Critical");

                entity.Property(e => e.MemberTypeId).HasColumnName("MemberTypeID");

                entity.Property(e => e.ProjectId).HasColumnName("ProjectID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserAssignedEndDate).HasColumnType("datetime");

                entity.Property(e => e.UserEndDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.UserStartDate).HasColumnType("datetime");

                entity.HasOne(d => d.Project)
                    .WithMany(p => p.UserProjects)
                    .HasForeignKey(d => d.ProjectId)
                    .HasConstraintName("FK_UserProjects_Projects");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserProjects)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.Cascade)
                    .HasConstraintName("FK_UserProjects_Roles");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserProjects)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserProjects_Users");
            });

            modelBuilder.Entity<UserQuickAccessMenu>(entity =>
            {
                entity.ToTable("UserQuickAccessMenu", "QuickAccess");

                entity.Property(e => e.UserQuickAccessMenuId).HasColumnName("UserQuickAccessMenuID");

                entity.Property(e => e.DisplayName).HasMaxLength(500);

                entity.Property(e => e.ModDate).HasColumnType("datetime");

                entity.Property(e => e.QuickAccessMenuId).HasColumnName("QuickAccessMenuID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.QuickAccessMenu)
                    .WithMany(p => p.UserQuickAccessMenu)
                    .HasForeignKey(d => d.QuickAccessMenuId)
                    .HasConstraintName("FK_UserQuickAccessMenu_PageId_QuickAccessMenuID_QuickAccessMenu_QuickAccessMenuID");
            });

            modelBuilder.Entity<UserReporting>(entity =>
            {
                entity.HasKey(e => e.ReportingId);

                entity.HasComment("It contains the list of UsersID and their Reporting Persons UserID.");

                entity.Property(e => e.ReportingId).HasColumnName("ReportingID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.ReportingUserId).HasColumnName("ReportingUserID");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserReporting)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UserReporting_Users");
            });

            modelBuilder.Entity<UserRoleQuickAccessMenu>(entity =>
            {
                entity.ToTable("UserRoleQuickAccessMenu", "QuickAccess");

                entity.HasOne(d => d.QuickAccessMenu)
                    .WithMany(p => p.UserRoleQuickAccessMenu)
                    .HasForeignKey(d => d.QuickAccessMenuId)
                    .HasConstraintName("FK_UserRoleQuickAccessMenu_QuickAccessMenuId_QuickAccessMenu_QuickAccessMenuId");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoleQuickAccessMenu)
                    .HasForeignKey(d => d.RoleId)
                    .HasConstraintName("FK_UserRoleQuickAccessMenu_RoleId_Master_Roles_RoleId");
            });

            modelBuilder.Entity<UserRoles>(entity =>
            {
                entity.HasKey(e => e.UserRoleId);

                entity.HasComment("It contains the list of userID and their RoleID.");

                entity.Property(e => e.UserRoleId).HasColumnName("UserRoleID");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.Role)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.RoleId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRoles_Roles");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserRoles)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserRoles_UserRoles");
            });

            modelBuilder.Entity<UserSkills>(entity =>
            {
                entity.HasComment("It contains the list of user ID and their skills used in Employee Management page.");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserSkills)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserSkills_Users");
            });

            modelBuilder.Entity<UserSoftwares>(entity =>
            {
                entity.HasKey(e => e.UserSoftwareId)
                    .HasName("UserSoftwareId");

                entity.ToTable("UserSoftwares", "Project");

                entity.Property(e => e.RequestedDate).HasColumnType("datetime");

                entity.HasOne(d => d.ProjectSoftware)
                    .WithMany(p => p.UserSoftwares)
                    .HasForeignKey(d => d.ProjectSoftwareId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserSoft_ProjectSoftwareId");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserSoftwares)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_UserSoft_UserId");
            });

            modelBuilder.Entity<UserTask>(entity =>
            {
                entity.ToTable("User_Task");

                entity.Property(e => e.CreatedDate).HasColumnType("datetime");

                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .IsUnicode(false);

                entity.Property(e => e.Odid).HasColumnName("ODId");

                entity.Property(e => e.TaskId).IsUnicode(false);

                entity.HasOne(d => d.Od)
                    .WithMany(p => p.UserTask)
                    .HasForeignKey(d => d.Odid)
                    .HasConstraintName("FK_User_Task_OutOfOfficeDetails");
            });

            modelBuilder.Entity<UserTraining>(entity =>
            {
                entity.Property(e => e.UserTrainingId).HasColumnName("UserTrainingID");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.TrainingId).HasColumnName("TrainingID");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UserTraining)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK__UserTrain__IsAct__0A40D084");
            });

            modelBuilder.Entity<Users>(entity =>
            {
                entity.HasKey(e => e.UserId);

                entity.HasComment("It Contains all the General Information about the total users. It is the primary table of the HRMS Portal.");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.Property(e => e.AlternateNumber).IsUnicode(false);

                entity.Property(e => e.AnniversaryDate).HasColumnType("datetime");

                entity.Property(e => e.AttemptDate)
                    .HasColumnName("Attempt_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.BirthPlace)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BloodGroup).HasMaxLength(5);

                entity.Property(e => e.ConfirmationDate).HasColumnType("datetime");

                entity.Property(e => e.Contactperson)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedAt).HasColumnType("datetime");

                entity.Property(e => e.CreatedUserId).HasColumnName("CreatedUserID");

                entity.Property(e => e.DateOfBirth).HasColumnType("datetime");

                entity.Property(e => e.DateOfJoin).HasColumnType("datetime");

                entity.Property(e => e.DeliveryManagerId)
                    .HasColumnName("DeliveryManagerID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DesignationId).HasColumnName("DesignationID");

                entity.Property(e => e.DirectReportingTo).HasMaxLength(50);

                entity.Property(e => e.EmailAddress).HasMaxLength(255);

                entity.Property(e => e.EmpCode).HasMaxLength(50);

                entity.Property(e => e.EmpId)
                    .HasColumnName("EmpID")
                    .HasMaxLength(10);

                entity.Property(e => e.Experience).HasMaxLength(50);

                entity.Property(e => e.Extension).HasColumnName("extension");

                entity.Property(e => e.FatherDob)
                    .HasColumnName("FatherDOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.FatherInLawDob)
                    .HasColumnName("FatherInLawDOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.FatherInLawFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FatherInLawLastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FatherName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FathersLastName).HasMaxLength(50);

                entity.Property(e => e.FirstName).HasMaxLength(50);

                entity.Property(e => e.Ipaddress)
                    .HasColumnName("IPAddress")
                    .HasMaxLength(50);

                entity.Property(e => e.IsItrequestAccepted).HasColumnName("IsITRequestAccepted");

                entity.Property(e => e.Key).IsUnicode(false);

                entity.Property(e => e.LastAccessed).HasColumnType("datetime");

                entity.Property(e => e.LastName).HasMaxLength(50);

                entity.Property(e => e.LastWorkingDate).HasColumnType("date");

                entity.Property(e => e.MachineName).HasMaxLength(50);

                entity.Property(e => e.MiddleName).HasMaxLength(50);

                entity.Property(e => e.MotherDob)
                    .HasColumnName("MotherDOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.MotherInLawDob)
                    .HasColumnName("MotherInLawDOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.MotherInLawFirstName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MotherInLawLastName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MotherName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MothersLastName).HasMaxLength(50);

                entity.Property(e => e.NationalityId).HasColumnName("NationalityID");

                entity.Property(e => e.OfficeSkypeId).HasMaxLength(100);

                entity.Property(e => e.Officeno).HasColumnName("officeno");

                entity.Property(e => e.PermanentAddressId).HasColumnName("PermanentAddressID");

                entity.Property(e => e.PersonalEmail).IsUnicode(false);

                entity.Property(e => e.RelationshipId).HasColumnName("RelationshipID");

                entity.Property(e => e.ReligionId).HasColumnName("ReligionID");

                entity.Property(e => e.ResignedOn).HasColumnType("date");

                entity.Property(e => e.RoleId).HasColumnName("RoleID");

                entity.Property(e => e.SamsAccountName).HasMaxLength(100);

                entity.Property(e => e.SpouseDob)
                    .HasColumnName("SpouseDOB")
                    .HasColumnType("datetime");

                entity.Property(e => e.SpouseName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SpouseNumber).IsUnicode(false);

                entity.Property(e => e.TemporaryAddressId).HasColumnName("TemporaryAddressID");

                entity.Property(e => e.TestingDevicePin).HasColumnName("TestingDevicePIN");

                entity.Property(e => e.UserName).HasMaxLength(50);

                entity.Property(e => e.UserWfhcount).HasColumnName("UserWFHCount");

                entity.Property(e => e.Workplace)
                    .HasMaxLength(25)
                    .IsUnicode(false);

                entity.HasOne(d => d.DepartmentNavigation)
                    .WithMany(p => p.Users)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_Users_Department");
            });

            modelBuilder.Entity<UsersFeedback>(entity =>
            {
                entity.HasComment("It contains the List of sent Feedback of the individual users.");

                entity.Property(e => e.FeedbackDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.UsersFeedback)
                    .HasForeignKey(d => d.UserId)
                    .HasConstraintName("FK_UsersFeedback_Users");
            });

            modelBuilder.Entity<ViewEmail>(entity =>
            {
                entity.HasComment("It Contains the list of E-Mails used in Communication Pages.");

                entity.Property(e => e.Attachment)
                    .HasMaxLength(10)
                    .IsFixedLength();

                entity.Property(e => e.Attachmentpath).IsUnicode(false);

                entity.Property(e => e.CcEmail).IsUnicode(false);

                entity.Property(e => e.FromEmail).IsUnicode(false);

                entity.Property(e => e.Message).IsUnicode(false);

                entity.Property(e => e.SentOn).HasColumnType("datetime");

                entity.Property(e => e.Sign).IsUnicode(false);

                entity.Property(e => e.Subject).IsUnicode(false);

                entity.Property(e => e.ToEmail).IsUnicode(false);
            });

            modelBuilder.Entity<ViewallProjectPermission>(entity =>
            {
                entity.HasKey(e => e.ProjectPermissionId)
                    .HasName("PK__ViewallP__7C46FBC14A8572CB");

                entity.HasComment("It contains the list of Users ID who has the permission to Access all Projects.");
            });

            modelBuilder.Entity<WindowsAuthentication>(entity =>
            {
                entity.HasKey(e => e.AppId);

                entity.Property(e => e.AppKey).HasMaxLength(100);
            });

            modelBuilder.Entity<WorkFromHomeEntry>(entity =>
            {
                entity.HasKey(e => e.Wfhid)
                    .HasName("PK_WFHId");

                entity.Property(e => e.Wfhid).HasColumnName("WFHId");

                entity.Property(e => e.EndDate).HasColumnType("datetime");

                entity.Property(e => e.RequestedDate).HasColumnType("datetime");

                entity.Property(e => e.StartDate).HasColumnType("datetime");

                entity.Property(e => e.UserId).HasColumnName("UserID");

                entity.HasOne(d => d.EnteredByNavigation)
                    .WithMany(p => p.WorkFromHomeEntryEnteredByNavigation)
                    .HasForeignKey(d => d.EnteredBy)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WFHEnteredBy");

                entity.HasOne(d => d.User)
                    .WithMany(p => p.WorkFromHomeEntryUser)
                    .HasForeignKey(d => d.UserId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_WFHId");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
